using OrderSystem.Interfaces;

namespace OrderSystem.Strategies;

public class OrdinaryStrategy: ICostStrategy
{
    private decimal _deliveryCost = 300;
    private decimal _taxesCoef = 1.13m;
    
    
    public decimal DefineFinalCost(List<IDish> dishes)
    {
        decimal cost = 0;
        foreach (IDish dish in dishes)
        {
            cost += dish.GetPrice();
        }
        return cost * _taxesCoef + _deliveryCost;
    }
}