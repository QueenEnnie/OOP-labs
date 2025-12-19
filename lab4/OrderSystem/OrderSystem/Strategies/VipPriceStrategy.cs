using OrderSystem.Interfaces;

namespace OrderSystem.Strategies;

public class VipPriceStrategy: ICostStrategy
{
    private decimal _vipCoef = 0.7m;
    private decimal _taxesCoef = 1.1m;
    
    
    public decimal DefineFinalCost(List<IDish> dishes)
    {
        decimal cost = 0;
        foreach (IDish dish in dishes)
        {
            cost += dish.GetPrice();
        }
        return cost * _taxesCoef *  _vipCoef;
    }
}