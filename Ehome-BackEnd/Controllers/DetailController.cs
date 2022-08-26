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
    public class DetailController : Controller
    {
        private readonly AppDbContext _context;

        public DetailController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int id)
        {
            List<Comment> comments = await _context.Comments.ToListAsync();
            HomeVM home = new HomeVM
            {
                Comments=comments,
                Futnitures = await _context.Futnitures.Include(s => s.FurnitureImages)
                .Include(m=>m.Color)
                .Include(m=>m.Matreal)
                .Include(m=>m.Brand)
                .Include(m => m.Country)
                .Include(m => m.Category)
                .Where(m => m.Id == id).ToListAsync(),
            }; 
            return View(home);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Index(Comment comment)
        {
            HomeVM home = new HomeVM
            {
                Futnitures = await _context.Futnitures.Include(s => s.FurnitureImages)
                .Include(m => m.Color)
                .Include(m => m.Matreal)
                .Include(m => m.Brand)
                .Include(m => m.Country)
                .Include(m => m.Category).ToListAsync(),
            };

            
            if (!ModelState.IsValid)
            {
                return View(home);
            }

            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
