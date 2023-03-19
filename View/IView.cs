namespace Gladiator.View;
public interface IView
{
    void Display();
    (bool, int) GetNumberBetween(int min, int max);
}