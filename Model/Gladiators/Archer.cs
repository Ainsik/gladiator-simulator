using Gladiator.Utils.Enums;

namespace Gladiator.Model.Gladiators;
public class Archer : Gladiator
{
    protected override double MultiplierHP => StatisticMultiplier.Low;
    protected override double MultiplierSp => StatisticMultiplier.Medium;
    protected override double MultiplierDex => StatisticMultiplier.Medium;
    public override int LevelUp()
    {
        throw new System.NotImplementedException();
    }

    public override bool IsDeath()
    {
        throw new System.NotImplementedException();
    }
}
