using System;
using DI.Interfaces;

namespace DI.Implementations
{
    public class MiddleSon : ISon
    {
        public void Help(string message)
        {
            message += $"Method Injection {GetType()}";
            Console.WriteLine(message);
        }
    }
}