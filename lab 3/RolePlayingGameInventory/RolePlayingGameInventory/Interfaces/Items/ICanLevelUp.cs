namespace RolePlayingGameInventory.Interfaces.Items;

public interface ICanLevelUp: IItem
{
    int Level { get; }
    void LevelUp();
}