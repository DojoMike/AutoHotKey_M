using System;
using System.Runtime.InteropServices;

namespace AutoHotKey_M
{
    public class AHK_M
    {
        #region Built-in variables

        public static int A_ScreenWidth { get { return BuiltIn.A_ScreenWidth(); } }
        public static int A_ScreenHeight { get { return BuiltIn.A_ScreenHeight(); } }

        #endregion
    }
}