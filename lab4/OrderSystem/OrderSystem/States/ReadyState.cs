using OrderSystem.Interfaces;

namespace OrderSystem.States;

public class ReadyState: IOrderState
{
    public string StateStatus { get; } = "Your order is ready";

    public void ChangeForNextState(Order order)
    {
        order.IsFinished = true;
    }
}