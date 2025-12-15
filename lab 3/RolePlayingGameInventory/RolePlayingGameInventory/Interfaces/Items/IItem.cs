namespace RolePlayingGameInventory.Interfaces.Items;

public interface IItem
{
    string Name { get; }
    int Weight { get; }
    string Description { get; }
}