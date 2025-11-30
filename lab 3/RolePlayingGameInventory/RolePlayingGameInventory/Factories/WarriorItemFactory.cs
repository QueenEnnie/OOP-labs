using RolePlayingGameInventory.Interfaces;
using RolePlayingGameInventory.Models.Armour;
using RolePlayingGameInventory.Models.Weapon;

namespace RolePlayingGameInventory.Factories;

public class WarriorItemFactory : ItemFactory
{
    public Weapon CreateWeapon(int level = 1)
    {
        string name = "Bomb";
        int damage = 5 + level * 40;
        return new BombWeapon(name, level, damage);
    }

    public Armour CreateArmor(int level = 1)
    {
        string name = "Chain Armour";
        int defense = 30 + level * 2;
        return new ChainArmour(name, level, defense);
    }
}