using OrderSystem.Interfaces;
using OrderSystem.Strategies;

namespace OrderSystem.Factories;

public class OrdinaryOrderFactory: OrderFactory
{
    public override Order CreateOrder(List<IDish> dishes, int orderNumber)
    {
        Order order = new Order(dishes, orderNumber);
        OrdinaryStrategy strategy = new OrdinaryStrategy();
        order.SetCostStrategy(strategy);
        
        StateObserver observer = new StateObserver();
        order.Attach(observer);
        return order;
    }
}