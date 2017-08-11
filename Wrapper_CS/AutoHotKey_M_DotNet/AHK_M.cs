using System;
using System.Runtime.InteropServices;

namespace AutoHotKey_M
{
    public class AHK_M
    {
        #region Built-in variables

        public static string A_AppData { get { return BuiltIn.A_AppData(); } }
        public static string A_AppDataCommon { get { return BuiltIn.A_AppDataCommon(); } }
        public static string A_ComputerName { get { return BuiltIn.A_ComputerName(); } }
        public static string A_Desktop { get { return BuiltIn.A_Desktop(); } }
        public static string A_DesktopCommon { get { return BuiltIn.A_DesktopCommon(); } }
        public static bool A_Is64bitOS { get { return BuiltIn.A_Is64bitOS(); } }
        public static bool A_IsAdmin { get { return BuiltIn.A_IsAdmin(); } }
        public static string A_Language { get { return BuiltIn.A_Language(); } }
        public static string A_ProgramFIles { get { return BuiltIn.A_ProgramFiles(); } }
        public static string A_Programs { get { return BuiltIn.A_Programs(); } }
        public static string A_ProgramsCommon { get { return BuiltIn.A_ProgramsCommon(); } }
        public static int A_ScreenWidth { get { return BuiltIn.A_ScreenWidth(); } }
        public static int A_ScreenHeight { get { return BuiltIn.A_ScreenHeight(); } }
        public static string A_StartMenu { get { return BuiltIn.A_StartMenu(); } }
        public static string A_StartMenuCommon { get { return BuiltIn.A_StartMenuCommon(); } }
        public static string A_Startup{ get { return BuiltIn.A_Startup(); } }
        public static string A_StartupCommon { get { return BuiltIn.A_StartupCommon(); } }
        public static string A_UserName { get { return BuiltIn.A_UserName(); } }
        public static string A_WinDir { get { return BuiltIn.A_WinDir(); } }

        #endregion

        #region File functions
        #endregion

        #region Keyboard functions
        #endregion

        #region Mouse functions
        #endregion

        #region Window functions
        #endregion

        #region Screen Functions
        #endregion

        #region String functions
        #endregion
    }
}