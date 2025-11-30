using RolePlayingGameInventory.Interfaces;

namespace RolePlayingGameInventory.Models;

public class EquipmentService
{
    public void Equip(Player player, Item item)
    {
        if (item is Interfaces.Armour armour)
        {
            armour.PutOn(player);
        } else if (item is Interfaces.Weapon weapon)
        {
            weapon.Accept(player);
        }
    }
}