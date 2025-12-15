using RolePlayingGameInventory.Models;

namespace RolePlayingGameInventory.Interfaces.Items;

public interface IEquipable: IItem
{
    bool IsEquipped { get; set; }
    void Equip(Player player);
    void Unequip(Player player);
}