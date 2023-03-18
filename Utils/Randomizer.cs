using System;

namespace Gladiator.Utils;
public static class Randomizer
{
    private static readonly string _namesPath = @"C:\CC\modul4\gladiator-csharp-Ainsik\Names.txt";
    private static readonly string[] _names = GetNames();
    private static readonly Random _random = new();
    private static int _lowerBound = 1;
    private static int _upperBound = 6;

    private static string[] GetNames()
    {
        return System.IO.File.ReadAllLines(_namesPath);
    }

    public static int GetNameId()
    {
        return _random.Next(_names.Length);
    }

    public static string GetName()
    {
        return _names[GetNameId()];
    }

    public static int GetRandomLevel()
    {
        return _random.Next(_lowerBound, _upperBound);
    }
}