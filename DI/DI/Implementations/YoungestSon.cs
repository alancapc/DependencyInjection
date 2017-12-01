using System;

namespace DI.Implementations
{
    public class YoungestSon : Interfaces.ISon
    {
        public void Help(string message)
        {
            message += $"Property Injection {GetType()}";
            Console.WriteLine(message);
        }
    }
}