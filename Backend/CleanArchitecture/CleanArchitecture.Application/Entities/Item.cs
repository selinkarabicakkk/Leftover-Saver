
namespace CleanArchitecture.Core.Entities
{
    public class Item
    {
        public string ItemID { get; set; }
        public string RestaurantID { get; set; } // Foreign key to Business
        public string itemName { get; set; }
        public double price { get; set; }
        public string picture { get; set; }
        public string explanation { get; set; }
        // Other properties
    }
}