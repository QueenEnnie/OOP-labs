using OrderSystem.Interfaces;

namespace OrderSystem.States;

public class DeliveryState: IOrderState
{
    public string StateStatus { get; } = "Your is being delivered. Please wait, we'll be here soon";

    public void ChangeForNextState(Order order)
    {
        order.SetState(new ReadyState());
    }
}
