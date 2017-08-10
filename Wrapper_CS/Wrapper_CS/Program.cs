using System;
using AutoHotKey_M;

namespace Wrapper_CS
{
    class Program : AHK_M
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Screen resolution:  " + A_ScreenWidth + " x " + A_ScreenHeight);
            Console.ReadKey(true);
        }
    }
}
