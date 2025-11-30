namespace RolePlayingGameInventory.Models.Armour;

public class MagicArmour: Interfaces.Armour
{
    private int _speed = 5;
    private int _weight = 20;

    public MagicArmour(string id, string name, int level, int defense) : base(name, level, defense)
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
}