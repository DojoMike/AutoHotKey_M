using System;
using System.Runtime.InteropServices;

namespace AutoHotKey_M
{
    /// <summary>
    /// This class
    /// </summary>
    internal class Screen
    {
        [DllImport(@"AutoHotKey_M.dll")]
        public static extern int A_ScreenWidth();

        [DllImport(@"AutoHotKey_M.dll")]
        public static extern int A_ScreenHeight();
    }
}
