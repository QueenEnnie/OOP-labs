using RolePlayingGameInventory.Models;
using RolePlayingGameInventory.Models.Items;
using RolePlayingGameInventory.Models.Items.Armour;
using RolePlayingGameInventory.Models.Items.Weapon;

namespace TestProject1;

public class InventoryTests
{
    [Fact]
    public void AddItem_ShouldBeOk()
    {
        var inventory = new Inventory();
        var armor = new MetalArmour("Armor", 1, 20, "something");
        inventory.VisitAdd(armor);
        var info = inventory.GetInformation();
        Assert.Contains(armor, info.OtherItems);
    }
    
    [Fact]
    public void AddQuestItem_ShouldBeWeightless()
    {
        var inventory = new Inventory();
        var questItem = new QuestItem("Maraderous Map", "Shows everything");
        inventory.VisitAdd(questItem);
        
        var info = inventory.GetInformation();
        Assert.Contains(questItem, info.QuestItems);
        Assert.Equal(0, info.CurrentWeight); 
    }
    
    [Fact]
    public void RemoveItem_ShouldRemove()
    {
        var inventory = new Inventory();
        var armor = new MetalArmour("Armor", 1, 20, "test");
        inventory.VisitAdd(armor);
        inventory.VisitRemove(armor);
        
        var info = inventory.GetInformation();
        Assert.DoesNotContain(armor, info.OtherItems);
        Assert.Equal(0, info.CurrentWeight);
    }
    
    
    [Fact]
    public void LevelUp_ShouldLevelUpEverything()
    {
        var inventory = new Inventory();
        var weapon = new GunWeapon("Gun", 1, 20, "");
        var armor = new MetalArmour("Armor", 1, 20, "");
        inventory.VisitAdd(weapon);
        inventory.VisitAdd(armor);
        inventory.LevelUp();
        
        Assert.Equal(2, weapon.Level);
        Assert.Equal(2, armor.Level);
        Assert.Equal(25, weapon.Damage); 
        Assert.Equal(25, armor.Defense); 
    }
}