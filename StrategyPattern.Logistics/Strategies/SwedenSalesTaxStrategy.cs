using StrategyPattern.Logistics.Models;

namespace StrategyPattern.Logistics.Strategies;

public class SwedenSalesTaxStrategy: ISalesTaxStrategy
{
    public decimal GetTaxFor(Order order)
    {
        decimal TotalPrice = order.TotalPrice;
        var destination = order.ShippingDetails.DestinationCountry.ToLowerInvariant();
        var origin = order.ShippingDetails.OriginCountry.ToLowerInvariant();
        
        if (destination == origin)
            return TotalPrice * 0.25m;

        //tax per item
        return 0;
    }
}