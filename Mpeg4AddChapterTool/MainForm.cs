using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagePack;

namespace Mpeg4AddChapterTool
{
    internal partial class MainForm : Form
    {
        private const string TextBoxNewLine = "\r\n";

        private IFormatterResolver JsonResolver { get; } = MessagePack.Resolvers.StandardResolverAllowPrivate.Instance;

        private const int ChapterListTabItemIndex = 0;
        private const int RunningTabItemIndex = 1;
        private const int SettingTabItemIndex = 2;

        private readonly Regex Mp4BoxProgressMessageRegex = new Regex(@"^.*:\s\|[=,\s]*\|\s\((?<per>\d+)\/100\)\r?\n?$", RegexOptions.Compiled);

        private const string SettingFilePath = "settings.bin";

        public Settings Settings { get; private set; }

        public bool IsRunning { get; private set; } = false;

        public bool IsAborting { get; private set; } = false;

        public MainForm()
        {
            this.InitializeComponent();

            Environment.CurrentDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        #region Chapter list

        private void OnChapterItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this.chapterRemoveButton.Enabled = e.IsSelected;
        }

        private void OnChapterAddButtonClicked(object sender, EventArgs e)
        {
            var dialog = new ChapterFileSelector();
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                var chapter = dialog.Item;

                var item = new ListViewItem
                {
                    Text = Path.GetFileName(chapter.VideoFileName),
                    ToolTipText = chapter.VideoFileName,
                };

                item.SubItems.Add(Path.GetFileName(chapter.ChapterFileName));
                item.SubItems.Add(Path.GetFileName(chapter.ChapterFileName2));

                item.Tag = chapter;

                this.chapterItemList.Items.Add(item);
            }

            this.UpdateRunButton();
        }

        private void OnChapterRemoveButtonClicked(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.chapterItemList.SelectedItems)
            {
                this.chapterItemList.Items.Remove(item);
            }

