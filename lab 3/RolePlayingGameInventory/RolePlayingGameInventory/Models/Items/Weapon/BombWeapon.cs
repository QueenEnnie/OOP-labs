using RolePlayingGameInventory.Interfaces.Items;

namespace RolePlayingGameInventory.Models.Items.Weapon;

public class BombWeapon : IWeapon

{
    public int Weight { get; private set; } = 50;
    private readonly int _minDamage = 100;
    private int _settledDamage;
    public bool IsEquipped { get; set; } = false;
    

    public BombWeapon(string name, int level, int damage, string description)
    {
        _settledDamage = damage;
        Description = description;
        Name = name;
        Level =  level;
    }

    public string Name { get; }

    public string Description { get; }
    public int Damage
    {
        get => _settledDamage;
        set
        {
            _settledDamage = value;
            if (_settledDamage < _minDamage)
            {
                _settledDamage = _minDamage;
            }
        }
    }
    public int Level { get; private set; }

    public void LevelUp()
    {
        Weight++;
        Level++;
        Damage += 10;
    }

    public void Equip(Player player)
    {
        player.IncreaseWeight(Weight);
    }

    public void Unequip(Player player)
    {
        player.IncreaseWeight(-Weight);
    }

}