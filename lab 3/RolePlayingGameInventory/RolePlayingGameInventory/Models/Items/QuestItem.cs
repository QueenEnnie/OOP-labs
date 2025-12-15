using RolePlayingGameInventory.Interfaces.Items;

namespace RolePlayingGameInventory.Models.Items;

public class QuestItem : IItem
{
    public string Name { get; }
    public int Weight { get; } = 0;

    public string Description { get; }

    public QuestItem(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
