using System;
using DI.Interfaces;

namespace DI.Implementations
{
    public class EldestSon : ISon
    {
        public void Help(string message)
        {
            message += $"Constructor Injection {GetType()}";
            Console.WriteLine(message);
        }
    }
}