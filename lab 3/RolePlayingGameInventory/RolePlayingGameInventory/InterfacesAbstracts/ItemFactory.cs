using RolePlayingGameInventory.Models;

namespace RolePlayingGameInventory.Interfaces;

public interface ItemFactory
{
    Weapon CreateWeapon(int level = 1);
    Armour CreateArmor(int level = 1);
}