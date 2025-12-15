using RolePlayingGameInventory.Interfaces.Factories;
using RolePlayingGameInventory.Interfaces.Items;
using RolePlayingGameInventory.Models;

namespace RolePlayingGameInventory.Services;

public class PlayerArmourWeaponService
{
    private readonly IWeaponArmorItemFactory _itemFactory;
    private readonly EquipmentService _equipmentService;
    
    public PlayerArmourWeaponService(IWeaponArmorItemFactory itemFactory, EquipmentService equipmentService)
    {
        _itemFactory = itemFactory;
        _equipmentService = equipmentService;
    }
    
    public void EquipInitially(Player player)
    {
        var weapon = _itemFactory.CreateWeapon();
        var armor = _itemFactory.CreateArmor();

        player.Inventory.VisitAdd(weapon);
        player.Inventory.VisitAdd(armor);
        _equipmentService.Equip(player, weapon);
        _equipmentService.Equip(player, armor);
    }
    
    public void UsePotion(Player player, IPotion potion)
    {
        if (potion.Use(player))
        {
            player.Inventory.VisitRemove(potion);
        }
    }
}