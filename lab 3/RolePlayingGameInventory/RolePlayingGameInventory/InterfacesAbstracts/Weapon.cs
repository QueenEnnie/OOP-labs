namespace RolePlayingGameInventory.Interfaces;

public abstract class Weapon : Item
{
    public string Name { get; }
    public int Level { get; }
    public virtual int Damage { get; set; }
    public virtual int Weight { get; set; }

    protected Weapon(string name, int level, int damage)
    {
        Name = name;
        Level = level;
        Damage = damage;
    }
}