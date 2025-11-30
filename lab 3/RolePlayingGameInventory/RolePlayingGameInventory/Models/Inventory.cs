using RolePlayingGameInventory.Interfaces;

namespace RolePlayingGameInventory.Models;

public class Inventory
{
    private List<QuestItem> _questItems;
    private List<Item>  _otherItems;
    private int _maxWeight { get; set; } = 100;
    private int _currentWeight { get; set; } = 0;

    public Inventory()
    {
        _questItems = new List<QuestItem>();
        _otherItems = new List<Item>();
    }

    public void AddItem(Item item)
    {
        if (_currentWeight + item.Weight > _maxWeight)
        {
            Console.WriteLine("You are already too heavy to add another item");
        }
        else
        {
            _otherItems.Add(item);
            _currentWeight += item.Weight;
        }
    }

    public void AddQuestItem(QuestItem questItem)
    {
        _questItems.Add(questItem);
    }

    public void RemoveItem(Item item)
    {
        if (item is QuestItem questItem)
        {
            _questItems.Remove(questItem);
        }
        else
        {
            _otherItems.Remove(item);
        }
    }

    public void LevelUp()
    {
        foreach (var item in _otherItems)
        {
            item.LevelUp();
        }
            
    }
    public void GetInformation()
    {
        Console.WriteLine("QuestItems:");
        foreach (var questItem in _questItems)
        {
            Console.WriteLine($"- {questItem.Name} - {questItem.Description}");
        }
        Console.WriteLine("Other items:");
    }
}