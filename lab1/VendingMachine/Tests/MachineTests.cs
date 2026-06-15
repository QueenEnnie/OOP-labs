using VendingMachine.Models;

namespace Tests;

public class MachineTests
{
    [Fact]
    public void TrySellProduct_WithEnoughMoney_ShouldDecreaseQuantityAndReturnChange()
    {
        var machine = new Machine([new Product("Coke", 100, 2)]);

        var sold = machine.TrySellProduct("Coke", 150, out var change, out var message);

        Assert.True(sold);
        Assert.Equal(50, change);
        Assert.Equal("Покупка успешно завершена!", message);
        Assert.Equal(1, machine.Products["Coke"].ProductQuantity);
        Assert.Equal(100, machine.Revenue);
    }

    [Fact]
    public void TrySellProduct_WithoutStock_ShouldNotChangeRevenue()
    {
        var machine = new Machine([new Product("Coke", 100, 0)]);

        var sold = machine.TrySellProduct("Coke", 150, out var change, out _);

        Assert.False(sold);
        Assert.Equal(150, change);
        Assert.Equal(0, machine.Revenue);
    }

    [Fact]
    public void CollectRevenue_ShouldResetRevenue()
    {
        var machine = new Machine([new Product("Coke", 100, 1)]);
        machine.TrySellProduct("Coke", 100, out _, out _);

        var revenue = machine.CollectRevenue();

        Assert.Equal(100, revenue);
        Assert.Equal(0, machine.Revenue);
    }

    [Fact]
    public void RefillProduct_ShouldIncreaseExistingProductQuantity()
    {
        var machine = new Machine([new Product("Coke", 100, 1)]);

        machine.RefillProduct("Coke", 4);

        Assert.Equal(5, machine.Products["Coke"].ProductQuantity);
    }
}
