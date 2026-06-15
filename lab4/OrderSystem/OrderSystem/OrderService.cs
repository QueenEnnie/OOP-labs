using OrderSystem.Factories;
using OrderSystem.Interfaces;

namespace OrderSystem;

public class OrderService
{
    private readonly Dictionary<int, Order> _orders;
    private int _idCount;
    public OrderService()
    {
        _orders = new Dictionary<int, Order>();
        _idCount = 1;
    }

    public int CreateOrder(List<IDish> dishes, OrderFactory factory)
    {
        Order order = factory.CreateOrder(dishes,  _idCount);
        _orders.Add(_idCount, order);
        _idCount += 1;
        return order.OrderNumber;
    }

    public void AddDish(IDish dish, int orderNumber)
    {
        GetOrder(orderNumber).AddDish(dish);
    }

    public void RemoveDish(IDish dish, int orderNumber)
    {
        GetOrder(orderNumber).RemoveDish(dish);
    }

    public void ChangeStatus(int orderNumber)
    {
        GetOrder(orderNumber).ChangeStatus();
    }

    public decimal GetCost(int orderNumber)
    {
        return GetOrder(orderNumber).GetCost();
    }

    private Order GetOrder(int orderNumber)
    {
        if (!_orders.TryGetValue(orderNumber, out var order))
        {
            throw new KeyNotFoundException($"Order with number {orderNumber} does not exist.");
        }

        return order;
    }
    
}
