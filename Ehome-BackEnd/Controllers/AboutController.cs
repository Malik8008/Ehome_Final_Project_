using Ehome_BackEnd.DAL;
using Ehome_BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ehome_BackEnd.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Unvan()
        {
            return View();
        }

        public IActionResult Kredit()
        {
            return View();
        }

        public IActionResult Odeme()
        {
            return View();
        }

        public async Task<IActionResult> Kampaniya()
        {
            List<Campaing> campaings = await _context.Campaings.ToListAsync(); 
            return View(campaings);
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Questions()
        {
            return View();
        }

    }
}
