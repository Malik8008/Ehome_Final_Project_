using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ehome_BackEnd.Models
{
    public class OrderItem:BaseEntity
    {
        public int OrderId { get; set; }
        [StringLength(maximumLength: 100)]
        public string ProdName { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CostPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SalePrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DiscountPercent { get; set; }
        public int Count { get; set; }
        public int FutnitureId { get; set; }
        public Futniture Futniture { get; set; }
        public Order Order { get; set; }
    }
}
