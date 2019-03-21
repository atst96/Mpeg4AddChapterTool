using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mpeg4AddChapterTool
{
    internal class ChapterItem : BindableBase
    {
        public ChapterItem() : base()
        {
        }

        public ChapterItem(string videoPath) : base()
        {
            this.SetVideoFile(videoPath);
        }

        private string _videoFileName;
        public string VideoFileName
        {
            get => this._videoFileName;
            set
            {
                this._videoFileName = value;
                this.RaisePropertyChanged(nameof(this.VideoFileName));
            }
        }

        private string _chapterFileName;
        public string ChapterFileName
        {
            get => this._chapterFileName;
            set
            {
                this._chapterFileName = value;
                this.RaisePropertyChanged(nameof(this.ChapterFileName));
            }
        }

        private string _chapterFileName2;
        public string ChapterFileName2
        {
            get => this._chapterFileName2;
            set
            {
                this._chapterFileName2 = value;
                this.RaisePropertyChanged(nameof(this.ChapterFileName2));
            }
        }

        public void SetVideoFile(string path)
        {
            this.VideoFileName = path;

            var txtChapterPath = ChapterUtility.FindTxtChapter(path);
            if (txtChapterPath != null)
            {
                this.SetChapterFile(txtChapterPath);
            }

            var ttxtChapterPath = ChapterUtility.FindTtxtChapter(path);
            if (ttxtChapterPath != null)
            {
                this.SetChapterFile(ttxtChapterPath);
            }
        }

        private void SetChapterFile(string path)
        {
            if (string.IsNullOrWhiteSpace(this._chapterFileName) || this._chapterFileName == path)
            {
                this.ChapterFileName = path;
            }
            else if (string.IsNullOrWhiteSpace(this._chapterFileName2) || this._chapterFileName2 == path)
            {
                this.ChapterFileName2 = path;
            }
        }
    }
}
