using Ehome_BackEnd.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ehome_BackEnd.ViewModels.AccountVM
{
    public class AccountVM
    {
        public AppUser AppUser { get; set; }
        public string Token { get; set; }
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        [DataType(DataType.Password),Compare(nameof(PassWord))]
        public string ConfirmPassword { get; set; }
    }
}
