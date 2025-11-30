namespace RolePlayingGameInventory.Interfaces;

public interface Item
{
    string Name { get; }
    int Level { get; }
    int Weight { get; }
}