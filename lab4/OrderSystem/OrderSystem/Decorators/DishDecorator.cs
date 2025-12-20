using OrderSystem.Interfaces;

namespace OrderSystem.Decorators;

public abstract class DishDecorator: IDish
{
    protected IDish Dish;

    protected DishDecorator(IDish dish)
    {
        Dish = dish;
    }

    public virtual string GetName()
    {
        return Dish.GetName();
    }

    public virtual string GetDescription()
    {
        return Dish.GetDescription();
    }

    public virtual decimal GetPrice()
    {
        return Dish.GetPrice();
    }
}
