using RolePlayingGameInventory.Factories;
using RolePlayingGameInventory.Interfaces;
using RolePlayingGameInventory.Interfaces.Factories;
using RolePlayingGameInventory.Interfaces.Items;
using RolePlayingGameInventory.Models;
using RolePlayingGameInventory.Models.Items;
using RolePlayingGameInventory.Models.Items.Potion;
using RolePlayingGameInventory.Services;

namespace RolePlayingGameInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            IPotion potion = new HealthPotion("UsefulPotion", 1, 10, "k");
            QuestItem key = new QuestItem("Key", "key from Harry Potter");
            IWeaponArmorItemFactory itemFactory = new BaseItemFactory();
            Player player = new Player("mickie mouse");
            EquipmentService equipmentService = new EquipmentService(player.Inventory);
            PlayerArmourWeaponService playerArmourWeaponService = new PlayerArmourWeaponService(itemFactory, equipmentService);
            playerArmourWeaponService.EquipInitially(player);
            
            Inventory currentInventory = player.Inventory;
            currentInventory.VisitAdd(key);
            InformationDisplay informationDisplay = new InformationDisplay(currentInventory.GetInformation());
            informationDisplay.DisplayEverything();

        }
    }
}