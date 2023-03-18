using Gladiator.Utils;

namespace Gladiator.Model.Gladiators;
public abstract class Gladiator
{
    protected abstract string Type { get; }
    private static string Name => Randomizer.GetName();
    public string FullName => $"{Type} {Name}";
    public int Level => Randomizer.GetRandomLevel();
    protected abstract int HP { get; set; }
    protected abstract int SP { get; set; }
    protected abstract int DEX { get; set; }
    public int maximumStatistic { get; set; }



    public abstract int LevelUp();
    public abstract bool IsDeath();
}