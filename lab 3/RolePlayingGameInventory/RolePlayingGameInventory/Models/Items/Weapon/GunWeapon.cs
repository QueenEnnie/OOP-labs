namespace RolePlayingGameInventory.Models.Weapon;

public class GunWeapon : Interfaces.Weapon

{
    private int _weight = 10;

    public GunWeapon(string name, int level, int damage) : base(name, level, damage)
    {
    }
    public override int Weight
    { 
        get => _weight;
        set {} 
    }
    
}