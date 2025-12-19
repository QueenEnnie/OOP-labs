using OrderSystem.Interfaces;

namespace OrderSystem.Factories;

public abstract class OrderFactory
{
    public abstract Order CreateOrder(List<IDish> dishes, int orderNumber);
}