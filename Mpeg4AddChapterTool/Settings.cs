using MessagePack;
using System.Runtime.Serialization;

namespace Mpeg4AddChapterTool
{
    [MessagePackObject]
    internal class Settings : BindableBase
    {
        [IgnoreDataMember]
        private string _mp4BoxPath;
        [Key(0)]
        public string Mp4BoxPath
        {
            get => this._mp4BoxPath;
            set
            {
                this._mp4BoxPath = value;
                this.RaisePropertyChanged();
            }
        }

        [IgnoreDataMember]
        private bool _removeSucceedItems = true;
        [Key(1)]
        public bool RemoveSucceedItems
        {
            get => this._removeSucceedItems;
            set
            {
                this._removeSucceedItems = value;
                this.RaisePropertyChanged();
            }
        }
    }
}
