using OrderSystem.Interfaces;

namespace OrderSystem.Dishes;

public class Pasta: IDish
{
    public string GetName()
    {
        return "Pasta";
    }

    public string GetDescription()
    {
        return "Pasta is a very useful dish.It contains not too much calories";
    }

    public decimal GetPrice()
    {
        return 650;
    }
}
