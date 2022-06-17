using StrategyPattern.Logistics.Models;

namespace StrategyPattern.Logistics.Strategies;

public interface ISalesTaxStrategy
{
    decimal GetTaxFor(Order order);
}