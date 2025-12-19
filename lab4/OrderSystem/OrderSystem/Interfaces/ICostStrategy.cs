namespace OrderSystem.Interfaces;

public interface ICostStrategy
{
    decimal DefineFinalCost(List<IDish> dishes);
}