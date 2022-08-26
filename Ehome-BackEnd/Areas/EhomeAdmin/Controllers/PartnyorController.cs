using Ehome_BackEnd.DAL;
using Ehome_BackEnd.Extensions;
using Ehome_BackEnd.Models;
using Ehome_BackEnd.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ehome_BackEnd.Areas.EhomeAdmin.Controllers
{
    [Area("EhomeAdmin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class PartnyorController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public PartnyorController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Partnyor> partnyors = await _context.Partnyors.ToListAsync();
            return View(partnyors);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Partnyor partnyor)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (partnyor.Photo != null)
            {
                if (!partnyor.Photo.IsOkay(1))
                {
                    ModelState.AddModelError("Photo", "Please choose supported file");
                    return View();
                }
                partnyor.Name = await partnyor.Photo.FileCreate(_env.WebRootPath, @"assets\IMG\partnyor-image");
                _context.Partnyors.Add(partnyor);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("Photo", "Please choose file");
                return View();
            }
        }
        public async Task<IActionResult> Detail(int id)
        {
            Partnyor partnyor = await _context.Partnyors.FirstOrDefaultAsync(m => m.Id == id);
            if (partnyor == null) return NotFound();
            return View(partnyor);

        }

        public async Task<IActionResult> Edit(int id)
        {
            Partnyor partnyor = await _context.Partnyors.FirstOrDefaultAsync(m => m.Id == id);
            if (partnyor == null) return BadRequest();
            return View(partnyor);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Partnyor partnyor, int id)
        {
            Partnyor oldPartnyor = await _context.Partnyors.FirstOrDefaultAsync(m => m.Id == id);
            if (oldPartnyor == null) return NotFound();
            if (id != partnyor.Id) return BadRequest();

            oldPartnyor.Name = partnyor.Name;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Partnyor partnyor = await _context.Partnyors.FirstOrDefaultAsync(s => s.Id == id);
            if (partnyor == null) return NotFound();
            return View(partnyor);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSlider(int id)
        {
            Partnyor partnyor = await _context.Partnyors.FirstOrDefaultAsync(s => s.Id == id);
            if (partnyor == null) return NotFound();

            _context.Partnyors.Remove(partnyor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
