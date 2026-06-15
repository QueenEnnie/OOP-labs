namespace VendingMachine.Models;

public class Machine
{
    private readonly Dictionary<string, Product> _products;

    public Machine(Product[] products)
    {
        _products = products.ToDictionary(p => p.ProductName);
        Revenue = 0;
    }

    public IReadOnlyDictionary<string, Product> Products => _products;
    public int Revenue { get; private set; }

    public bool TrySellProduct(string productName, int insertedMoney, out int change, out string message)
    {
        change = insertedMoney;

        if (!_products.TryGetValue(productName, out var product))
        {
            message = "Такого продукта не существует!";
            return false;
        }

        if (product.ProductQuantity <= 0)
        {
            message = "Товар закончился!";
            return false;
        }

        if (insertedMoney < product.ProductPrice)
        {
            message = "Денег недостаточно, повторите операцию вставки монет или отмените покупку!";
            return false;
        }

        product.TryTakeOne();
        Revenue += product.ProductPrice;
        change = insertedMoney - product.ProductPrice;
        message = "Покупка успешно завершена!";
        return true;
    }

    public int CollectRevenue()
    {
        var money = Revenue;
        Revenue = 0;
        return money;
    }

    public void RefillProduct(string name, int quantity)
    {
        if (!_products.TryGetValue(name, out var product))
        {
            throw new ArgumentException("Product does not exist.", nameof(name));
        }

        product.AddQuantity(quantity);
    }

    public void AddNewProduct(string name, int price, int quantity)
    {
        _products[name] = new Product(name, price, quantity);
    }

    public void ShowProducts()
    {
        foreach (var product in _products.Values)
        {
            if (product.ProductQuantity > 0)
            {
                Console.WriteLine(product);
            }
        }
    }
}
