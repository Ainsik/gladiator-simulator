namespace Gladiator.Controller;
public class Tournament
{
    public List<BaseGladiator> Winners { get; }
    public List<string> Log { get; } = new();
    public Tournament(params BaseGladiator[][] pairs)
    {
        Winners = new List<BaseGladiator>();
        foreach (var pair in pairs)
        {
            var duel = new Combat(pair[0], pair[1]);
            var winner = duel.Simulate();
            winner.HealUp();
            winner.LevelUp();
            Winners.Add(winner);
            UpdateLog(duel);
        }
    }

    private void UpdateLog(Combat duel)
    {
        if (duel.Attacker is null || duel.Defender is null)
        {
            return;
        }
        Log.Add($"Duel {duel.Attacker.FullName} vs {duel.Defender.FullName}:");
        Log.Add($"  - {duel.Attacker.FullName} ({duel.Attacker.Hp} HP, {duel.Attacker.Sp} SP, {duel.Attacker.Dex} DEX, {duel.Attacker.Level} LVL)");
        Log.Add($"  - {duel.Defender.FullName} ({duel.Defender.Hp} HP, {duel.Defender.Sp} SP, {duel.Defender.Dex} DEX, {duel.Defender.Level} LVL)");
        var i = 0;
        foreach (var line in duel.Log)
        {
            if (i < duel.Log.Count - 1)
            {
                Log.Add("  - " + line);
            }
            else
            {
                Log.Add(line);
            }
            i++;
        }
    }
}