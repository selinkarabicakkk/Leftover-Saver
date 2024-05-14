
namespace CleanArchitecture.Core.Entities
    
    public class Item
{
    public int ItemID { get; set; }
    public int RestaurantID { get; set; } // Foreign key to Business
    public string itemName { get; set; }
    public decimal price { get; set; }
    public string picture { get; set; }
    public string explanation { get; set; }
    // Other properties
}
