namespace Gladiator.Model.Gladiators;
public class GladiatorFactory
{
    public void DisplayGladiators(int amount)
    {
        var gladiators = Randomizer.GenerateRandomGladiators(amount);
        foreach (var gladiator in gladiators)
        {
            Console.WriteLine(gladiator.FullName);
        }
    }
}