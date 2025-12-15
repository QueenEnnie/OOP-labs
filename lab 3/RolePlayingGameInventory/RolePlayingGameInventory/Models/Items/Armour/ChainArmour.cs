using RolePlayingGameInventory.Interfaces.Items;

namespace RolePlayingGameInventory.Models.Items.Armour;

public class ChainArmour: IArmour
{
    public int Weight { get; } = 10;
    public int Speed { get; set; } = 5;
    public int Defense { get; set; }
    public string Name { get; }
    public string Description { get; }
    public int Level { get; private set; }
    public bool IsEquipped { get; set; } = false;
    
    public ChainArmour(string name, int level, int defense, string description)
    {
        Name = name;
        Level = level;
        Defense = defense;
        Description = description;
    }

    public void LevelUp()
    {
        Defense += 10;
        Level++;
    }
    
    public void Equip(Player player)
    {
        player.IncreaseSpeed(-Speed);
        player.IncreaseWeight(Weight);
    }
    
    public void Unequip(Player player)
    {
        player.IncreaseSpeed(Speed);
        player.IncreaseWeight(-Weight);
    }
}