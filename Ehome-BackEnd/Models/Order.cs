using Ehome_BackEnd.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ehome_BackEnd.Models
{
    public class Order:BaseEntity
    {
        public string AppUserId { get; set; }
        [StringLength(maximumLength: 100)]
        public string Email { get; set; }
        [StringLength(maximumLength: 25)]
        public string Phone { get; set; }
        [StringLength(maximumLength: 25)]
        public string Name { get; set; }
        [StringLength(maximumLength: 25)]
        public string Surname { get; set; }
        [StringLength(maximumLength: 150)]
        public string Address { get; set; }
        public OrderStatus Status { get; set; }
        public OrderDeliveryStatus? DeliveryStatus { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }
        public AppUser AppUser { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
