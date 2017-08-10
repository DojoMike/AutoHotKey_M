using System;
using System.Runtime.InteropServices;

namespace AutoHotKey_M
{
    /// <summary>
    /// This is the main class that users' "Main" classes will inherit from.
    /// The goal is to keep the API as similar to AHK as possible, minus the
    /// inconsistent and bug-prone syntax and plus the power of .NET out of
    /// the box.  BOOM! :)
    /// </summary>
    class AutoHotKey_M
    {
        public static int A_ScreenWidth { get { return BuiltIn.A_ScreenWidth(); } }
        public static int A_ScreenHeight { get { return BuiltIn.A_ScreenHeight(); } }
    }
}
