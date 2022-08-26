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
    public class CampaingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CampaingController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Campaing> campaings = await _context.Campaings.ToListAsync();
            return View(campaings);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Campaing campaing)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (campaing.Photo != null)
            {
                if (!campaing.Photo.IsOkay(1))
                {
                    ModelState.AddModelError("Photo", "Please choose supported file");
                    return View();
                }
                campaing.Image = await campaing.Photo.FileCreate(_env.WebRootPath, @"assets\IMG\kampaniya-image");
                _context.Campaings.Add(campaing);
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
            Campaing campaing = await _context.Campaings.FirstOrDefaultAsync(m => m.Id == id);
            if (campaing == null) return NotFound();
            return View(campaing);

        }

        public async Task<IActionResult> Edit(int id)
        {
            Campaing campaing = await _context.Campaings.FirstOrDefaultAsync(m => m.Id == id);
            if (campaing == null) return BadRequest();
            return View(campaing);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Campaing campaing, int id)
        {
            Campaing oldCampaing = await _context.Campaings.FirstOrDefaultAsync(m => m.Id == id);
            if (oldCampaing == null) return NotFound();
            if (id != campaing.Id) return BadRequest();

            oldCampaing.Image = campaing.Image;
            oldCampaing.Title = campaing.Title;
            oldCampaing.Subtitle = campaing.Subtitle;
            oldCampaing.EndTime = campaing.EndTime;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            Campaing campaing = await _context.Campaings.FirstOrDefaultAsync(s => s.Id == id);
            if (campaing == null) return NotFound();
            return View(campaing);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCampaing(int id)
        {
            Campaing campaing = await _context.Campaings.FirstOrDefaultAsync(s => s.Id == id);
            if (campaing == null) return NotFound();

            _context.Campaings.Remove(campaing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
