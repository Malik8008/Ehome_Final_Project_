using Ehome_BackEnd.Areas.EhomeAdmin.ViewModels;
using Ehome_BackEnd.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Ehome_BackEnd.Areas.EhomeAdmin.Controllers
{
    [Area("EhomeAdmin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            EhomeChartVM ehomeChartVM = new EhomeChartVM
            {
                Futnitures = await _context.Futnitures.ToListAsync(),
                appUsers = await _context.AppUsers.ToListAsync(),
                Comments = await _context.Comments.ToListAsync(),
            };
            return View(ehomeChartVM);
        }
    }
}
