namespace Gladiator.Controller;
public class Colosseum
{
    public List<BaseGladiator> Contestants { get; private set; }
    public List<BaseGladiator[]> Pairs { get; private set; }
    private readonly ConsoleView _view = new ();
    public GladiatorFactory Factory = new ();

    public void SimulateCombat()
    {
        SplitGladiatorsIntoPairs(Contestants);
        var round = new Tournament(Pairs.ToArray());
        Contestants = round.Winners.ToList();
        _view.Log = round.Log;
        _view.Display();
        if (Contestants.Count > 1)
        {
            SimulateCombat();
        }
        else
        {
            var winner = Contestants[0];
            _view.DisplayWinMessage(winner);
        }
    }

    public void GenerateGladiators(int amount)
    {
        Contestants = Factory.DisplayGladiators(amount);
    }

    private void SplitGladiatorsIntoPairs(List<BaseGladiator> gladiators)
    {
        Pairs = new List<BaseGladiator[]>();
        for (var i = 0; i < gladiators.Count; i += 2)
        {
            var gladiator = gladiators[i];
            var nextGladiator = i + 1 < gladiators.Count ? gladiators[i + 1] : null;
            var pair = new [] { gladiator, nextGladiator };
            Pairs.Add(pair);
        }
    }
}