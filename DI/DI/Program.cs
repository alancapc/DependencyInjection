using DI.Implementations;

namespace DI
{
    public static class Program
    {
        private static void Main()
        {
            var eSon = new EldestSon();
            var mSon = new MiddleSon();
            var ySon = new YoungestSon();
            var dad = new Dad(eSon) { PSon = ySon };

            const string message = "Help: ";

            dad.Notify(message);
            Dad.Notify(mSon, message);

            DiUtils.WaitForKeyPress();
        }
    }
}