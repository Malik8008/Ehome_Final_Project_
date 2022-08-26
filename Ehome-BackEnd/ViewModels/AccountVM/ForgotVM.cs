using System.ComponentModel.DataAnnotations;

namespace Ehome_BackEnd.ViewModels.AccountVM
{
    public class ForgotVM
    {
        [Required, StringLength(maximumLength: 100)]
        public string Email { get; set; }
    }
}
