
namespace CleanArchitecture.Core.Entities
{

    public class BasketItem: AuditableBaseEntity
    {
        public int Id { get; set; }
        public string itemID { get; set; } // Foreign key to Product
        public int PieceNumber { get; set; }
        public string BasketID { get; set; }

        // Other properties
    }
}