namespace Gladiator.Model.Gladiators;
public class Assassin : BaseGladiator
{
    protected override double MultiplierHP => StatisticMultiplier.Low;
    protected override double MultiplierSp => StatisticMultiplier.High;
    protected override double MultiplierDex => StatisticMultiplier.High;
    public override int LevelUp()
    {
        return Level++;
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