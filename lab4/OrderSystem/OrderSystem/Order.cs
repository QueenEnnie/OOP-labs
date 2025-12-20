using OrderSystem.Factories;
using OrderSystem.Interfaces;
using OrderSystem.States;

namespace OrderSystem;

public class Order
{
    public IOrderState OrderState;
    private ICostStrategy _costStrategy;
    public List<IDish> Dishes { get; }
    public int OrderNumber { get; }
    public bool IsFinished { get; set; } = false;
    private readonly List<IObserver> _observers;
    public Order(List<IDish> dishes, int orderNumber)
    {
        Dishes = dishes;
        OrderNumber = orderNumber;
        OrderState = new PreparationState();
        _observers = new List<IObserver>();
    }

    public void SetCostStrategy(ICostStrategy costStrategy)
    {
        _costStrategy = costStrategy;
    }

    public void AddDish(IDish dish)
    {
        Dishes.Add(dish);
    }

    public void RemoveDish(IDish dish)
    {
        Dishes.Remove(dish);
    }

    public void ChangeStatus()
    {
        OrderState.ChangeForNextState(this);
        Notify(OrderState.StateStatus);
    }
    
    public void Attach(IObserver observer) => _observers.Add(observer);
    public void Detach(IObserver observer) => _observers.Remove(observer);
    
    public void Notify(string message)
    {
        foreach (var observer in _observers)
        {
            observer.Update(message);
        }
    }

    public decimal GetCost()
    {
        return _costStrategy.DefineFinalCost(Dishes);
    }

}