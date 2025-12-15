namespace RolePlayingGameInventory.Interfaces.Items;

public interface IWeapon: ICanLevelUp, IEquipable
{
    int Damage { get; set; }
}