using Ehome_BackEnd.Models;
using System.Collections.Generic;

namespace Ehome_BackEnd.Areas.EhomeAdmin.ViewModels
{
    public class EhomeChartVM
    {
        public List<Futniture> Futnitures { get; set; }
        public List<Comment> Comments { get; set; } 
        public List<AppUser> appUsers { get; set; }
    }
}
