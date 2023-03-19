using System;
using Gladiator.Model.Gladiators;
using Gladiator.Utils;
using Gladiator.View;

namespace Gladiator;
public static class Program
{
    public static void Main()
    {
        var consoleView = new ConsoleView();
        var numberBetween = consoleView.GetNumberBetween(10, 60);

        var factory = new GladiatorFactory();
        factory.DisplayGladiators(numberBetween.Item2);
    }
}