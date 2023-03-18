namespace Gladiator.Model.Gladiators;
public class Assassin : Gladiator
{
    protected override int HP { get; set; }
    protected override int SP { get; set; }
    protected override int DEX { get; set; }
    public override int LevelUp()
    {
        throw new System.NotImplementedException();
    }

    public override bool IsDeath()
    {
        throw new System.NotImplementedException();
    }
}