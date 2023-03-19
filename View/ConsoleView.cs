using System;

namespace Gladiator.View
{
    public class ConsoleView : IView
    {
        public void Display()
        {
            Console.WriteLine("Welcome in Gladiator Tournament simulator");
        }

        public (bool, int) GetNumberBetween(int min, int max)
        {
            Console.WriteLine($"Choose number between {min} - {max}");
            var valuesFromParse = ParseUserInputToNumber(min, max);

            while (valuesFromParse.Item1 == false)
            {
                Console.WriteLine($"{valuesFromParse.Item2} it's wrong value!");
                Console.WriteLine($"Choose number again between {min} - {max}");
                valuesFromParse = ParseUserInputToNumber(min, max);
                if (valuesFromParse.Item1)
                {
                    return (true, valuesFromParse.Item2);
                }
            }
            return (true, valuesFromParse.Item2);
        }

        private static (bool, int) ParseUserInputToNumber(int min, int max)
        {
            var success = int.TryParse(Console.ReadLine(), out var number);
            var condition = success && number >= min && number <= max;
            return (condition, number);
        }
    }
}