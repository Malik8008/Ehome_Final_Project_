using Ehome_BackEnd.DAL;
using Ehome_BackEnd.Models;
using Ehome_BackEnd.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Ehome_BackEnd.Areas.EhomeAdmin.Controllers
{
    [Area("EhomeAdmin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class FurnitureController : Controller
    {
        AppDbContext _context;
        IWebHostEnvironment _env;

        public FurnitureController(AppDbContext context,IWebHostEnvironment env)
        {
            _context= context;
            _env = env;
        }
        public IActionResult Index(int page=1)
        {
            var furnitures = _context.Futnitures.Include(x => x.FurnitureImages).Include(m=>m.Brand).Include(x=>x.Matreal).Include(x => x.Color).Include(x => x.Country).ToList();
            return View(furnitures.ToPagedList(page,3));
        }
        public IActionResult Create()
        {
            ViewBag.ColorId=_context.Colors.Where(m=>m.IsDeleted==false).ToList();
            ViewBag.CountryId = _context.Countries.Where(m=>m.IsDeleted==false).ToList();
            ViewBag.CategoryId = _context.Category.Where(m => m.IsDeleted == false).ToList();
            ViewBag.MatrealId = _context.Matreals.Where(m => m.IsDeleted == false).ToList();
            ViewBag.BrandId = _context.Brands.Where(m => m.IsDeleted == false).ToList();
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Futniture futniture)
        {
            ViewBag.ColorId = _context.Colors.Where(m => m.IsDeleted == false).ToList();
            ViewBag.CountryId = _context.Countries.Where(m => m.IsDeleted == false).ToList();
            ViewBag.CategoryId = _context.Category.Where(m => m.IsDeleted == false).ToList();
            ViewBag.MatrealId = _context.Matreals.Where(m => m.IsDeleted == false).ToList();
            ViewBag.BrandId = _context.Brands.Where(m => m.IsDeleted == false).ToList();
            if (!ModelState.IsValid)
            {
                return View(futniture);
            }
            
            if(futniture.SalePrice<0)
            {
                ModelState.AddModelError("SalePrice", "Satış qiyməti mənfi ola bilməz");
                return View(futniture);
            }
            if (futniture.CostPrice < 0)
            {
                ModelState.AddModelError("CostPrice", "Alış qiyməti mənfi ola bilməz");
                return View(futniture);
            }
            if (futniture.Discount < 0)
            {
                ModelState.AddModelError("Discount", "Endirim faizi mənfi ola bilməz");
                return View(futniture);
            }
            futniture.FurnitureImages = new List<FurnitureImage>();
            if(futniture.MainImage==null)
            {
                ModelState.AddModelError("MainImage", "Əsas şəkil boş göndərilə bilməz");
                return View(futniture);
            }
            else
            {
                string fullname=await FileUtility.FileCreate(futniture.MainImage,_env.WebRootPath, @"assets\IMG\furnitures");
                if (Extensions.FileExtensions.IsOkay(futniture.MainImage, 1))
                {
                    FurnitureImage image = new FurnitureImage
                    {
                        Image = await FileUtility.FileCreate(futniture.MainImage, _env.WebRootPath, @"assets\IMG\furnitures"),
                        IsMain = true
                    };
                    futniture.FurnitureImages.Add(image);

                }
            }

            if (futniture.OtherImageFiles==null)
            {
                ModelState.AddModelError("OtherImageFiles", "Şəkil seçin!");
                return View(futniture);
            }
            
            else
            {
                foreach (var item in futniture.OtherImageFiles)
                {
                    if (Extensions.FileExtensions.IsOkay(item,1))
                    {
                        FurnitureImage image = new FurnitureImage
                        {
                            Image = await FileUtility.FileCreate(item, _env.WebRootPath, @"assets\IMG\furnitures"),
                            IsMain = false
                        };
                        if (futniture.FurnitureImages == null)
                        {
                            futniture.FurnitureImages = new List<FurnitureImage>();
                        }
                        futniture.FurnitureImages.Add(image);
                    }
                    
                }
            }

            _context.Add(futniture);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.ColorId = await _context.Colors.Where(m => m.IsDeleted == false).ToListAsync();
            ViewBag.CountryId = await _context.Countries.Where(m => m.IsDeleted == false).ToListAsync();
            ViewBag.CategoryId = await _context.Category.Where(m => m.IsDeleted == false).ToListAsync();
            ViewBag.MatrealId = await _context.Matreals.Where(m => m.IsDeleted == false).ToListAsync();
            ViewBag.BrandId = await _context.Brands.Where(m => m.IsDeleted == false).ToListAsync();
            Futniture futniture = await _context.Futnitures.Include(m => m.FurnitureImages).FirstOrDefaultAsync(x => x.Id == id);
            if (futniture == null) return NotFound();
            return View(futniture);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Futniture futniture, int id)
        {
            ViewBag.ColorId = await _context.Colors.Where(m => m.IsDeleted == false).ToListAsync();
            ViewBag.CountryId = await _context.Countries.Where(m => m.IsDeleted == false).ToListAsync();
            ViewBag.CategoryId = await _context.Category.Where(m => m.IsDeleted == false).ToListAsync();
            ViewBag.MatrealId = await _context.Matreals.Where(m => m.IsDeleted == false).ToListAsync();
            ViewBag.BrandId = await _context.Brands.Where(m => m.IsDeleted == false).ToListAsync();
            Futniture existedFurniture = await _context.Futnitures.Include(m => m.FurnitureImages).Include(m => m.Brand).Include(m => m.Matreal).Include(m => m.Color).Include(m => m.Category).Include(m => m.Country).FirstOrDefaultAsync(x => x.Id == id);
            if (existedFurniture == null) return NotFound();

            existedFurniture.FurnitureImages.RemoveAll(x => x.IsMain == true && !futniture.ProductImageIds.Contains(x.Id));
            if (futniture.MainImage != null)
            {
                if (futniture.MainImage.ContentType != "image/jpeg" && futniture.MainImage.ContentType != "image/png")
                {
                    ModelState.AddModelError("PosterImage", "Şəklin formatı düzgün deyil!");
                    return View();
                }
                if (futniture.MainImage.Length > 2097152)
                {
                    ModelState.AddModelError("PosterImage", "Şəklin ölçüsü 2mb dan artıq ola bilməz!");
                    return View();
                }
                FurnitureImage posterImage = _context.FurnitureImages.Where(x => x.FutnitureId == futniture.Id).FirstOrDefault(x => x.IsMain == true);
                string filename = await FileUtility.FileCreate(futniture.MainImage, _env.WebRootPath, @"assets\IMG\furnitures");
                if (posterImage == null)
                {
                    posterImage = new FurnitureImage
                    {
                        IsMain = true,
                        Image = filename,
                        FutnitureId = futniture.Id
                    };
                    await _context.FurnitureImages.AddAsync(posterImage);
                }
                else
                {
                    FileUtility.FileDelete(_env.WebRootPath, @"assets\IMG\furnitures", posterImage.Image);
                    posterImage.Image = filename;
                }
            }

            existedFurniture.FurnitureImages.RemoveAll(x => x.IsMain == false && !futniture.ProductImageIds.Contains(x.Id));
            if (futniture.OtherImageFiles != null)
            {
                foreach (var item in futniture.OtherImageFiles)
                {
                    if (Extensions.FileExtensions.IsOkay(item, 1))
                    {
                        FurnitureImage image = new FurnitureImage
                        {
                            Image = await FileUtility.FileCreate(item, _env.WebRootPath, @"assets\IMG\furnitures"),
                            IsMain = false
                        };
                        if (existedFurniture.FurnitureImages == null)
                        {
                            existedFurniture.FurnitureImages = new List<FurnitureImage>();
                        }
                        existedFurniture.FurnitureImages.Add(image);
                    }

                }
            }

            _context.Entry(existedFurniture).CurrentValues.SetValues(futniture);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Delete(int id)
        {
            Futniture futniture = await _context.Futnitures.Include(x=>x.FurnitureImages).FirstOrDefaultAsync(x=>x.Id==id);
            foreach (var item in futniture.FurnitureImages)
            {


                FileUtility.FileDelete(_env.WebRootPath, @"assets\IMG\furnitures", item.Image);

            };
            if (futniture == null) return NotFound();
            _context.Futnitures.Remove(futniture);
            await _context.SaveChangesAsync();
            return RedirectToAction("index");
        }

        public async Task<IActionResult> Detail(int id)
        {
            ViewBag.ColorId = _context.Colors.Where(m => m.IsDeleted == false).ToList();
            ViewBag.CountryId = _context.Countries.Where(m => m.IsDeleted == false).ToList();
            ViewBag.CategoryId = _context.Category.Where(m => m.IsDeleted == false).ToList();
            ViewBag.MatrealId = _context.Matreals.Where(m => m.IsDeleted == false).ToList();
            ViewBag.BrandId = _context.Brands.Where(m => m.IsDeleted == false).ToList();
            Futniture furniture = await _context.Futnitures.Include(m => m.FurnitureImages).Include(m => m.Brand).Include(m=>m.Matreal).Include(m => m.Color).Include(m => m.Category).Include(m => m.Country).FirstOrDefaultAsync(x => x.Id == id);
            return View(furniture);
        }
    }
}
