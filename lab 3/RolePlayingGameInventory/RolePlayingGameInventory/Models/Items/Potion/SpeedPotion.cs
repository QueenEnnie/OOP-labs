using RolePlayingGameInventory.Interfaces.Items;

namespace RolePlayingGameInventory.Models.Items.Potion
{
    public class SpeedPotion : IPotion
    {
        private int IncreasingSpeed { get; set; }
        public string Name { get; }
        public int Weight { get; } = 0;
        public string Description { get; }
        public int Level { get; private set; }

        public SpeedPotion(string name, int level, int speed, string description)
        {
            IncreasingSpeed = speed;
            Name = name;
            Level = level;
            Description = description;
        }

        public bool Use(Player player)
        {
            player.IncreaseSpeed(IncreasingSpeed);
            return true;
        }

        public void LevelUp()
        {
            Level++;
            IncreasingSpeed = (int)(IncreasingSpeed + Level * 1.3);
        }
    }
}
