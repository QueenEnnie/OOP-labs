namespace OrderSystem.Interfaces;

public interface IDish
{
    string GetName();
    string GetDescription();
    decimal GetPrice();
}