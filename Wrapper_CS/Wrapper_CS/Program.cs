using System;
using AutoHotKey_M;

namespace Wrapper_CS
{
    class Program : AHK_M
    {
        static void Main(string[] args)
        {
            // Testing built-in variables
            Console.WriteLine("App Data:           " + A_AppData);
            Console.WriteLine("App Data Common:    " + A_AppDataCommon);
            Console.WriteLine("Computer name:      " + A_ComputerName);
            Console.WriteLine("Desktop:            " + A_Desktop);
            Console.WriteLine("Desktop Common:     " + A_DesktopCommon);
            Console.WriteLine("Is 64 bit OS?:      " + (A_Is64bitOS ? "Yes" : "No"));
            Console.WriteLine("Is Admin:           " + (A_IsAdmin ? "Yes" : "No"));
            Console.WriteLine("Language:           " + A_Language);
            Console.WriteLine("Program Files:      " + A_ProgramFIles);
            Console.WriteLine("Programs:           " + A_Programs);
            Console.WriteLine("Programs Common:    " + A_ProgramsCommon);
            Console.WriteLine("Screen resolution:  " + A_ScreenWidth + " x " + A_ScreenHeight);
            Console.WriteLine("Start Menu:         " + A_StartMenu);
            Console.WriteLine("Start Menu Common:  " + A_StartMenuCommon);
            Console.WriteLine("Startup:            " + A_Startup);
            Console.WriteLine("Startup Common:     " + A_StartupCommon);
            Console.WriteLine("Username:           " + A_UserName);
            Console.WriteLine("Windows:            " + A_WinDir);
            Console.ReadKey(true);
        }
    }
}
