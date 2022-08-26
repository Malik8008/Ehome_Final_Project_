using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ehome_BackEnd.Models
{
    public class Futniture:BaseEntity
    {
        public string Name { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal CostPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SalePrice { get; set; }
        public int Discount { get; set; }
        public bool IsBestSell { get; set; }
        public bool IsBestLike { get; set; }
        public bool IsPopular { get; set; }
        public bool IsSale { get; set; }
        public int? BrandId { get; set; }
        public Brand Brand { get; set; }    
        public int? MatrealId { get; set; }
        public Matreal Matreal { get; set; }
        public int ColorId { get; set; }
        public int Count { get; set; }
        public int CountryId { get; set; }
        public Color Color { get; set; }
        public Country Country { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public List<FurnitureImage> FurnitureImages { get; set; }
        [NotMapped]
        public List<int> ProductImageIds { get; set; } = new List<int>();
        [NotMapped]
        public IFormFile MainImage { get; set; }
        [NotMapped]
        public List<IFormFile> OtherImageFiles { get; set; }
        internal List<Futniture> toList()
        {
            throw new NotImplementedException();
        }
    }
}
