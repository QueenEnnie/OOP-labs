using OrderSystem.Interfaces;

namespace OrderSystem.Strategies;

public class OrdinaryStrategy: ICostStrategy
{
    private const decimal DeliveryCost = 300;
    private const decimal TaxesCoef = 1.13m;
    
    
    public decimal DefineFinalCost(IEnumerable<IDish> dishes)
    {
        decimal cost = 0;
        foreach (IDish dish in dishes)
        {
            cost += dish.GetPrice();
        }
        return cost * TaxesCoef + DeliveryCost;
    }
}
