namespace VendingMachine.Models;

public class Product
{
    public string ProductName { get; set; }
    public int ProductQuantity { get; set; }
    public int ProductPrice { get; set; }

    public Product(string name, int price, int quantity)
    {
        ProductName = name;
        ProductPrice = price;
        ProductQuantity = quantity;
    }
        
    public override string ToString()
    {
        return $"{ProductName} {ProductPrice}р (в наличии {ProductQuantity} шт)";
    }
}