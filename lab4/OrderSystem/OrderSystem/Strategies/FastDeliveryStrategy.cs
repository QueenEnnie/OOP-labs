using OrderSystem.Interfaces;

namespace OrderSystem.Strategies;

public class FastDeliveryStrategy: ICostStrategy
{
    private decimal _fastDeliveryCost = 900;
    private decimal _fastProcessingFee = 200;
    private decimal _taxesCoef = 1.2m;
    
    
    public decimal DefineFinalCost(List<IDish> dishes)
    {
        decimal cost = 0;
        foreach (IDish dish in dishes)
        {
            cost += dish.GetPrice();
        }
        return cost * _taxesCoef + _fastDeliveryCost + _fastProcessingFee;
    }
}