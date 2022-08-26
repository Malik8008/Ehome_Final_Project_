using Ehome_BackEnd.Areas.EhomeAdmin.ViewModels;
using Ehome_BackEnd.DAL;
using Ehome_BackEnd.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ehome_BackEnd.Areas.EhomeAdmin.Controllers
{
    [Area("EhomeAdmin")]
    //[Authorize(Roles ="Admin,SuperAdmin")]
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            List<AppUser> users = await _context.AppUsers.ToListAsync();
            return View(users);
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(AdminLoginVM loginVM)
        {
            if (!ModelState.IsValid) return View();
            AppUser admin = await _userManager.Users.FirstOrDefaultAsync(x => x.NormalizedUserName == loginVM.UserName.ToUpper() && x.IsAdmin == true);
            if (admin == null)
            {
                ModelState.AddModelError("", "Ad və ya Şifrə yanlışdır!!!");
                return View();
            }
            var result = await _signInManager.PasswordSignInAsync(admin, loginVM.Password, false, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Ad və ya Şifrə yanlışdır!!!");
                return View();
            }
            return RedirectToAction("index", "dashboard");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("login", "account");
        }
        public async Task<IActionResult> CreateAdmin()
        {
            AppUser admin = new AppUser
            {
                UserName = "Malik",
                Name = "Malik",
                Surname = "Safarov",
                Email = "maliksafarov8008@gmail.com",
                IsAdmin = true,
                
            };
            var result = await _userManager.CreateAsync(admin, "Malik8008");
            await _userManager.AddToRoleAsync(admin, "SuperAdmin");
            _context.SaveChanges();

            return Ok(result);
        }
    }
}
