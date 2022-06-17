using StrategyPattern.Logistics.Models;

namespace StrategyPattern.Logistics.Strategies;

public class UsaSalesTaxStrategy : ISalesTaxStrategy
{
    public decimal GetTaxFor(Order order)
    {
        decimal TotalPrice = order.TotalPrice;
        var origin = order.ShippingDetails.OriginCountry.ToLowerInvariant();
        var destinationState = order.ShippingDetails.DestinationState.ToLowerInvariant(); 

        switch (destinationState)
        {
            case "la": return TotalPrice * 0.095m;
            case "ny": return TotalPrice * 0.04m;
            case "nyc": return TotalPrice * 0.045m;
            default: return 0m;
        }
    }
}