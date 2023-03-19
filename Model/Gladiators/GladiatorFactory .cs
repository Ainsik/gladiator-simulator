namespace Gladiator.Model.Gladiators;
public class GladiatorFactory
{
    public void DisplayGladiators(int amount)
    {
        var gladiators = Randomizer.GenerateRandomGladiators(amount);
        foreach (var gladiator in gladiators)
        {
            Console.WriteLine($"Name: {gladiator.FullName}\t Level: {gladiator.Level}\n" +
                              $"HP: {gladiator.Hp} \tSP: {gladiator.Sp} \tDEX: {gladiator.Dex}");
            if (gladiator.FullName.Contains("Archer"))
            {
                gladiator.LevelUp();
                Console.WriteLine($"Name: {gladiator.FullName}\t Level: {gladiator.Level}\n" +
                                  $"HP: {gladiator.Hp} \tSP: {gladiator.Sp} \tDEX: {gladiator.Dex}\n");
                Console.WriteLine();
            }
        }
    }
}