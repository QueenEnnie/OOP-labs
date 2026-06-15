using RolePlayingGameInventory.Interfaces.Items;
using RolePlayingGameInventory.Models.Items;

namespace RolePlayingGameInventory.Models;

public class InventoryInformation
{
    public InventoryInformation(IReadOnlyList<QuestItem> questItems, IReadOnlyList<IItem> otherItems, int currentWeight, int maxWeight)
    {
        QuestItems = questItems;
        OtherItems = otherItems;
        CurrentWeight = currentWeight;
        MaxWeight = maxWeight;
    }
    
    public IReadOnlyList<QuestItem> QuestItems { get; }
    public IReadOnlyList<IItem> OtherItems { get; }
    public int CurrentWeight { get; }
    public int MaxWeight { get; }
}
