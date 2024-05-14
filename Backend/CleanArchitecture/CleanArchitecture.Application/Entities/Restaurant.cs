
namespace CleanArchitecture.Core.Entities


    public class Restaurant
{
    public string RestaurantID { get; set; }
    public string Name { get; set; } // Foreign key to Business
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber{ get; set; }
    public int AddressID { get; set; }
    public string StoreType { get; set; }
    public double Rate { get; set; }
    // Other properties
}
