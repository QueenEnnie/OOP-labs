using RolePlayingGameInventory.Interfaces.Items;

namespace RolePlayingGameInventory.Models.Items.Potion;

public class HealthPotion : IPotion
{
    private int Health { get; set; }
    public string Name { get; }
    public int Weight { get; } = 0;
    public string Description { get; }
    public int Level { get; private set; }

    public HealthPotion(string name, int level, int health, string description)
    {
        Health = health;
        Name = name;
        Weight = level;
        Description = description;
    }

    public bool Use(Player player)
    {
        if (player.Health < player.MaxHealth)
        {
            if (player.Health + Health > player.MaxHealth)
            {
                player.IncreaseHealth((player.MaxHealth - player.Health));
            }
            else
            {
                player.IncreaseHealth(Health);
            }
        }
        else
        {
            return false;
        }

        return true;
    }

    public void LevelUp()
    {
        Level++;
        Health = (int)(Health + Level * 1.2);
    }
}

