using DI.Interfaces;

namespace DI.Implementations
{
    public class Dad
    {
        public ISon PSon { private get; set; }
        private readonly ISon _son;
            
        public Dad(ISon selectedSon)
        {
            _son = selectedSon;
        }
        public void Notify(string message)
        {
            _son?.Help(message);
            PSon?.Help(message);
        }

        public static void Notify(ISon son, string message)
        {
            son.Help(message);
        }
    }
}