using OrderSystem.Interfaces;

namespace OrderSystem;

public class StateObserver: IObserver
{
    public void Update(string message)
    {
        Console.WriteLine("The status of your order is changed:");
        Console.WriteLine(message);
    }
}