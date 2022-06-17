namespace StrategyPattern.Logistics.Models;

public class Order
{
    public ShippingDetails ShippingDetails { get; set; }
    public List<Item> LineItems { get; set; }
    public decimal TotalPrice { get; set; }
}