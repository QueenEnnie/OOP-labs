using RolePlayingGameInventory.Interfaces;
using RolePlayingGameInventory.Interfaces.Items;
using RolePlayingGameInventory.Interfaces.Visitors;
using RolePlayingGameInventory.Models.Items;

namespace RolePlayingGameInventory.Models;

public class Inventory: IInventoryAddingVisitor, IInventoryRemovingVisitor
{
    private List<QuestItem> _questItems;
    private List<IItem>  _otherItems;
    private int _maxWeight { get; set; } = 100;
    private int _currentWeight { get; set; } = 0;

    public Inventory()
    {
        _questItems = new List<QuestItem>();
        _otherItems = new List<IItem>();
    }

    public void LevelUp()
    {
        foreach (var item in _otherItems)
        {
            var itemToLevelUp = (ICanLevelUp)item;
            itemToLevelUp.LevelUp();
        }
    }
    
    public InventoryInformation GetInformation()
    {
        return new InventoryInformation(
            questItems: _questItems,
            otherItems: _otherItems,
            currentWeight: _currentWeight,
            maxWeight: _maxWeight
        );
    }

    public bool ContainsEquipableItem(IItem item)
    {
        return _otherItems.Contains(item);
        
    }
    public void VisitAdd(QuestItem item)
    {
        _questItems.Add(item);
    }

    public void VisitAdd(ICanLevelUp item)
    {
        if (_currentWeight + item.Weight <= _maxWeight)
        {
            _otherItems.Add(item);
            _currentWeight += item.Weight;
        }
    }

    public void VisitRemove(QuestItem item)
    {
        _questItems.Remove(item);
    }

    public void VisitRemove(ICanLevelUp item)
    {
        if (_otherItems.Contains(item))
        {
            _otherItems.Remove(item);
            _currentWeight -= item.Weight;
        }
    }
}