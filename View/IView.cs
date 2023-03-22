namespace Gladiator.View;
public interface IView
{
    void Display();
    void DisplayWinMessage(BaseGladiator winner);
    (bool, int) GetNumberBetween(int min, int max);
}