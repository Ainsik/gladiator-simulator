namespace Gladiator.Model.Gladiators;
public class Brutal : BaseGladiator
{
    protected override double MultiplierHP => StatisticMultiplier.High;
    protected override double MultiplierSp => StatisticMultiplier.High;
    protected override double MultiplierDex => StatisticMultiplier.Low;
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

    public override void HealUp()
    {
        throw new NotImplementedException();
    }

    public override void DecreaseHpBy()
    {
        throw new NotImplementedException();
    }
}