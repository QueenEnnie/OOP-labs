using OrderSystem.Interfaces;

namespace OrderSystem.Decorators;

public class ThickDough: DishDecorator
{
    public ThickDough(IDish dish) : base(dish)
    {
    }

    public override string GetName()
    {
        return Dish.GetName() + "on thick dough";
    }
    
    public override string GetDescription()
    {
        return Dish.GetDescription() + "super tender";
    }

    public override decimal GetPrice()
    {
        return base.GetPrice() * (decimal)1.5;
    }
}