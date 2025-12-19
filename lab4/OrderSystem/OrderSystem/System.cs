using OrderSystem.Factories;
using OrderSystem.Interfaces;

namespace OrderSystem;

public class System
{
    private Dictionary<int, Order> _orders;
    private int _idCount;
    public System()
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
        _orders[orderNumber].AddDish(dish);
    }

    public void RemoveDish(IDish dish, int orderNumber)
    {
        _orders[orderNumber].RemoveDish(dish);
    }

    public void ChangeStatus(int orderNumber)
    {
        _orders[orderNumber].ChangeStatus();
    }

    public decimal GetCost(int orderNumber)
    {
        return _orders[orderNumber].GetCost();
    }
    
}