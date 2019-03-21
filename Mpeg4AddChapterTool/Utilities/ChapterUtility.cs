using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mpeg4AddChapterTool
{
    internal static class ChapterUtility
    {
        public static string[] ChapterTxtSufixes =
        {
            ".txt",
            ".chap",
            ".chapter",
            ".chapter.txt",
            "_chapter.txt"
        };

        public static string[] ChapterTtxtSuffixes =
        {
            ".ttxt",
            ".apple.ttxt",
            "_apple.ttxt",
            ".chap_apple.ttxt",
            ".chapter_apple.ttxt",
            "_chapter_apple.ttxt"
        };

        public static string FindChapterFile(string videoPath, string[] chapterSuffixes)
        {
            var fileEntryName = Path.GetFileNameWithoutExtension(videoPath);

            var basePath = Path.Combine(Path.GetDirectoryName(videoPath), fileEntryName);

            return chapterSuffixes
                .Select(suffix => basePath + suffix)
                .FirstOrDefault(path => File.Exists(path));
        }

        public static string FindTxtChapter(string videoPath)
        {
            return FindChapterFile(videoPath, ChapterUtility.ChapterTxtSufixes);
        }

        public static string FindTtxtChapter(string videoPath)
        {
            return FindChapterFile(videoPath, ChapterUtility.ChapterTtxtSuffixes);
        }
    }
}
