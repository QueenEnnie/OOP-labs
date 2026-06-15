using OrderSystem.Interfaces;

namespace OrderSystem;

public class Menu
{
    public IReadOnlyList<IDish> Dishes { get; }

    public Menu(IEnumerable<IDish> dishes)
    {
        Dishes = dishes.ToList();
    }

    public void Display()
    {
        Console.WriteLine("Our order menu");
        foreach (var item in Dishes)
        {
            Console.WriteLine($"{item.GetName()} - {item.GetDescription()} - costs {item.GetPrice()} rub.");
        }
    }
}

