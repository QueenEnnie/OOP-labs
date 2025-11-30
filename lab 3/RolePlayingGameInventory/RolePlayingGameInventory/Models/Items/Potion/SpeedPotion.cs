namespace RolePlayingGameInventory.Models.Potion;

public class SpeedPotion : Interfaces.Potion
{
    public int IncreasingSpeed { get; set; }

    public SpeedPotion(string name, int level, int speed) : base(name, level)
    {
        IncreasingSpeed = speed;
    }

    public override bool Use(Player player)
    {
        player.Speed += IncreasingSpeed;
        return true;
    }
    public override void LevelUp()
    {
        Level++;
        IncreasingSpeed = (int)(IncreasingSpeed + Level * 1.3);
    }
}