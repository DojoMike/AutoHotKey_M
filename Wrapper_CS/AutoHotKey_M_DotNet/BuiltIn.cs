using System.Runtime.InteropServices;

namespace AutoHotKey_M
{
    /// <summary>
    /// Built-in (A_*) variables
    /// </summary>
    public class BuiltIn
    {
        [DllImport(@"AutoHotKey_M.dll", CharSet = CharSet.Auto)]
        public static extern string A_AppData();

        [DllImport(@"AutoHotKey_M.dll", CharSet = CharSet.Auto)]
        public static extern string A_AppDataCommon();

        [DllImport(@"AutoHotKey_M.dll", CharSet = CharSet.Auto)]
        public static extern string A_ComputerName();

        [DllImport(@"AutoHotKey_M.dll", CharSet = CharSet.Auto)]
        public static extern string A_Desktop();

        [DllImport(@"AutoHotKey_M.dll", CharSet = CharSet.Auto)]
        public static extern string A_DesktopCommon();

        [DllImport(@"AutoHotKey_M.dll")]
        public static extern bool A_Is64bitOS();

        [DllImport(@"AutoHotKey_M.dll")]
        public static extern bool A_IsAdmin();

        [DllImport(@"AutoHotKey_M.dll", CharSet = CharSet.Auto)]
        public static extern string A_Language();

        [DllImport(@"AutoHotKey_M.dll", CharSet = CharSet.Auto)]
        public static extern string A_MyDocuments();

        [DllImport(@"AutoHotKey_M.dll", CharSet = CharSet.Auto)]
        public static extern string A_ProgramFiles();

        [DllImport(@"AutoHotKey_M.dll", CharSet = CharSet.Auto)]
        public static extern string A_Programs();

        [DllImport(@"AutoHotKey_M.dll", CharSet = CharSet.Auto)]
        public static extern string A_ProgramsCommon();

        [DllImport(@"AutoHotKey_M.dll")]
        public static extern int A_ScreenWidth();

        [DllImport(@"AutoHotKey_M.dll")]
        public static extern int A_ScreenHeight();

        [DllImport(@"AutoHotKey_M.dll", CharSet = CharSet.Auto)]
        public static extern string A_StartMenu();

        [DllImport(@"AutoHotKey_M.dll", CharSet = CharSet.Auto)]
        public static extern string A_StartMenuCommon();

        [DllImport(@"AutoHotKey_M.dll", CharSet = CharSet.Auto)]
        public static extern string A_Startup();

        [DllImport(@"AutoHotKey_M.dll", CharSet = CharSet.Auto)]
        public static extern string A_StartupCommon();

        [DllImport(@"AutoHotKey_M.dll", CharSet = CharSet.Auto)]
        public static extern string A_UserName();

        [DllImport(@"AutoHotKey_M.dll", CharSet = CharSet.Auto)]
        public static extern string A_WinDir();
    }
}
