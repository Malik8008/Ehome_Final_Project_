using System.ComponentModel.DataAnnotations;

namespace Ehome_BackEnd.ViewModels.AccountVM
{
    public class LoginVM
    {
        [Required]
        public string Username { get; set; }
        [Required,DataType(DataType.Password)]  
        public string Password { get; set; }
    }
}
