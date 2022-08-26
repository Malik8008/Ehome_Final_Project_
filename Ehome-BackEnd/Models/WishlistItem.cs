namespace Ehome_BackEnd.Models
{
    public class WishlistItem:BaseEntity
    {
        public int FutnitureId { get; set; }
        public Futniture Futniture { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
