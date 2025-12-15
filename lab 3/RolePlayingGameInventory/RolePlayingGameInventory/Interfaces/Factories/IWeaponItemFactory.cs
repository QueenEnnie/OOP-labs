using RolePlayingGameInventory.Interfaces.Items;

namespace RolePlayingGameInventory.Interfaces.Factories;

public interface IWeaponItemFactory
{
    IWeapon CreateWeapon(int level = 1);
}