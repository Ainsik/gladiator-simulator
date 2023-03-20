namespace Gladiator.Model.Gladiators;
public class Brutal : BaseGladiator
{
    protected override double MultiplierHP => StatisticMultiplier.High;
    protected override double MultiplierSp => StatisticMultiplier.High;
    protected override double MultiplierDex => StatisticMultiplier.Low;
}