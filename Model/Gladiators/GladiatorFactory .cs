using System;
using System.Collections.Generic;

namespace Gladiator.Model.Gladiators;
public static class GladiatorFactory
{
    static Func<Gladiator>[]  listOfGladiators= new Func<Gladiator>[] {
        () => new Archer(),
        () => new Assassin(),
        () => new Brutal(),
        () => new Swordsman()
    };

    static Random random = new Random();
    public static List<Gladiator> characters = new List<Gladiator>();

    public static void generateRandomGladiator()
    {
        for (int i = 0; i < 10; i++)
        {
            Gladiator c = listOfGladiators[random.Next(listOfGladiators.Length)]();
            characters.Add(c);
        }
    }
}