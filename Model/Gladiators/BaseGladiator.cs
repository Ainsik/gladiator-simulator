namespace Gladiator.Model.Gladiators;
public abstract class BaseGladiator
{
    private readonly string _name = Randomizer.GetName();
    public string FullName => $"{GetType().Name} {_name}";
    public int Level = Randomizer.Get(1, 5);
    private readonly int _basicHp = Randomizer.Get(25, 100);
    private readonly int _basicSp = Randomizer.Get(25, 100);
    private readonly int _basicDex = Randomizer.Get(25, 100);
    protected abstract double MultiplierHP { get; }
    protected abstract double MultiplierSp { get; }
    protected abstract double MultiplierDex { get; }
    public double Hp => _basicHp * MultiplierHP * Level;
    public double Sp => _basicSp * MultiplierSp * Level;
    public double Dex => _basicDex * MultiplierDex * Level;
    public double CurrentHp { get; set; }

    public virtual int LevelUp()
    {
        return Level++;
    }

    public virtual bool IsDead()
    {
        return CurrentHp <= 0;
    }

    public virtual void HealUp()
    {
        CurrentHp = Hp;
    }

    public virtual void DecreaseHpBy(double damage)
    {
        CurrentHp = Hp;
        CurrentHp -= damage;
    }
}