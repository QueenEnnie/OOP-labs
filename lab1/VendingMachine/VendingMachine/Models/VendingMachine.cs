namespace VendingMachine.Models;

public class Machine
{
    public Machine(Product[] products)
    {
        Products = products.ToDictionary(p => p.ProductName);
        revenue = 0;
    }

    public Dictionary<string, Product> Products { get; private set; }
    public int revenue {get; set;}

    public void SellProduct(string productName)
    {
        Products[productName].ProductQuantity -= 1;
        revenue += Products[productName].ProductPrice;
        Console.WriteLine(Products[productName].ProductQuantity);
    }
    public void ShowProducts()
    {
        foreach (var product in Products.Values)
        {
            if (product.ProductQuantity > 0)
            {
                Console.WriteLine(product);
            }
        }
    }
}