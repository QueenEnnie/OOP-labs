using RolePlayingGameInventory.Factories;
using RolePlayingGameInventory.Interfaces;
using RolePlayingGameInventory.Models;
using RolePlayingGameInventory.Models.Potion;

namespace RolePlayingGameInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Potion potion = new HealthPotion("UsefulPotion", 1, 10);
            ItemFactory itemFactory = new BaseItemFactory();
            EquipmentService equipmentService = new EquipmentService();
            Player player = new Player("mickie mouse", itemFactory, equipmentService);
            player.EquipInitially();
            player.UsePotion(potion);

        }
    }
}