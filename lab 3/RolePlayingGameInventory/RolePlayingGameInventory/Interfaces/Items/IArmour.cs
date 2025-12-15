namespace RolePlayingGameInventory.Interfaces.Items;

public interface IArmour: IEquipable, ICanLevelUp
{
    int Defense { get; set; }
    int Speed { get; set; }
}