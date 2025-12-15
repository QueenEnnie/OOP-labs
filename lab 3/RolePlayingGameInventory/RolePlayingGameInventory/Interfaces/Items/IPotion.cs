using RolePlayingGameInventory.Models;

namespace RolePlayingGameInventory.Interfaces.Items;

public interface IPotion: ICanLevelUp
{
    bool Use(Player player);
}