using Ehome_BackEnd.DAL;
using Ehome_BackEnd.Models;
using Ehome_BackEnd.ViewModels.HomeVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ehome_BackEnd.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext _context;

        public SearchController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string search, int id)
        {
            ViewBag.Search = search;
            List<Futniture> futnitures = await _context.Futnitures.Include(m => m.FurnitureImages).Where(m => m.Name.Contains(search)).ToListAsync();
            HomeVM home = new HomeVM
            {
                Futnitures = futnitures,
            };

            return View(home);
        }
    }
}
