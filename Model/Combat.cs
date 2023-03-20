namespace Gladiator.Model;
public class Combat
{
    public List<string> Log { get; } = new();
    private double _damage;

    public Combat(BaseGladiator attacker, BaseGladiator defender)
    {
        Attacker = attacker;
        Defender = defender;
    }

    public BaseGladiator Attacker { get; private set; }
    public BaseGladiator Defender { get; private set;}
    public BaseGladiator Simulate(BaseGladiator firstGladiator, BaseGladiator secondGladiator)
    {

        return firstGladiator;
    }

    public BaseGladiator Simulate()
    {
        if (Attacker is null) return Defender;
        if (Defender is null) return Attacker;

        Fight();

        Log.Add(GetLog(CombatStatus.End));
        return Attacker;
    }

    private void Fight()
    {
        do
        {
            if (TargetMissed())
            {
                Log.Add(GetLog(CombatStatus.Miss));
                SwapFighters();
                continue;
            }
            _damage = (Attacker.Sp * Randomizer.Get(1, 6) / 10);
            Log.Add(GetLog(CombatStatus.Hit));
            Defender.DecreaseHpBy(_damage);
            SwapFighters();
        } while (!Defender.IsDead());
    }

    private void SwapFighters()
    {
        if (!Defender.IsDead())
        {
            (Attacker, Defender) = (Defender, Attacker);
        }
    }
    private bool TargetMissed()
    {
        var hitChance = Math.Clamp(Attacker.Dex - Defender.Dex, 10, 100);
        var defenseThreshold = Randomizer.Get(10, 100);
        return hitChance < defenseThreshold;
    }

    private string GetLog(CombatStatus status)
    {
        return status switch
        {
            CombatStatus.Miss => $"{Attacker.FullName} missed",
            CombatStatus.Hit => $"{Attacker.FullName} deals {_damage} damage",
            CombatStatus.End => $"{Defender.FullName} has died, {Attacker.FullName} wins!",
            _ => throw new ArgumentOutOfRangeException("Wrong combat status in Combat"),
        };
    }
}