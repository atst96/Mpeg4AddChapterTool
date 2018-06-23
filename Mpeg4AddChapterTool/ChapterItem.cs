using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mpeg4AddChapterTool
{
    internal class ChapterItem : BindableBase
    {
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
    }
}
