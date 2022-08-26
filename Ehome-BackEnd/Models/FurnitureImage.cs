namespace Ehome_BackEnd.Models
{
    public class FurnitureImage:BaseEntity
    {
        public string Image { get; set; }
        public bool IsMain { get; set; }
        public Futniture Futniture { get; set; }
        public int FutnitureId { get; set; }
    }
}
