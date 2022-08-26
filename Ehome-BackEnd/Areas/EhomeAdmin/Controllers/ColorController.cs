using Ehome_BackEnd.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Ehome_BackEnd.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Ehome_BackEnd.Areas.EhomeAdmin.Controllers
{
    [Area("EhomeAdmin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class ColorController : Controller
    {
        private readonly AppDbContext _context;

        public ColorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Colors.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Color color)
        {
            await _context.AddAsync(color);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id)
        {
            Color color =  _context.Colors.FirstOrDefault(m=>m.Id==id);
            if (color == null) return NotFound();
            return View(color);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Color country, int id)
        {
            Color existedColor = await _context.Colors.FindAsync(id);
            if (existedColor == null) return NotFound();

            existedColor.Name = country.Name;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Color color = await _context.Colors.FindAsync(id);
            if (color == null)
            {
                return NotFound();
            }
            if (color.IsDeleted == false)
            {
                color.IsDeleted = true;
            }
            else
            {
                color.IsDeleted = false;
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