            this.UpdateRunButton();
        }

        #endregion Chapter list

        #region Chapter edit process

        private Process _currentProcess;
        private int _previousTabItemIndex;
        private bool _isPreviousMessageProgress = false;

        private void UpdateRunButton()
        {
            this.runButton.Enabled = !this.IsRunning && this.chapterItemList.Items.Count > 0;
        }

        private void BeginProcess()
        {
            this.IsRunning = true;
            this.IsAborting = false;
            this._previousTabItemIndex = this.tabControl1.SelectedIndex;

            this.SuspendLayout();

            this.tabPage1.Enabled = false;
            this.tabPage3.Enabled = false;

            this.tabControl1.SelectedIndex = RunningTabItemIndex;

            this.runButton.Enabled = false;
            this.abortButton.Visible = true;
            this.closeButton.Visible = false;

            this.progressBar1.Maximum = this.chapterItemList.Items.Count;
            this.progressBar1.Value = 0;

            this.ResumeLayout();
        }

        private void EndProcess()
        {
            this.SuspendLayout();

            this.tabPage1.Enabled = true;
            this.tabPage3.Enabled = true;

            this.tabControl1.SelectedIndex = RunningTabItemIndex;

            this.runButton.Enabled = true;
            this.abortButton.Visible = false;
            this.closeButton.Visible = true;

            this.ResumeLayout();

            this.IsAborting = false;
            this.IsRunning = false;
        }

        private async void OnRunButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Settings.Mp4BoxPath))
            {
                MessageBox.Show(this,
                    "MP4Boxのパスが設定されていません。", "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.tabControl1.SelectedIndex = SettingTabItemIndex;

                return;
            }

            if (!File.Exists(this.Settings.Mp4BoxPath))
            {
                MessageBox.Show(this,
                    "MP4Boxのパスが見つかりません。設定を見直してください。", "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.tabControl1.SelectedIndex = SettingTabItemIndex;

                return;
            }

            this.BeginProcess();

            int i = 0;

            foreach (ListViewItem item in chapterItemList.Items)
            {
                if (this.IsAborting)
                    break;

                if (item.Tag is ChapterItem chapter)
                {
                    var textBox = this.consoleTextBox;

                    var sb = new StringBuilder();
                    sb.AppendLine("===========================================================");

                    sb.Append("動画　　　 : ");
                    sb.AppendLine(chapter.VideoFileName);
                    sb.Append("チャプター1: ");
                    sb.AppendLine(chapter.ChapterFileName);
                    if (!string.IsNullOrEmpty(chapter.ChapterFileName2))
                    {
                        sb.Append("チャプター2: ");
                        sb.AppendLine(chapter.ChapterFileName2);
                    }
                    sb.AppendLine("===========================================================");
                    sb.AppendLine();

                    textBox.AppendText(sb.ToString());
                    sb = null;

                    if (await this.RegisterChapters(chapter))
                    {
                        if (this.Settings.RemoveSucceedItems)
                        {
                            this.chapterItemList.Items.Remove(item);
                        }
                    }

                    textBox.AppendText(TextBoxNewLine);
                }

                ++i;
                this.progressBar1.Maximum = i;
            }

            this.EndProcess();
        }

        private void OnAbortButtonClicked(object sender, EventArgs e)
        {
            this.IsAborting = true;
            if (!(this._currentProcess?.HasExited ?? true))
            {
                this._currentProcess.Kill();
            }
        }

        private void OnCloseButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private async ValueTask<bool> RegisterChapters(ChapterItem chapter)
        {
            var textBox = this.consoleTextBox;

            if (!File.Exists(chapter.VideoFileName))
            {
                textBox.AppendText("動画ファイルが見つかりません。\n");
                return false;
            }

            if (!File.Exists(chapter.ChapterFileName))
            {
                textBox.AppendText("チャプター情報1に指定されたファイルが見つかりません。\n");
                return false;
            }

            var procArgs = $"\"{ chapter.VideoFileName }\" -chap \"{ chapter.ChapterFileName }\"";

            if (!string.IsNullOrEmpty(chapter.ChapterFileName2))
            {
                if (!File.Exists(chapter.ChapterFileName2))
                {
                    textBox.AppendText("チャプター情報2に指定されたファイルが見つかりません。\n");
                    return false;
                }
                else
                {
                    procArgs += $" -add \"{ chapter.ChapterFileName2 }\":chap";
                }
            }


            var pInfo = new ProcessStartInfo
            {
                FileName = this.Settings.Mp4BoxPath,
                Arguments = procArgs,
                CreateNoWindow = true,
                UseShellExecute = false,
                ErrorDialog = false,
                StandardErrorEncoding = Encoding.UTF8,
                StandardOutputEncoding = Encoding.UTF8,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
            };

            var p = Process.Start(pInfo);
            var outputStream = p.StandardOutput;
            var errorStream = p.StandardError;

            this._currentProcess = p;

            var outputTask = Task.Run(() =>
            {
                while (!outputStream.EndOfStream)
                {
                    this.OnMessageReceived(outputStream.ReadLine());
                }
            });

            var errorTask = Task.Run(() =>
            {
                while (!errorStream.EndOfStream)
                {
                    this.OnMessageReceived(errorStream.ReadLine());
                }
            });

            await Task.Run((Action)p.WaitForExit);

            await Task.WhenAll(outputTask, errorTask);

            this._currentProcess = null;

            return p.ExitCode == 0;
        }

        private void OnMessageReceived(string message)
        {
            var isProgressMessage = this.Mp4BoxProgressMessageRegex.IsMatch(message);

            var tb = this.consoleTextBox;

            tb.Invoke((Action)(() =>
            {
                if (this._isPreviousMessageProgress && isProgressMessage)
                {
                    tb.SuspendLayout();

                    int textLength = tb.Lines[tb.Lines.Length - 2].Length;

                    tb.SelectionStart = tb.Text.Length - textLength - TextBoxNewLine.Length;
                    tb.SelectionLength = textLength;
                    tb.SelectedText = message;

                    tb.SelectionLength = 0;

                    tb.ResumeLayout();
                }
                else
                {
                    tb.AppendText(message);
                    tb.AppendText(TextBoxNewLine);

                    this._isPreviousMessageProgress = isProgressMessage;
                }

            }));
        }

        #endregion Chapter edit process

        #region Setting

        private void OnSelectMp4BoxButtonClicked(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "MP4Box|mp4box.exe",
            };

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                this.Settings.Mp4BoxPath = ofd.FileName;
            }

            ofd = null;
        }

        private async ValueTask<Settings> LoadSettings()
        {
            if (File.Exists(SettingFilePath))
            {
                using (var fstream = File.OpenRead(SettingFilePath))
                {
                    if (fstream.Length > 0)
                    {
                        return await MessagePackSerializer.DeserializeAsync<Settings>(fstream, JsonResolver);
                    }
                }
            }

            return new Settings();
        }

        private async Task SaveSettings()
        {
            using (var fstream = File.Open(SettingFilePath, FileMode.Create))
            {
                await MessagePackSerializer.SerializeAsync(fstream, this.Settings, this.JsonResolver);
            }
        }

        #endregion Setting

        protected override void OnHandleCreated(EventArgs e)
        {
            NativeMethods.SetWindowTheme(chapterItemList.Handle, "explorer", null);

            base.OnHandleCreated(e);
        }

        protected async override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            this.Enabled = false;

            var settings = await LoadSettings();

            this.bindingSource.DataSource = this.Settings = settings;

            if (string.IsNullOrEmpty(settings.Mp4BoxPath)
                || !File.Exists(settings.Mp4BoxPath))
            {
                tabControl1.SelectedIndex = SettingTabItemIndex;

                var msgBoxRes = MessageBox.Show(this,
                    "MP4Boxのパスが設定されていないか見つかりません。適切なパスを設定してください。", "エラー",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Enabled = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.IsRunning)
            {
                e.Cancel = true;
                System.Media.SystemSounds.Exclamation.Play();
            }

            base.OnFormClosing(e);
        }

        protected override async void OnClosed(EventArgs e)
        {
            await SaveSettings();

            base.OnClosed(e);
        }
    }
}
