using Gladiator.View;

namespace Gladiator
{
    public static class Program
    {
        public static void Main()
        {
            var cv = new ConsoleView();

            cv.GetNumberBetween(10, 20);
        }
    }
}