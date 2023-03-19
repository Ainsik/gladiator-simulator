namespace Gladiator.Model.Gladiators;
public abstract class BaseGladiator
{
    private static string Name => Randomizer.GetName();
    public string FullName => $"{GetType().Name} {Name}";
    private int Level => Randomizer.GetRandomLevel();
    private int BasicHp => Randomizer.GetRandomStats();
    private int BasicSp => Randomizer.GetRandomStats();
    private int BasicDex => Randomizer.GetRandomStats();
    protected abstract double MultiplierHP { get; }
    protected abstract double MultiplierSp { get; }
    protected abstract double MultiplierDex { get; }
    public double Hp => BasicHp * MultiplierHP * Level;
    public double Sp => BasicSp * MultiplierSp * Level;
    public double Dex => BasicDex * MultiplierDex * Level;
    public abstract int LevelUp();
    public abstract bool IsDeath();
}