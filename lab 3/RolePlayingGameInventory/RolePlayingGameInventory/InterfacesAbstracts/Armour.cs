using RolePlayingGameInventory.Models;

namespace RolePlayingGameInventory.Interfaces;

public abstract class Armour : Item
{
    public string Name { get; }
    public int Level { get; set; }
    public int Defense { get; set; }
    public virtual int Speed { get; set; }
    public virtual int Weight { get; set; }
    public virtual void LevelUp()
    {
    }

    protected Armour(string name, int level, int defense)
    {
        Name = name;
        Level = level;
        Defense = defense;
    }
    public virtual void PutOn(Player player)
    {
        
    }
}