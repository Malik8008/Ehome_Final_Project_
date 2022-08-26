using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Ehome_BackEnd.Models
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsAdmin { get; set; }

        public List<WishlistItem> Wishlist { get; set; }
    }
}
