namespace CleanArchitecture.Core.Entities
{
    public class Customer : AuditableBaseEntity
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Emial { get; set; }
        public string Password { get; set; }
        public int FavouritesID { get; set; }
        public int BasketID { get; set; }


        //Database Modified

    }
}