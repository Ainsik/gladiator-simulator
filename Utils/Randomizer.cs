using System;

namespace Gladiator.Utils;
public static class Randomizer
{
    private static readonly string _namesPath = @"C:\CC\modul4\gladiator-csharp-Ainsik\Names.txt";
    private static readonly string[] _names = GetNamesFromFile();
    private static readonly Random _random = new();
    private static readonly int _lowerBoundLevel = 1;
    private static readonly int _upperBoundLevel = 6;
    private static readonly int _lowerBoundStats = 25;
    private static readonly int _upperBoundStats = 101;

    private static string[] GetNamesFromFile()
    {
        return System.IO.File.ReadAllLines(_namesPath);
    }

    public static string GetName()
    {
        return _names[_random.Next(_names.Length)];
    }

    public static int GetRandomLevel()
    {
        return _random.Next(_lowerBoundLevel, _upperBoundLevel);
    }

    public static int GetRandomStats()
    {
        return _random.Next(_lowerBoundStats, _upperBoundStats);
    }
}