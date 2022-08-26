using Ehome_BackEnd.DAL;
using Ehome_BackEnd.Models;
using Ehome_BackEnd.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ehome_BackEnd.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public OrderController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }
        public IActionResult Checkout()
        {
            List<CheckOutVM> products = _getBasketItem();
            if (User.Identity.IsAuthenticated)
            {
               AppUser member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);

            }
            else
            {
                return RedirectToAction("login", "account");
            }
            return View(products);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public IActionResult Checkout(CheckOutVM checkOutVM)
        {
            if (!ModelState.IsValid) return View(checkOutVM);

            AppUser member = null;
            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);

            }
            else
            {
                return RedirectToAction("login", "account");
            }


            Order order = new Order()
            {
                AppUserId=member.Id,
                Name = member.Name,
                Surname = member.Surname,
                Phone = member.PhoneNumber,
                CreatedAt = DateTime.UtcNow.AddHours(4),
                DeliveryStatus = Enums.OrderDeliveryStatus.Anbarda,
                OrderItems = new List<OrderItem>(),
                Status = Enums.OrderStatus.Gözləmədə

            };
            List<CheckOutVM> checkouts = _getBasketItem();
            foreach (var item in checkouts)
            {
                OrderItem orderItem = new OrderItem()
                {
                    ProdName = item.ProductName,

                    FutnitureId = item.ProductId,
                    Futniture = _context.Futnitures.FirstOrDefault(x => x.Id == item.ProductId),
                    OrderId = order.Id,
                    CostPrice = item.CostPrice,
                    SalePrice = item.SalePrice,
                    DiscountPercent = item.Discount,
                    Count = item.Count,

                };
                order.OrderItems.Add(orderItem);
                _context.OrderItems.Add(orderItem);
            
            }
            if (order.OrderItems.Count == 0)
            {
                ModelState.AddModelError("", "NotFound");
                return View(checkOutVM);
            }

            _context.Orders.Add(order);
            _context.SaveChanges();
            Response.Cookies.Delete("BasketItem");
            return RedirectToAction("index", "home");
        }
        private List<CheckOutVM> _getBasketItem()
        {
            List<CheckOutVM> products = new List<CheckOutVM>();
            AppUser member = null;
            if (User.Identity.IsAuthenticated)
            {
                member = _userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin);
            }

                var ProductSr = HttpContext.Request.Cookies["Basket"];
                if (ProductSr != null)
                {
                    products = JsonConvert.DeserializeObject<List<CheckOutVM>>(ProductSr);
                }
           if(member!=null)
            {
                products.First().Name = member.Name;
                products.First().Surname = member.Surname;
            }
           
            return products;

        }
    }
}
