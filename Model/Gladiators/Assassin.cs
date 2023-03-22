namespace Gladiator.Model.Gladiators;
public class Assassin : BaseGladiator
{
    protected override double MultiplierHP => StatisticMultiplier.Low;
    protected override double MultiplierSp => StatisticMultiplier.High;
    protected override double MultiplierDex => StatisticMultiplier.High;
}