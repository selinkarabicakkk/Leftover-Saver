
namespace CleanArchitecture.Core.Entities


    public class BasketItem
{
   
    public string ProductId { get; set; } // Foreign key to Product
    public int pieceNumber { get; set; }
    public string BasketID { get; set; }

    // Other properties
}
