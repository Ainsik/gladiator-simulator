namespace Gladiator.Model.Gladiators;
public abstract class BaseGladiator
{
    private readonly string _name = Randomizer.GetName();
    public string FullName => $"{GetType().Name} {_name}";
    public int Level = Randomizer.GetRandomLevel();
    private readonly int _basicHp = Randomizer.GetRandomStats();
    private readonly int _basicSp = Randomizer.GetRandomStats();
    private readonly int _basicDex = Randomizer.GetRandomStats();
    protected abstract double MultiplierHP { get; }
    protected abstract double MultiplierSp { get; }
    protected abstract double MultiplierDex { get; }
    public double Hp => _basicHp * MultiplierHP * Level;
    public double Sp => _basicSp * MultiplierSp * Level;
    public double Dex => _basicDex * MultiplierDex * Level;
    public abstract int LevelUp();
    public abstract bool IsDeath();
}