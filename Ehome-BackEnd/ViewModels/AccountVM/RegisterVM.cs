using System.ComponentModel.DataAnnotations;

namespace Ehome_BackEnd.ViewModels.AccountVM
{
    public class RegisterVM
    {
        [Required,StringLength(maximumLength:25)]
        public string Name { get; set; }
        [Required, StringLength(maximumLength: 30)]
        public string Surname { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [StringLength(maximumLength: 25, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [StringLength(maximumLength: 25, MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }


    }
}
