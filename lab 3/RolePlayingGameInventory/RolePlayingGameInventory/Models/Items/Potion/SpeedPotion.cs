namespace RolePlayingGameInventory.Models.Potion;

public class SpeedPotion : Interfaces.Potion
{
    public int IncreasingSpeed { get; }

    public SpeedPotion(string name, int level, int speed) : base(name, level)
    {
        IncreasingSpeed = speed;
    }

    public override bool Use(Player player)
    {
        player.Speed += IncreasingSpeed;
        return true;
    }
}