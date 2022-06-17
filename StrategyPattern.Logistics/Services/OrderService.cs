using StrategyPattern.Logistics.Models;
using StrategyPattern.Logistics.Strategies;

namespace StrategyPattern.Logistics.Services;

public class OrderService : IOrderService
{
    public ISalesTaxStrategy SalesTaxStrategy { get; set; }
    public decimal GetTax(Order order)
    {
        return SalesTaxStrategy == null ? 0m : SalesTaxStrategy.GetTaxFor(order);
    }
    
}