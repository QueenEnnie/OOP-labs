using RolePlayingGameInventory.Interfaces;
using RolePlayingGameInventory.Models.Armour;
using RolePlayingGameInventory.Models.Weapon;

namespace RolePlayingGameInventory.Factories;

public class BaseItemFactory : ItemFactory
{
    public Weapon CreateWeapon(int level = 1)
    {
        string name = "Gun";
        int damage = level * 20;
        return new GunWeapon(name, level, damage);
    }
    

    public Armour CreateArmor(int level = 1)
    {
        string name = "Metallic Armour";
        int defense = 20 + level * 2;
        return new MetalArmour(name, level, defense);
    }
}