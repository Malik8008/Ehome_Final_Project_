using Ehome_BackEnd.DAL;
using Ehome_BackEnd.Models;
using Ehome_BackEnd.ViewModels.Furniture;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ehome_BackEnd.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContext;
        public LayoutService(AppDbContext context,IHttpContextAccessor httpContext)
        {
            _context = context;
            _httpContext = httpContext;
        }

        public async Task<List<Setting>> GetDatas()
        {
            List<Setting> settings = await _context.Settings.ToListAsync();
            return settings;
        }

        public async Task<List<Category>> GetCategories()
        {
            List<Category> categories = await _context.Category.ToListAsync();
            return categories;
        }

        public async Task<List<Slider>> GetSlider()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            return sliders;
        }
        public List<BasketVM> GetBasket()
        {
            List<BasketVM> baskets = new List<BasketVM>();
            var itemStr = _httpContext.HttpContext.Request.Cookies["Basket"];
            if (itemStr != null)
            {
                baskets = JsonConvert.DeserializeObject<List<BasketVM>>(itemStr);

            }
            return baskets;
        }

        public async Task<List<WishlistItem>> GetWishlit(string username)
        {
            List<WishlistItem> item = await _context.Wishlist.Include(s => s.AppUser).Where(s => s.AppUser.UserName == username).ToListAsync();

            return item;
        }
    }
}
