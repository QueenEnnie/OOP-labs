using RolePlayingGameInventory.Interfaces.Items;

namespace RolePlayingGameInventory.Models.Items.Armour;

public class MagicArmour: IArmour
{
    public int Weight { get; } = 20;
    public int Speed { get; set; } = 15;
    public int Defense { get; set; }
    public string Name { get; }
    public string Description { get; }
    public int Level { get; private set; }
    public bool IsEquipped { get; set; } = false;
    

    public MagicArmour(string name, int level, int defense, string description)
    {
        Name = name;
        Level = level;
        Defense = defense;
        Description = description;
    }

    public void LevelUp()
    {
        Defense += 50;
        Level++;
    }
    public void Equip(Player player)
    {
        player.IncreaseSpeed(Speed);
        player.IncreaseWeight(Weight);
    }
    
    public void Unequip(Player player)
    {
        player.IncreaseSpeed(-Speed);
        player.IncreaseWeight(-Weight);
    }
}