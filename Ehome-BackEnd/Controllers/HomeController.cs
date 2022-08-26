using Ehome_BackEnd.DAL;
using Ehome_BackEnd.Models;
using Ehome_BackEnd.ViewModels.HomeVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Ehome_BackEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM home = new HomeVM
            {
                Settings = await _context.Settings.ToListAsync(),
                Partnyors = await _context.Partnyors.ToListAsync(),
                Services = await _context.Services.ToListAsync(),
                Sliders = await _context.Sliders.ToListAsync(),
                Futnitures = await _context.Futnitures.Include(s=>s.FurnitureImages).ToListAsync(),
                Categories = await _context.Category.ToListAsync(),
                Campaings = await _context.Campaings.ToListAsync(),
                WishlistItems = await _context.Wishlist.ToListAsync(),
            };
            return View(home);

        }
    }
}
