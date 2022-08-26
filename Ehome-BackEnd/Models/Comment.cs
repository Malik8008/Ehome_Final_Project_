using System.ComponentModel.DataAnnotations;

namespace Ehome_BackEnd.Models
{
    public class Comment:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Rey { get; set; }
    }
}
