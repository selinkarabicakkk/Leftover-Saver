
namespace CleanArchitecture.Core.Entities
{

    public class Favourites: AuditableBaseEntity
    {
        public string RestaurantID { get; set; }
        public string UserName { get; set; }


        // Other properties
    }
}