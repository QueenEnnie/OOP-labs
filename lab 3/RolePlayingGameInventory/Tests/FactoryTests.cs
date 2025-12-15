using RolePlayingGameInventory.Factories;
using RolePlayingGameInventory.Interfaces.Items;

namespace TestProject1;

public class FactoryTests
{
    [Fact]
    public void BaseItemFactory_ShouldReturnGunWeapon()
    {
        var factory = new BaseItemFactory();
        var weapon = factory.CreateWeapon();

        Assert.IsAssignableFrom<IWeapon>(weapon);
        Assert.Equal("Gun", weapon.Name);
        Assert.Equal(1, weapon.Level);
        Assert.Equal(20, weapon.Damage);
        Assert.Equal(10, weapon.Weight); 
    }
    
    [Fact]
    public void BaseItemFactory_ShouldReturnScaledWeapon()
    {
        var factory = new BaseItemFactory();
        var weapon = factory.CreateWeapon(level: 5);
        Assert.Equal(5, weapon.Level);
        Assert.Equal(100, weapon.Damage);
    }
    
    [Fact]
    public void BaseItemFactory_ShouldReturnMetalArmour()
    {
        var factory = new BaseItemFactory();
        var armor = factory.CreateArmor();
        Assert.IsAssignableFrom<IArmour>(armor);
        Assert.Equal("Metallic Armour", armor.Name);
        Assert.Equal(1, armor.Level);
        Assert.Equal(22, armor.Defense);
    }
    
    [Fact]
    public void WarriorItemFactory_ShouldReturnBombWeapon()
    {
        var factory = new WarriorItemFactory();
        var weapon = factory.CreateWeapon();
        Assert.IsAssignableFrom<IWeapon>(weapon);
        Assert.Equal("Bomb", weapon.Name);
        Assert.Equal(45, weapon.Damage);
        Assert.Equal(50, weapon.Weight);
    }
    
    [Fact]
    public void WarriorItemFactory_ShouldReturnChainArmour()
    {
        var factory = new WarriorItemFactory();
        var armor = factory.CreateArmor(level: 3);
        Assert.Equal("Chain Armour", armor.Name);
        Assert.Equal(3, armor.Level);
        Assert.Equal(36, armor.Defense);
        Assert.Equal(10, armor.Weight);
    }
}