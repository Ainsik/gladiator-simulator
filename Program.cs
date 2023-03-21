namespace Gladiator;
public static class Program
{
    public static void Main()
    {
        var consoleView = new ConsoleView();
        var numberBetween = consoleView.GetNumberBetween(1, 50);

        var colosseum = new Colosseum();
        colosseum.GenerateGladiators(numberBetween.Item2);
        colosseum.SimulateCombat();
    }
}