using StrategyPattern.Logistics.Models;

namespace StrategyPattern.Logistics.Services;

public interface IOrderService
{
    decimal GetTax(Order order);
}