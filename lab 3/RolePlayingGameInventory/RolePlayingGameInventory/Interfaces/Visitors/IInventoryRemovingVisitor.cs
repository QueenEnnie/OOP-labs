using RolePlayingGameInventory.Interfaces.Items;
using RolePlayingGameInventory.Models;
using RolePlayingGameInventory.Models.Items;

namespace RolePlayingGameInventory.Interfaces.Visitors;

public interface IInventoryRemovingVisitor
{
    void VisitRemove(QuestItem item);
    void VisitRemove(ICanLevelUp item);
}