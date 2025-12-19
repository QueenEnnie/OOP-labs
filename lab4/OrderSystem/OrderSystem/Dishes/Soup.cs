using OrderSystem.Interfaces;

namespace OrderSystem.Dishes;

public class Soup: IDish
{
    public string GetName()
    {
        return "Soup";
    }

    public string GetDescription()
    {
        return "Nutritious meal. A usual part of our culture.";
    }

    public decimal GetPrice()
    {
        return 850;
    }
}