using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mpeg4AddChapterTool
{
    internal partial class ChapterFileSelector : Form
    {
        public ChapterItem Item { get; }

        public ChapterFileSelector()
        {
            this.InitializeComponent();

            this.Item = new ChapterItem();
            this.bindingSource.DataSource = this.Item;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            this.OnVideoFileButtonClicked(this, EventArgs.Empty);
        }

        private static string VideoFileDirectory = null;
        private static string ChapterFileDirectory = null;
        private static string ChapterFile2Directory = null;

        private void OnVideoFileButtonClicked(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "MP4ファイル|*.mp4",
                InitialDirectory = VideoFileDirectory,
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                VideoFileDirectory = Path.GetDirectoryName(ofd.FileName);
                this.SetVideoFile(ofd.FileName);
            }

            this.UpdateAcceptButton();
        }

        private void OnChapterFile1ButtonClicked(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Chapter File|*.chap;*.ttxt;*.txt",
                InitialDirectory = ChapterFileDirectory ?? ChapterFile2Directory,
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ChapterFileDirectory = Path.GetDirectoryName(ofd.FileName);
                this.SetChapterFile1(ofd.FileName);
            }

            this.UpdateAcceptButton();
        }

        private void OnChapterFile2ButtonClicked(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Chapter File|*.chap;*.ttxt;*.txt",
                InitialDirectory = ChapterFile2Directory ?? ChapterFileDirectory,
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ChapterFile2Directory = Path.GetDirectoryName(ofd.FileName);
                this.SetChapterFile2(ofd.FileName);
            }

            this.UpdateAcceptButton();
        }

        private void SetVideoFile(string path)
        {
            this.Item.VideoFileName = path;

            if (string.IsNullOrEmpty(this.Item.ChapterFileName))
            {
                var info = new FileInfo(path);

                var filename = info.Name.Substring(0, info.Name.Length - info.Extension.Length);
                var findChapterFileExtensions = new[]
                {
                    ".chap",
                    ".chapter.txt",
                    "_chapter.txt"
                };

                string findBasePath = $"{ info.DirectoryName }\\{ filename }";

                foreach(var extension in findChapterFileExtensions)
                {
                    var findPath = findBasePath + extension;
                    if (File.Exists(findPath))
                    {
                        this.SetChapterFile1(findPath);
                    }
                }

                info = null;
            }
        }

        private void SetChapterFile1(string path)
        {
            this.Item.ChapterFileName = path;

            if (string.IsNullOrEmpty(this.Item.ChapterFileName2))
            {
                var info = new FileInfo(path);

                var filename = info.Name.Substring(0, info.Name.Length - info.Extension.Length);
                var findChapterFileExtensions = new[]
                {
                    $".apple.ttxt",
                    $"_apple.ttxt"
                };

                string findBasePath = $"{ info.DirectoryName }\\{ filename }";

                foreach (var extension in findChapterFileExtensions)
                {
                    var findPath = findBasePath + extension;
                    if (File.Exists(findPath))
                    {
                        this.SetChapterFile2(findPath);
                    }
                }

                info = null;
            }
        }

        private void SetChapterFile2(string path)
        {
            this.Item.ChapterFileName2 = path;
        }

        private void UpdateAcceptButton()
        {
            this.acceptButton.Enabled
                = !string.IsNullOrEmpty(this.Item.VideoFileName)
                && !string.IsNullOrEmpty(this.Item.ChapterFileName);
        }
    }
}
