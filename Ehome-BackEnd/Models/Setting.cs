using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ehome_BackEnd.Models
{
    public class Setting:BaseEntity
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Url { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
