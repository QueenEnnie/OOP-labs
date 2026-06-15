using OrderSystem.Interfaces;
using OrderSystem.States;
using OrderSystem.Strategies;

namespace OrderSystem;

public class Order
{
    private readonly List<IDish> _dishes;
    private ICostStrategy _costStrategy;
    private readonly List<IObserver> _observers;

    public Order(IEnumerable<IDish> dishes, int orderNumber, ICostStrategy? costStrategy = null)
    {
        _dishes = dishes.ToList();
        OrderNumber = orderNumber;
        OrderState = new PreparationState();
        _costStrategy = costStrategy ?? new OrdinaryStrategy();
        _observers = new List<IObserver>();
    }

    public IOrderState OrderState { get; private set; }
    public IReadOnlyList<IDish> Dishes => _dishes;
    public int OrderNumber { get; }
    public bool IsFinished { get; set; }

    public void SetCostStrategy(ICostStrategy costStrategy)
    {
        _costStrategy = costStrategy;
    }

    public void AddDish(IDish dish)
    {
        _dishes.Add(dish);
    }

    public void RemoveDish(IDish dish)
    {
        _dishes.Remove(dish);
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
        return _costStrategy.DefineFinalCost(_dishes);
    }

    internal void SetState(IOrderState orderState)
    {
        OrderState = orderState;
    }
}
