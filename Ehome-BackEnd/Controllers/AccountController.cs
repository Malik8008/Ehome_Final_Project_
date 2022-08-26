using Ehome_BackEnd.DAL;
using Ehome_BackEnd.Enums;
using Ehome_BackEnd.Models;
using Ehome_BackEnd.Services;
using Ehome_BackEnd.ViewModels.AccountVM;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Ehome_BackEnd.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(AppDbContext context,IWebHostEnvironment env, UserManager<AppUser> userManager,SignInManager<AppUser> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _env = env;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View();

            AppUser user = await _userManager.FindByNameAsync(login.Username);
            IList<string> roles = await _userManager.GetRolesAsync(user);
            string role = roles.FirstOrDefault(r => r == Role.Member.ToString());

            if (user == null)
            {
                ModelState.AddModelError("","Username ve ya Password yanlisdir");
                return View();
            }
                Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, login.Password, true, true);

                if (!result.Succeeded)
                {
                    ModelState.AddModelError("","Username ve ya Password yanlisdir");
                    return View();
                }


                Microsoft.AspNetCore.Identity.SignInResult result2 = await _signInManager.PasswordSignInAsync(user, login.Password, false, true);

                if (!result2.Succeeded)
                {
                    if (result2.IsLockedOut)
                    {
                        ModelState.AddModelError("", "Şifrəni 3 dəfə yanlış girdyiniz üçün 1 dəqiqəlik  bloklandıniz!");
                        return View();
                    }
                    ModelState.AddModelError("", "Username ve ya Password yanlisdir");
                    return View();
                }
            
            return RedirectToAction("index", "home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            AppUser appUser = new AppUser
            {
                UserName = registerVM.Email,
                Name = registerVM.Name,
                Email = registerVM.Email,
                Surname = registerVM.Surname,
                PhoneNumber= registerVM.Phone
            };

            IdentityResult result = await _userManager.CreateAsync(appUser, registerVM.Password);
            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            await _userManager.AddToRoleAsync(appUser, "Member");

            string token = await _userManager.GenerateEmailConfirmationTokenAsync(appUser);
            string link = Url.Action(nameof(VerifyEmail), "Account", new { email = appUser.Email, token }, Request.Scheme);
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("tu60prbs1@code.edu.az", "Ehome");
            mail.To.Add(new MailAddress(appUser.Email,"Ehome Mebel"));

            mail.Subject = "Verify Email";
            string body = string.Empty;
            using (StreamReader reader = new StreamReader("wwwroot/assets/template/verifyemail.html"))
            {
                body = reader.ReadToEnd();
            }
            mail.Body = body.Replace("{{link}}", link);
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("tu60prbs1@code.edu.az", "ecpkuiidlpdynjla");
            smtp.Send(mail);


            return RedirectToAction("index","home");
        }

        public async Task<IActionResult> VerifyEmail(string email,string token)
        {
            AppUser user = await _userManager.FindByEmailAsync(email);
            if (user == null) return BadRequest();
            await _userManager.ConfirmEmailAsync(user,token);

            await _signInManager.SignInAsync(user, true);
            return RedirectToAction("index","home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }

        //public async Task<IActionResult> CreateRoles()
        //{
        //    IdentityRole role1 = new IdentityRole("SuperAdmin");
        //    IdentityRole role2 = new IdentityRole("Admin");
        //    IdentityRole role3 = new IdentityRole("Member");
        //    await _roleManager.CreateAsync(role3);
        //    await _roleManager.CreateAsync(role2);
        //    await _roleManager.CreateAsync(role1);
        //    return Ok();
        //}

        public IActionResult Forgot()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Forgot(ForgotVM forgotView)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser user = await _userManager.FindByEmailAsync(forgotView.Email);
            if (user == null)
            {
                ModelState.AddModelError("Email", "Belə bir istifadəçi Mövcud deyil!!!");
                return View();
            }
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("resetpassword", "account", new { email = user.Email, token }, Request.Scheme);
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("tu60prbs1@code.edu.az", "Ehome");
            mail.To.Add(new MailAddress(user.Email));

            mail.Subject = "Reset Password";
            mail.Body = $"<a href='{url}'>please click here to reset your password </a>";
            mail.IsBodyHtml = true; 
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("tu60prbs1@code.edu.az", "ecpkuiidlpdynjla");
            smtp.Send(mail);
            return RedirectToAction("index", "home");
        }

        public async Task<IActionResult> ResetPassword(string email,string token)
        {
            AppUser user = await _userManager.FindByEmailAsync(email);
            if (user == null) return BadRequest();
            AccountVM account = new AccountVM
            {
                AppUser = user, 
                Token = token,
            };
            return View(account);   

        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ResetPassword(AccountVM acount)
        {

            AppUser user = await _userManager.FindByEmailAsync(acount.AppUser.Email);

            AccountVM account = new AccountVM
            {
                AppUser = user,
                Token = acount.Token,
            };
            if (!ModelState.IsValid) return View();

            IdentityResult result = await _userManager.ResetPasswordAsync(user, acount.Token, acount.PassWord);
            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("",error.Description);
                }
                return View(account);
            }
            return RedirectToAction("index", "home");
        }
    }
}
