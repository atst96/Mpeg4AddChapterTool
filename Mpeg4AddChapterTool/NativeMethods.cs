using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mpeg4AddChapterTool
{
    internal static class NativeMethods
    {
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SetWindowTheme(
            [In] IntPtr hwnd,
            [In] string pszSubAppName,
            [In] string pszSubIdList
        );
    }
}
