using OrderSystem.Interfaces;

namespace OrderSystem.Strategies;

public class FastDeliveryStrategy: ICostStrategy
{
    private const decimal FastDeliveryCost = 900;
    private const decimal FastProcessingFee = 200;
    private const decimal TaxesCoef = 1.2m;
    
    
    public decimal DefineFinalCost(IEnumerable<IDish> dishes)
    {
        decimal cost = 0;
        foreach (IDish dish in dishes)
        {
            cost += dish.GetPrice();
        }
        return cost * TaxesCoef + FastDeliveryCost + FastProcessingFee;
    }
}
