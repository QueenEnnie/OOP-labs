using RolePlayingGameInventory.Interfaces;

namespace RolePlayingGameInventory.Models;

public class QuestItem : Item
{
    public string Id { get; }
    public string Name { get; }
    public int Level { get; }
    public int Weight { get; private set; } = 0;
    public string Description { get; }

    public QuestItem(string id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }

    public override string ToString()
    {
        return $"{Name}: {Description}";
    }
}