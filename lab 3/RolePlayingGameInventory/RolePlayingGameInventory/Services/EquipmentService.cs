using RolePlayingGameInventory.Interfaces.Items;
using RolePlayingGameInventory.Models;

namespace RolePlayingGameInventory.Services;

public class EquipmentService
{
    private readonly Inventory _inventory;

    public EquipmentService(Inventory inventory)
    {
        _inventory = inventory;
    }
    public void Equip(Player player, IEquipable item)
    {
        if (_inventory.ContainsEquipableItem(item) && !item.IsEquipped)
        {
            item.Equip(player);
            item.IsEquipped = true;
        }
    }

    public void Unequip(Player player, IEquipable item)
    {
        if (item.IsEquipped)
        {
            item.Unequip(player);
            item.IsEquipped = false;
        }
    }
}
