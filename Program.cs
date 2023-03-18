using System;
using Gladiator.Model.Gladiators;
using Gladiator.Utils;
using Gladiator.View;

namespace Gladiator
{
    public static class Program
    {
        public static void Main()
        {
            //var cv = new ConsoleView();

            //cv.GetNumberBetween(10, 20);


            //var archer = new Archer();
            //var archer2 = new Archer();
            //var archer3 = new Archer();
            //var asa = new Assassin();
            //var asa2 = new Assassin();
            //var asa3= new Assassin();


            //Console.WriteLine($"{archer.FullName}, {archer.Level}, {archer.BasicHp}, {archer.BasicSp}, {archer.BasicDex}");
            //Console.WriteLine($"{archer2.FullName}, {archer2.Level}");
            //Console.WriteLine($"{archer3.FullName}, {archer3.Level}");
            //Console.WriteLine($"{asa.FullName}, {asa.Level}");
            //Console.WriteLine($"{asa2.FullName}, {asa2.Level}");
            //Console.WriteLine($"{asa3.FullName}, {asa3.Level}");
            Console.WriteLine();

            GladiatorFactory.generateRandomGladiator();

            foreach (var VARIABLE in GladiatorFactory.characters)
            {
                Console.WriteLine(VARIABLE.FullName);
            }
        }
    }
}