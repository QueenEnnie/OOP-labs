namespace RolePlayingGameInventory.Models.Armour;

public class ChainArmour: Interfaces.Armour
{
    private int _speed = 5;
    private int _weight = 10;

    public ChainArmour(string name, int level, int defense) : base(name, level, defense)
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
        Defense += 10;
        Level++;
    }
}