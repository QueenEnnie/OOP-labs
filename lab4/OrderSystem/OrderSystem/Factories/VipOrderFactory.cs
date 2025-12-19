using OrderSystem.Interfaces;
using OrderSystem.Strategies;

namespace OrderSystem.Factories;

public class VipOrderFactory: OrderFactory
{
    public override Order CreateOrder(List<IDish> dishes, int orderNumber)
    {
        Order order = new Order(dishes, orderNumber);
        VipPriceStrategy strategy = new VipPriceStrategy();
        order.SetCostStrategy(strategy);
        
        StateObserver observer = new StateObserver();
        order.Attach(observer);
        return order;
    }
}