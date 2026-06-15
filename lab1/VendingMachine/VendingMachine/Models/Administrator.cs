namespace VendingMachine.Models;

public class Administrator
{
    private readonly Machine _machine;
    
    public Administrator(Machine machine)
    {
        _machine = machine;
    }

    public void GetMoney()
    {
        var money = _machine.CollectRevenue();
        Console.WriteLine($"Выручка автомата составляет {money}р.");
    }

    public void RefillMachine(string name, int quantity)
    {
        _machine.RefillProduct(name, quantity);
        Console.WriteLine($"Вы пополнили {name} на {quantity} шт. " +
                          $"Текущее количество: {_machine.Products[name].ProductQuantity} шт.");
    }

    public void AddNewProduct(string name, int price, int quantity)
    {
        _machine.AddNewProduct(name, price, quantity);
        Console.WriteLine($"Вы добавили товар {name} стоимостью {price}р в количестве {quantity} шт.");
    }
}
