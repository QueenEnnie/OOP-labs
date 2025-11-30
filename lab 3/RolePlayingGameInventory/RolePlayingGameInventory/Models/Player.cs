using RolePlayingGameInventory.Interfaces;

namespace RolePlayingGameInventory.Models;

public class Player
{
    public string Name { get; }
    public int Health { get; set; } = 500;
    public int MaxHealth { get; private set; } = 500;
    public int Speed { get; set; } = 30;
    public Inventory Inventory { get; }
    private ItemFactory _itemFactory;

    public Player(string name, ItemFactory itemFactory)
    {
        Name = name;
        _itemFactory = itemFactory;
        Inventory = new Inventory();
    }
    
    public void EquipInitially()
    {
        var weapon = _itemFactory.CreateWeapon();
        var armor = _itemFactory.CreateArmor();

        Inventory.AddItem(weapon);
        Inventory.AddItem(armor);
    }

    public void UsePotion(Interfaces.Potion potion)
    {
        if (potion.Use(this))
        {
            Inventory.RemoveItem(potion);
        }
    }

    public void GetInventoryInfo()
    {
        Inventory.GetInformation();
    }
}