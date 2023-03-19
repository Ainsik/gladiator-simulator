using Gladiator.Utils.Enums;

namespace Gladiator.Model.Gladiators;
public class Assassin : BaseGladiator
{
    protected override double MultiplierHP => StatisticMultiplier.Low;
    protected override double MultiplierSp => StatisticMultiplier.High;
    protected override double MultiplierDex => StatisticMultiplier.High;
    public override int LevelUp()
    {
        throw new System.NotImplementedException();
    }

    public override bool IsDeath()
    {
        throw new System.NotImplementedException();
    }
}