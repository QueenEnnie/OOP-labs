using RolePlayingGameInventory.Interfaces.Items;
using RolePlayingGameInventory.Models;
using RolePlayingGameInventory.Models.Items;

namespace RolePlayingGameInventory.Interfaces.Visitors;

public interface IInventoryAddingVisitor
{
    void VisitAdd(QuestItem item);
    void VisitAdd(ICanLevelUp item);
}