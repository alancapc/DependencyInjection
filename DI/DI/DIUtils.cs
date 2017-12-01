using System;

namespace DI
{
    public static class DiUtils
    {
        public static void WaitForKeyPress()
        {
            Console.WriteLine($"Press ESC to stop");
            do
            { } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
