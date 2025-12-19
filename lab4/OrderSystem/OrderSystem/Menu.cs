using OrderSystem.Interfaces;

namespace OrderSystem;

public class Menu
{
    public List<IDish> Dishes;

    public Menu(List<IDish> dishes)
    {
        Dishes = dishes;
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

