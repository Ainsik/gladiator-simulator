namespace Gladiator.Utils;
public static class Randomizer
{
    private const string NamesPath = @"C:\CC\modul4\gladiator-csharp-Ainsik\Names.txt";
    private static readonly string[] Names = GetNamesFromFile();
    private static readonly Random Random = new ();
    private const int LowerBoundLevel = 1;
    private const int UpperBoundLevel = 6;
    private const int LowerBoundStats = 25;
    private const int UpperBoundStats = 101;
    public static List<BaseGladiator> Characters = new();
    private static readonly Func<BaseGladiator>[] ListOfGladiators = {
        () => new Archer(),
        //() => new Assassin(),
        //() => new Brutal(),
        //() => new Swordsman()
    };

    private static string[] GetNamesFromFile()
    {
        return System.IO.File.ReadAllLines(NamesPath);
    }

    public static string GetName()
    {
        return Names[Random.Next(Names.Length)];
    }

    public static int GetRandomLevel()
    {
        return Random.Next(LowerBoundLevel, UpperBoundLevel);
    }

    public static int GetRandomStats()
    {
        return Random.Next(LowerBoundStats, UpperBoundStats);
    }

    public static List<BaseGladiator> GenerateRandomGladiators(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            BaseGladiator randomGladiator = ListOfGladiators[Random.Next(ListOfGladiators.Length)]();
            Characters.Add(randomGladiator);
        }

        return Characters;
    }
}