using RolePlayingGameInventory.Models;

namespace RolePlayingGameInventory.Interfaces;

public abstract class Potion : Item
{
    public string Name { get; }
    public int Level { get; }
    public int Weight { get; protected set; } = 0;
    protected Potion(string name, int level)
    {
        Name = name;
        Level = level;
    }

    public virtual bool Use(Player player)
    {
        return true;
    }
}