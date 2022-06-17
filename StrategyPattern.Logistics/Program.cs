

using StrategyPattern.Logistics.Models;
using StrategyPattern.Logistics.Services;
using StrategyPattern.Logistics.Strategies;

var service = new OrderService();
Order order = GetSampleOrder();

var destination = order.ShippingDetails.DestinationCountry.ToLowerInvariant();
if (destination == "sweden")
    service.SalesTaxStrategy = new SwedenSalesTaxStrategy();
if (destination == "us")
    service.SalesTaxStrategy = new UsaSalesTaxStrategy();

var tax = service.GetTax(order);

Console.WriteLine($"Calculated tax: {tax}");
Console.ReadLine();


static Order GetSampleOrder()
{
    var order = new Order
    {
        ShippingDetails = new ShippingDetails{
            OriginCountry = "Sweden",
            DestinationCountry = "US",
            DestinationState = "LA"
        },
        LineItems = new List<Item>(),
        TotalPrice = 100
    };

    order.LineItems.Add(new Item()
    {
        Name = "CSHARP_SMORGASBORD",
        Description = "C# Smorgasbord",
        Tax = 100m,
        Type = ItemType.Technical
    });

    order.LineItems.Add(new Item()
    {
        Name = "Consulting",
        Description = "Building a website",
        Tax = 100m,
        Type = ItemType.Technical
    });
    
    order.LineItems.Add(new Item()
    {
        Name = "The Catcher in the Rye",
        Description = "Originally intended for adults, often read by adolescents for its themes of angst, alienation, and as a critique of superficiality in society.",
        Tax = 10m,
        Type = ItemType.Literature
    });
    return order;
}