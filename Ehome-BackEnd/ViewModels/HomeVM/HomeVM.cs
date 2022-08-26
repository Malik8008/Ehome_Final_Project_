using Ehome_BackEnd.Models;
using System.Collections.Generic;

namespace Ehome_BackEnd.ViewModels.HomeVM
{
    public class HomeVM
    {
        public List<Setting> Settings { get; set; }
        public List<Partnyor> Partnyors { get; set; }
        public List<Service> Services { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Futniture> Futnitures { get; set; }
        public List<Category> Categories { get; set; }
        public List<Campaing> Campaings { get; set; }
        public List<WishlistItem> WishlistItems { get; set; }
        public List<Comment> Comments { get; set; }
        public Comment comment { get; set; }
        public List<Color>  Colors { get; set; }
    }
}
