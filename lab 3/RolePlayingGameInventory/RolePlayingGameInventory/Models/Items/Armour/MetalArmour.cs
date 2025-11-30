namespace RolePlayingGameInventory.Models.Armour;

public class MetalArmour: Interfaces.Armour
{
    private int _speed = 10;
    private int _weight = 20;

    public MetalArmour(string name, int level, int defense) : base(name, level, defense)
    {
    }

    public override int Speed 
    { 
        get => _speed;
        set {} 
    }
    public override int Weight
    { 
        get => _weight;
        set {} 
    }
    public override void LevelUp()
    {
        Defense += 5;
        Level++;
    }
}