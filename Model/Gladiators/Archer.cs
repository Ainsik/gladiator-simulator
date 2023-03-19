namespace Gladiator.Model.Gladiators;
public class Archer : BaseGladiator
{
    protected override double MultiplierHP => StatisticMultiplier.Low;
    protected override double MultiplierSp => StatisticMultiplier.Medium;
    protected override double MultiplierDex => StatisticMultiplier.Medium;
    public override int LevelUp()
    {   
        return Level + 10;
    }

    public override bool IsDeath()
    {
        if (Hp <= 0)
        {
            Console.WriteLine($"{FullName} die.");
            return true;
        }
        return false;
    }
}
