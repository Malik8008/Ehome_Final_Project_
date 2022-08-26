using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ehome_BackEnd.Models
{
    public class Campaing:BaseEntity
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public DateTime EndTime { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
