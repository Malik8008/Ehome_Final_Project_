using Ehome_BackEnd.DAL;
using Ehome_BackEnd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Ehome_BackEnd.Areas.EhomeAdmin.Controllers
{
    [Area("EhomeAdmin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class BrandController : Controller
    {
        private readonly AppDbContext _context;

        public BrandController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Brands.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Brand brand)
        {
            await _context.AddAsync(brand);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            Brand brand = _context.Brands.FirstOrDefault(m => m.Id == id);
            if (brand == null) return NotFound();
            return View(brand);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Brand brand, int id)
        {
            Brand existedBrand = await _context.Brands.FindAsync(id);
            if (existedBrand == null) return NotFound();

            existedBrand.Name = brand.Name;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Brand brand = await _context.Brands.FindAsync(id);
            if (brand == null)
            {
                return NotFound();
            }
            if (brand.IsDeleted == false)
            {
                brand.IsDeleted = true;
            }
            else
            {
                brand.IsDeleted = false;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
