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
    public class CountryController : Controller
    {
        private readonly AppDbContext _context;

        public CountryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Countries.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Country country)
        {
            await _context.AddAsync(country);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            Country country = await _context.Countries.FindAsync(id);
            if (country == null) return NotFound();
            return View(country);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Country country,int id)
        {
            Country existedCountry = await _context.Countries.FindAsync(id);
            if (existedCountry == null) return NotFound();

            existedCountry.Name = country.Name;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Country country = await _context.Countries.FindAsync(id);
            if (country == null)
            {
                return NotFound();
            }
            if (country.IsDeleted == false)
            {
                country.IsDeleted = true;
            }
            else
            {
                country.IsDeleted = false;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
