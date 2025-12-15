using RolePlayingGameInventory.Interfaces.Items;
using RolePlayingGameInventory.Models.Items;

namespace RolePlayingGameInventory.Models;

public class InventoryInformation
{
    public InventoryInformation(List<QuestItem> questItems, List<IItem> otherItems, int currentWeight, int maxWeight)
    {
        QuestItems = questItems;
        OtherItems = otherItems;
        CurrentWeight = currentWeight;
        MaxWeight = maxWeight;
    }
    
    public List<QuestItem> QuestItems { get; }
    public List<IItem> OtherItems { get; }
    public int CurrentWeight { get; }
    public int MaxWeight { get; }
}