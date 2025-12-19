using OrderSystem.Interfaces;

namespace OrderSystem.Dishes;

public class Salad: IDish
{
    public string GetName()
    {
        return "Salad";
    }

    public string GetDescription()
    {
        return "Some greens and veggies are always good.";
    }

    public decimal GetPrice()
    {
        return 400;
    }
}