using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sale_Street.Models;
using Sale_Street.ViewModels;
using static System.Net.Mime.MediaTypeNames;

namespace Sale_Street.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly MyContext _context;
        private readonly UserManager<AppUser> _userManager;
        public ProductsController(MyContext context , UserManager<AppUser> userManager)
        {
           
            _context = context;
            _userManager = userManager;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            
                List<Product> products;
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                if (await _userManager.IsInRoleAsync(user, "admin"))
                {
                     products = await _context.Products.ToListAsync();
                }
                else
                {
                    products = await _context.Products.
                        Where(p => p.publisher.Name == user.Name).ToListAsync();

                }




            return View(products);
        }

        // GET: Products/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.Include(p=>p.Images).Include(p=>p.publisher)
                .FirstOrDefaultAsync(m => m.id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

       
        // GET: Products/Create
        public IActionResult Create()
        {
            
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IEnumerable<IFormFile> images , CreateProductViewModel productViewModel)
       {
         
            if (ModelState.IsValid)
            {
                foreach (var formImg in images)
                {
                    ConvertImgToArr img = new ConvertImgToArr(formImg);
                    productViewModel.Images.Add(img);
                }

                var user = await _userManager.FindByNameAsync(User.Identity.Name); 
                productViewModel.publisher = await _userManager.FindByNameAsync(User.Identity.Name);
                Product product = new Product()
                {
                    Name = productViewModel.Name,
                    Category = _context.Categories.FirstOrDefault(c=>c.Name == productViewModel.CategoryName),
                    Images = productViewModel.Images,
                    Description = productViewModel.Description,
                    publisher = user,
                    price = productViewModel.price,
                    Location = productViewModel.Location,
                    publishedAt = productViewModel.publishedAt,
                    
                };
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productViewModel);
        }

        // GET: Products/Edit/5

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            bool ownsProduct ;
            if (User.IsInRole("Admin"))
            {
                ownsProduct= _context.Products.Any(p => p.id == id);
            }
            else
            {
                ownsProduct = user.Products.Any(p => p.id == id);

            }
            if (!ownsProduct)
            {
                return BadRequest();
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.id == id);
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult SearchBar(string keyword)
        {
            return RedirectToAction(nameof(Search), keyword);
        }
        [AllowAnonymous]

        public IActionResult Search(string keyword,int pageNum)
        {
            ViewData["page"] = pageNum;
            ViewData["keyword"] = keyword;
            var products =
                _context.Products.Where(
                    p => p.Name.ToLower().Contains(keyword.ToLower()) ||
                         p.Description.ToLower().Contains(keyword.ToLower()) ||
                         p.price.ToString().ToLower().Contains(keyword.ToLower()) ||
                         p.Location.ToLower().Contains(keyword.ToLower())).ToList();

            if (pageNum != 0)
            {
                products = products.Skip(pageNum * 3).Take(3).ToList();
            }
            else
            {
                products = products.Take(3).ToList();
            }
                   



            return View(products);
        }
    }
}
