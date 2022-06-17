namespace StrategyPattern.Logistics.Models;

public enum ItemType
{
    Technical = 0,
    Literature = 1,
    Poetry = 2
}

public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Tax { get; set; }
    public ItemType Type { get; set; }
}