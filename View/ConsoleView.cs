using System;

namespace Gladiator.View
{
    public class ConsoleView : IView
    {
        public string Display()
        {
            throw new NotImplementedException();
        }

        public bool GetNumberBetween(int min, int max)
        {
            Console.WriteLine($"Choose number between {min} - {max}");
            var boolValueFromParse = ParseUserInputToNumber(min, max).Item1;

            while (boolValueFromParse == false)
            {
                Console.WriteLine($"Wrong value!");
                Console.WriteLine($"Choose number again between {min} - {max}");
                boolValueFromParse = ParseUserInputToNumber(min, max).Item1;
                if (boolValueFromParse)
                {
                    Console.WriteLine("ok");
                    return true;
                }
            }

            Console.WriteLine("OK");
            return true;
        }

        private static (bool, int) ParseUserInputToNumber(int min, int max)
        {
            var success = int.TryParse(Console.ReadLine(), out var number);
            var condition = success && number >= min && number <= max;
            return (condition, number);
        }
    }
}