using Ehome_BackEnd.DAL;
using Ehome_BackEnd.Models;
using Ehome_BackEnd.ViewModels.Furniture;
using Ehome_BackEnd.ViewModels.HomeVM;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ehome_BackEnd.Controllers
{
    public class FurnitureController : Controller
    {
        private readonly AppDbContext _context;
        UserManager<AppUser> _userManager;

        public FurnitureController(AppDbContext context,UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager=userManager;

        }
        public async Task<IActionResult> Index(int id)
        {

            HomeVM home = new HomeVM
            {
                Categories = await _context.Category.Where(m=>m.Id==id).ToListAsync(),
                Futnitures = await _context.Futnitures.Include(s => s.FurnitureImages).Where(m=>m.CategoryId==id).ToListAsync(),
            };
            return View(home);
        }
        public IActionResult AddBasket(int id)
        {
            Futniture futniture = _context.Futnitures.Include(x => x.Color).Include(x=>x.Category).Include(x => x.Country).Include(x => x.FurnitureImages)
                .FirstOrDefault(x => x.Id == id);
            if (futniture == null)
            {
                return NotFound();
            }
            BasketVM basketItem = null;
         
            List<BasketVM> products = new List<BasketVM>();
            string productStr;
            if (HttpContext.Request.Cookies["Basket"] != null)
            {
                productStr = HttpContext.Request.Cookies["Basket"];
                products = JsonConvert.DeserializeObject<List<BasketVM>>(productStr);
                basketItem = products.FirstOrDefault(x => x.ProductId == id);
            }

            if (basketItem == null)
            {
                basketItem = new BasketVM
                {
                    ProductId = futniture.Id,
                    ProductName = futniture.Name,
                    Image = futniture.FurnitureImages.FirstOrDefault(x => x.IsMain == true).Image,
                    Price = futniture.SalePrice,
                    Category = futniture.Category.Name,
                    Discount = futniture.Discount,
                    Count = 1,
                };
                products.Add(basketItem);

            }
            else
            {
                basketItem.Count++;
            }
            productStr = JsonConvert.SerializeObject(products);
            HttpContext.Response.Cookies.Append("Basket", productStr);

            return PartialView("_PartialView", products);

        }
        public IActionResult RemoveBasket(int id)
        {
            Futniture futniture = _context.Futnitures.Include(x => x.Color).Include(x => x.Category).Include(x => x.Country).Include(x => x.FurnitureImages)
               .FirstOrDefault(x => x.Id == id);
            if (futniture == null)
            {
                return NotFound();
            }
            BasketVM basketItem = null;
            List<BasketVM> products = new List<BasketVM>();
            string ProductStr = HttpContext.Request.Cookies["Basket"];
            products = JsonConvert.DeserializeObject<List<BasketVM>>(ProductStr);

            basketItem = products.FirstOrDefault(x => x.ProductId == id);

            if (basketItem.Count == 1)
            { products.Remove(basketItem); }
            else { basketItem.Count--; }



            ProductStr = JsonConvert.SerializeObject(products);
            HttpContext.Response.Cookies.Append("Basket", ProductStr);
            return PartialView("_PartialView", products);

        }
        public IActionResult RemoveAllBasket(int id)
        {
            Futniture futniture = _context.Futnitures.Include(x => x.Color).Include(x => x.Category).Include(x => x.Country).Include(x => x.FurnitureImages)
               .FirstOrDefault(x => x.Id == id);
            if (futniture == null)
            {
                return NotFound();
            }
            BasketVM basketItem = null;
            List<BasketVM> products = new List<BasketVM>();
            string ProductStr = HttpContext.Request.Cookies["Basket"];
            products = JsonConvert.DeserializeObject<List<BasketVM>>(ProductStr);

            basketItem = products.FirstOrDefault(x => x.ProductId == id);
             products.Remove(basketItem);
            ProductStr = JsonConvert.SerializeObject(products);
            HttpContext.Response.Cookies.Append("Basket", ProductStr);
            return PartialView("_PartialView", products);

        }
    }
}
