using OrderSystem.Interfaces;

namespace OrderSystem.Dishes;

public class Bruschettas: IDish
{
    public string GetName()
    {
        return "Bruschettas";
    }

    public string GetDescription()
    {
        return "Before meal";
    }

    public decimal GetPrice()
    {
        return 300;
    }
}