using Gladiator.Utils;

namespace Gladiator.Model.Gladiators;
public abstract class Gladiator
{
    private static string Name => Randomizer.GetName();
    public string FullName => $"{GetType().Name} {Name}";
    public int Level => Randomizer.GetRandomLevel();
    public int BasicHp => Randomizer.GetRandomStats();
    public int BasicSp => Randomizer.GetRandomStats();
    public int BasicDex => Randomizer.GetRandomStats();
    protected abstract int HP { get; set; }
    protected abstract int SP { get; set; }
    protected abstract int DEX { get; set; }




    public abstract int LevelUp();
    public abstract bool IsDeath();
}