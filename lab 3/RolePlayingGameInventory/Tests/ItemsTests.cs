using RolePlayingGameInventory.Models;
using RolePlayingGameInventory.Models.Items;
using RolePlayingGameInventory.Models.Items.Armour;
using RolePlayingGameInventory.Models.Items.Weapon;

namespace TestProject1;

public class WeaponTests
{
    [Fact]
    public void GunWeapon_LevelUp_ShouldIncreasesStats()
    {
        var gun = new GunWeapon("Test Gun", 1, 20, "my test weapon");
        var initialDamage = gun.Damage;
        var initialWeight = gun.Weight;
        var initialLevel = gun.Level;
        gun.LevelUp();
        
        Assert.Equal(initialLevel + 1, gun.Level);
        Assert.Equal(initialDamage + 5, gun.Damage);
        Assert.Equal(initialWeight + 1, gun.Weight);
    }
    
    [Fact]
    public void BombWeapon_ShouldDamageNeverGoBelowMinDamage()
    {
        var bomb = new BombWeapon("Test Bomb", 1, 50, "testing bomb");
        bomb.Damage = 80;
        
        Assert.Equal(100, bomb.Damage);
    }
    
    [Fact]
    public void BombWeapon_LevelUp_ShouldIncreasesDamage()
    {
        var bomb = new BombWeapon("Test Bomb", 1, 110, "testing bomb");
        var initialDamage = bomb.Damage;
        bomb.LevelUp();
        
        Assert.Equal(initialDamage + 10, bomb.Damage);
        Assert.Equal(2, bomb.Level);
        Assert.Equal(51, bomb.Weight);
    }
}

public class ArmorTests
{
    [Fact]
    public void MetalArmour_Equip_ShouldDecreasesPlayerSpeed()
    {
        var armor = new MetalArmour("Test Armor", 1, 22, "armor");
        var player = new Player("nemo");
        var initialSpeed = player.Speed;
        armor.Equip(player);
        
        Assert.Equal(initialSpeed - armor.Speed, player.Speed);
        Assert.Equal(10 + armor.Weight, player.OwnWeight); 
    }
    
    [Fact]
    public void MetalArmour_Unequip_ShouldRestoresPlayerSpeed()
    {
        var armor = new MetalArmour("Test Armor", 1, 22, "Test armor");
        var player = new Player("anka");
        var initialSpeed = player.Speed;
        
        armor.Equip(player);
        armor.Unequip(player);
        Assert.Equal(initialSpeed, player.Speed);
        Assert.Equal(10, player.OwnWeight);
    }
    
    [Fact]
    public void MagicArmour_Equip_ShouldIncreasesPlayerSpeed()
    {
        var armor = new MagicArmour("Magic Armor", 1, 15, "Magic armor");
        var player = new Player("Test Player");
        var initialSpeed = player.Speed;
        armor.Equip(player);
        
        Assert.Equal(initialSpeed + armor.Speed, player.Speed);
    }
    
    [Fact]
    public void ChainArmour_LevelUp_ShouldIncreasesDefense()
    {
        var armor = new ChainArmour("Chain Armor", 1, 32, "Chain armor");
        var initialDefense = armor.Defense;
        armor.LevelUp();
        
        Assert.Equal(initialDefense + 10, armor.Defense);
        Assert.Equal(2, armor.Level);
    }
}

public class QuestItemTests
{
    [Fact]
    public void QuestItem_ShouldCreateQuestItem()
    {
        var questItem = new QuestItem("Ancient Key", "Opens ancient door");
        Assert.Equal(0, questItem.Weight);
        Assert.Equal("Ancient Key", questItem.Name);
        Assert.Equal("Opens ancient door", questItem.Description);
    }
}