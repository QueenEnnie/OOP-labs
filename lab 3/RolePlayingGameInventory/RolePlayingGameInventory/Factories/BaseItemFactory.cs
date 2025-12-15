using RolePlayingGameInventory.Interfaces.Factories;
using RolePlayingGameInventory.Interfaces.Items;
using RolePlayingGameInventory.Models.Items.Armour;
using RolePlayingGameInventory.Models.Items.Weapon;

namespace RolePlayingGameInventory.Factories;

public class BaseItemFactory : IWeaponArmorItemFactory
{
    public IWeapon CreateWeapon(int level = 1)
    {
        return new GunWeapon("Gun", level, level * 20, "some random gun");
    }
    
    public IArmour CreateArmor(int level = 1)
    {
        return new MetalArmour("Metallic Armour", level, 20 + level * 2, "metallic armour basic for protection");
    }
}