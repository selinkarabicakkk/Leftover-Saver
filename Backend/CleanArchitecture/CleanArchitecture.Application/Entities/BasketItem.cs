
namespace CleanArchitecture.Core.Entities


    public class BasketItem
{
   
    public string itemID { get; set; } // Foreign key to Product
    public int PieceNumber { get; set; }
    public string BasketID { get; set; }

    // Other properties
}
