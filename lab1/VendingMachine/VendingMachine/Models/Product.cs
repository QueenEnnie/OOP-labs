namespace VendingMachine.Models;

public class Product
{
    public string ProductName { get; }
    public int ProductQuantity { get; private set; }
    public int ProductPrice { get; }

    public Product(string name, int price, int quantity)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Product name cannot be empty.", nameof(name));
        }
        if (price <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(price), "Product price must be positive.");
        }
        if (quantity < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(quantity), "Product quantity cannot be negative.");
        }

        ProductName = name;
        ProductPrice = price;
        ProductQuantity = quantity;
    }

    public void AddQuantity(int quantity)
    {
        if (quantity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be positive.");
        }

        ProductQuantity += quantity;
    }

    public bool TryTakeOne()
    {
        if (ProductQuantity <= 0)
        {
            return false;
        }

        ProductQuantity -= 1;
        return true;
    }
        
    public override string ToString()
    {
        return $"{ProductName} {ProductPrice}р (в наличии {ProductQuantity} шт)";
    }
}
