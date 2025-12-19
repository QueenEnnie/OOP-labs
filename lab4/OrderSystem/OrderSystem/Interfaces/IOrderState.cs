namespace OrderSystem.Interfaces;

public interface IOrderState
{
    string StateStatus { get; }
    void ChangeForNextState(Order order);
}