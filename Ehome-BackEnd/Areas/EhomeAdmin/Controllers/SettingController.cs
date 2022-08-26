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
    public class SettingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SettingController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Setting> settings= await _context.Settings.ToListAsync();
            return View(settings);
        }
        public async Task<IActionResult> Detail(int id)
        {
            Setting setting = await _context.Settings.FirstOrDefaultAsync(s => s.Id == id);
            return View(setting);
        }

        public async Task<IActionResult> Delete(int id)
        {
            Setting setting = await _context.Settings.FirstOrDefaultAsync(s => s.Id == id);
            return View(setting);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSetting(int id)
        {
            Setting existed = await _context.Settings.FirstOrDefaultAsync(s => s.Id == id);
            _context.Settings.Remove(existed);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            Setting setting = await _context.Settings.FirstOrDefaultAsync(s => s.Id == id);
            return View(setting);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Setting setting, int id)
        {
            if (!ModelState.IsValid) return View();

            Setting oldSetting = await _context.Settings.FirstOrDefaultAsync(m => m.Id == id);
            if (oldSetting == null) return NotFound();
            if (setting.Photo != null)
            {
                if (setting.Photo.Length < 1024 * 1024 && setting.Photo.ContentType.Contains("image"))
                {
                    string path = _env.WebRootPath + @"\assets\img" + oldSetting.Value;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    oldSetting.Value = await setting.Photo.FileCreate(_env.WebRootPath, @"assets\IMG");
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            oldSetting.Value= setting.Value;
            oldSetting.Key = setting.Key;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
