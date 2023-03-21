namespace Gladiator.Model.Gladiators;
public class GladiatorFactory
{
    public List<BaseGladiator> DisplayGladiators(int amount)
    {
        var gladiators = Randomizer.GenerateRandomGladiators(amount);
        return gladiators;
    }
}