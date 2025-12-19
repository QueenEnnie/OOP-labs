using OrderSystem.Interfaces;

namespace OrderSystem.Decorators;

public class ExtraSpicy: DishDecorator
{
    public ExtraSpicy(IDish dish) : base(dish)
    {
    }

    public override string GetName()
    {
        return base.GetName() + "spicy";
    }

    public override string GetDescription()
    {
        return Dish.GetDescription() + "This version is super spicy. Be careful";
    }
    
}