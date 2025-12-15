namespace RolePlayingGameInventory.Models;

public class Player
{
    public string Name { get; }
    public int Health { get; private set; } = 500;
    public int MaxHealth { get; private set; } = 500;
    public int Speed { get; private set; } = 30;
    public int OwnWeight { get; private set; } = 10;
    
    public Inventory Inventory { get; }
    
    public Player(string name)
    {
        Name = name;
        Inventory = new Inventory();
    }

    public void LevelUp()
    {
        Inventory.LevelUp();
        MaxHealth += 10;
        Health += 10;
    }

    public void IncreaseHealth(int amount)
    {
        Health += amount;
    }
    
    public void IncreaseSpeed(int amount)
    {
        Speed += amount;
    }
    
    public void IncreaseWeight(int amount)
    {
        OwnWeight += amount;
    }


    public override string ToString()
    {
        return $"{Name} - {Health}/{MaxHealth} Health - {Speed} Speed - {OwnWeight} Weight";
    }
}