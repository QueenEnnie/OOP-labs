namespace RolePlayingGameInventory.Models.Potion;

public class HealthPotion : Interfaces.Potion
{
    public int Health { get; }

    public HealthPotion(string name, int level, int health) : base(name, level)
    {
        Health = health;
    }

    public override bool Use(Player player)
    {
        if (player.Health < player.MaxHealth)
        {
            if (player.Health + Health > player.MaxHealth)
            {
                player.Health += (player.MaxHealth - player.Health);
            }
            else
            {
                player.Health += Health;
            }
        }
        else
        {
            Console.WriteLine("No need to use potion - you are perfectly healthy");
            return false;
        }

        return true;
    }
}

