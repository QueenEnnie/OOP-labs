using RolePlayingGameInventory.Interfaces.Items;

namespace RolePlayingGameInventory.Interfaces.Factories;

public interface IArmorItemFactory
{
    IArmour CreateArmor(int level = 1);
}