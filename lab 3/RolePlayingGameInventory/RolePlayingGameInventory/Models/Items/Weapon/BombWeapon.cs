namespace RolePlayingGameInventory.Models.Weapon;

public class BombWeapon : Interfaces.Weapon

{
    private int _weight = 50;
    private int _minDamage = 100;
    private int _settledDamage;

    public BombWeapon(string name, int level, int damage) : base(name, level, damage)
    {
        _settledDamage = damage;
    }
    public override int Weight
    { 
        get => _weight;
        set {} 
    }
    
    public override int Damage 
    { 
        get => Math.Max(_settledDamage, _minDamage);
        set 
        { 
            _settledDamage = value;
            if (_settledDamage < _minDamage)
            {
                _settledDamage = _minDamage;
            }
        } 
    }

    public override void LevelUp()
    {
        _weight++;
        Level++;
        Damage += 10;
    }
}