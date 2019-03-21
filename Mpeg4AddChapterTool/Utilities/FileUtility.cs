using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mpeg4AddChapterTool
{
    internal static class FileUtility
    {
        public static string[] GetDirectoryFiles(string directoryPath)
        {
            return Directory.GetFiles(directoryPath, "*.mp4", SearchOption.TopDirectoryOnly);
        }

        public static IEnumerable<string> FilterFileExtension(this IEnumerable<string> files)
        {
            return files.Where(path => path.EndsWith(".mp4", StringComparison.CurrentCultureIgnoreCase));
        }

        public static IEnumerable<string> GetSupportedDirectoryFiles(string directoryPath)
        {
            return GetDirectoryFiles(directoryPath).FilterFileExtension();
        }
    }
}
