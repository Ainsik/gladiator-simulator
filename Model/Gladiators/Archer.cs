namespace Gladiator.Model.Gladiators;
public class Archer : BaseGladiator
{
    protected override double MultiplierHP => StatisticMultiplier.Low;
    protected override double MultiplierSp => StatisticMultiplier.Medium;
    protected override double MultiplierDex => StatisticMultiplier.Medium;
}
