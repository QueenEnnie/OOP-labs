using OrderSystem.Interfaces;

namespace OrderSystem.States;

public class PreparationState: IOrderState
{
    public string StateStatus { get; } = "Your order in a process. We are preparing what you need";

    public void ChangeForNextState(Order order)
    {
        order.SetState(new DeliveryState());
    }
}
