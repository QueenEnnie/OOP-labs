namespace RolePlayingGameInventory.Models;

public class InformationDisplay
{
    private InventoryInformation _inventoryInformation;
    private double _fullness;

    public InformationDisplay(InventoryInformation inventoryInformation)
    {
        _inventoryInformation = inventoryInformation;
        _fullness = (double)inventoryInformation.CurrentWeight /  inventoryInformation.MaxWeight * 100;
    }

    public void DisplayEverything()
    {
        Console.WriteLine("Inventory Information:");
        Console.WriteLine("Current weight : " + _inventoryInformation.CurrentWeight);
        Console.WriteLine("Max weight: " + _inventoryInformation.MaxWeight);
        Console.WriteLine($"The fullness of the inventory: {_fullness} %" + "\n");
        DisplayQuestItems();
        DisplayOtherItems();
    }

    private void DisplayQuestItems()
    {
        var count = 1;
        Console.WriteLine("QuestItems:");
        foreach (var questItem in _inventoryInformation.QuestItems)
        {
            Console.WriteLine($"{count}. {questItem.Name}: {questItem.Description}");
            count++;
        }
    }
    
    private void DisplayOtherItems()
    {
        Console.WriteLine("Items:");
        foreach (var item in _inventoryInformation.OtherItems)
        {
            Console.WriteLine($"- {item.Name}: {item.Description}");
        }
    }
}