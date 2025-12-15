using RolePlayingGameInventory.Interfaces.Items;

namespace RolePlayingGameInventory.Interfaces.Factories;

public interface IPotionItemFactory
{
    IPotion CreateHealthPotion(int level = 1);
    IPotion CreateSpeedPotion(int level = 1);
}