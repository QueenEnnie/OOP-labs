using OrderSystem.Interfaces;

namespace OrderSystem.Strategies;

public class VipPriceStrategy: ICostStrategy
{
    private const decimal VipCoef = 0.7m;
    private const decimal TaxesCoef = 1.1m;
    
    
    public decimal DefineFinalCost(IEnumerable<IDish> dishes)
    {
        decimal cost = 0;
        foreach (IDish dish in dishes)
        {
            cost += dish.GetPrice();
        }
        return cost * TaxesCoef * VipCoef;
    }
}
