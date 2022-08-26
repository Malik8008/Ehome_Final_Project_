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
    public class MatrealController : Controller
    {
        private readonly AppDbContext _context;

        public MatrealController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Matreals.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Matreal matreal)
        {
            await _context.AddAsync(matreal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            Matreal matreal = _context.Matreals.FirstOrDefault(m => m.Id == id);
            if (matreal == null) return NotFound();
            return View(matreal);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Matreal matreal, int id)
        {
            Matreal existedMatreal = await _context.Matreals.FindAsync(id);
            if (existedMatreal == null) return NotFound();

            existedMatreal.Name = matreal.Name;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Matreal matreal = await _context.Matreals.FindAsync(id);
            if (matreal == null)
            {
                return NotFound();
            }
            if (matreal.IsDeleted == false)
            {
                matreal.IsDeleted = true;
            }
            else
            {
                matreal.IsDeleted = false;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
