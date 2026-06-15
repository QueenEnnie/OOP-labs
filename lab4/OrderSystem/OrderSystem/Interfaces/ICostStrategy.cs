namespace OrderSystem.Interfaces;

public interface ICostStrategy
{
    decimal DefineFinalCost(IEnumerable<IDish> dishes);
}
