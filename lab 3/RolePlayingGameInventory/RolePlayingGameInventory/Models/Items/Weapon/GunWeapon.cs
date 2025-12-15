using RolePlayingGameInventory.Interfaces.Items;

namespace RolePlayingGameInventory.Models.Items.Weapon;

public class GunWeapon : IWeapon

{
    public int Weight { get; private set; } = 10;
    public string Name { get; }
    public int Damage { get; set; }
    public string Description { get; }
    public int Level { get; private set; }
    public bool IsEquipped { get; set; } = false;

    public GunWeapon(string name, int level, int damage, string description) 
    {
        Name = name;
        Level = level;
        Damage = damage;
        Description = description;
    }
    public void LevelUp()
    {
        Weight++;
        Level++;
        Damage += 5;
    }

    public void Equip(Player player)
    {
        player.IncreaseWeight(Weight);
    }

    public void Unequip(Player player)
    {
        player.IncreaseWeight(-Weight);
    }
    
}