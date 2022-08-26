using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ehome_BackEnd.Models
{
    public class Partnyor:BaseEntity
    {
        public string Name { get; set; }
       [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
