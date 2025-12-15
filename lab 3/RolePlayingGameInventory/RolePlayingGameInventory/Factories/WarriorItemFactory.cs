using RolePlayingGameInventory.Interfaces.Factories;
using RolePlayingGameInventory.Interfaces.Items;
using RolePlayingGameInventory.Models.Items.Armour;
using RolePlayingGameInventory.Models.Items.Weapon;

namespace RolePlayingGameInventory.Factories;

public class WarriorItemFactory : IWeaponArmorItemFactory
{
    public IWeapon CreateWeapon(int level = 1)
    {
        return new BombWeapon("Bomb", level, 5 + level * 40, "cool bomb");
    }

    public IArmour CreateArmor(int level = 1)
    {
        return new ChainArmour("Chain Armour", level, 30 + level * 2, "cool chain armour");
    }
}