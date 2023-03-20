namespace Gladiator.Model.Gladiators;
public class Swordsman : BaseGladiator
{
    protected override double MultiplierHP => StatisticMultiplier.Medium;
    protected override double MultiplierSp => StatisticMultiplier.Medium;
    protected override double MultiplierDex => StatisticMultiplier.Medium;
}
