using Ehome_BackEnd.DAL;
using Ehome_BackEnd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ehome_BackEnd.Areas.EhomeAdmin.Controllers
{
    [Area("EhomeAdmin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _context.Category.ToListAsync();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category categories)
        {
            if (!ModelState.IsValid) return View();

            await _context.Category.AddAsync(categories);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            Models.Category categories = await _context.Category.FirstOrDefaultAsync(s => s.Id == id);
            if (categories == null) return NotFound();
            return View(categories);
        }
        public async Task<IActionResult> Edit(int id)
        {
            Models.Category categories = await _context.Category.FirstOrDefaultAsync(s => s.Id == id);
            if (categories == null) return NotFound();
            return View(categories);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(int id, Category categories)
        {

            Models.Category existedCategory = await _context.Category.FirstOrDefaultAsync(s => s.Id == id);
            if (existedCategory == null) return NotFound();
            if (id != categories.Id) return BadRequest();

            //existedSize.Name = size.Name;
            //_context.Sizes.Update(size);
            _context.Entry(existedCategory).CurrentValues.SetValues(categories);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Category categories = await _context.Category.FirstOrDefaultAsync(s => s.Id == id);
            if (categories == null) return NotFound();
            return View(categories);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            Category categories = await _context.Category.FirstOrDefaultAsync(s => s.Id == id);
            if (categories == null) return NotFound();

            _context.Category.Remove(categories);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
