using System;
using System.Runtime.InteropServices;

namespace AutoHotKey_M
{
    /// <summary>
    /// Built-in (A_*) variables
    /// </summary>
    public class BuiltIn
    {
        [DllImport(@"AutoHotKey_M.dll")]
        public static extern int A_ScreenWidth();

        [DllImport(@"AutoHotKey_M.dll")]
        public static extern int A_ScreenHeight();
    }
}
