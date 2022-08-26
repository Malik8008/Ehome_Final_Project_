using Ehome_BackEnd.DAL;
using Ehome_BackEnd.Models;
using Ehome_BackEnd.ViewModels.HomeVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Ehome_BackEnd.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public BasketController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                Futnitures = await _context.Futnitures.Include(s=>s.FurnitureImages).ToListAsync(),
                WishlistItems = await _context.Wishlist.ToListAsync(),

            };
            return View(model);
        }

        public async Task<IActionResult> WishlistAdd(int id)
        {
            Futniture futniture = await _context.Futnitures.FirstOrDefaultAsync(p => p.Id == id);
            if (futniture == null) return NotFound();
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            WishlistItem wishlist = await _context.Wishlist.FirstOrDefaultAsync(a => a.AppUserId == user.Id && a.FutnitureId == futniture.Id);

            if (wishlist == null)
            {
                WishlistItem wishlistadd = new WishlistItem
                {

                    Futniture = futniture,
                    AppUser = user,

                };
                _context.Wishlist.Add(wishlistadd);


            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> DeleteBasket(int id)
        {
            Futniture futniture = await _context.Futnitures.Include(s=>s.FurnitureImages).FirstOrDefaultAsync(p => p.Id == id);
            if (futniture == null) return NotFound();

            WishlistItem wishlist = await _context.Wishlist.FirstOrDefaultAsync(a => a.FutnitureId == futniture.Id);

            if (wishlist != null)
            {
                _context.Wishlist.Remove(wishlist);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Basket");
        }
    }
}
