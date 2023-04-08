using Microsoft.AspNetCore.Mvc;
using CodeSimpleCrud.Data;
using CodeSimpleCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeSimpleCrud.Controllers
{
    public class ProductController : Controller
    {
        private readonly CodeSimpleContext _context;

        public ProductController(CodeSimpleContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> products = _context.Products.ToList();
            return View(products);
        }
        public IActionResult IndexAjax()
        {
            List<Product> products = _context.Products.ToList();
            return View(products);
        }

        //method to create a product
        [HttpGet]
        public IActionResult Create() 
        {
            Product prod = new Product();
            return View(prod);
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(string Id)
        {
            Product? prod  = _context.Products.Where(p => p.Code == Id).FirstOrDefault();
            return View(prod);
        }
        [HttpGet]
        public IActionResult Edit(string Id)
        {
            Product? prod = _context.Products.Where(p => p.Code == Id).FirstOrDefault();
            return View(prod);
        }
        [HttpPost]
        public IActionResult Edit(Product product) 
        {
            _context.Products.Update(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(string Id)
        {
            Product? prod = _context.Products.Where(p => p.Code == Id).FirstOrDefault();
            return View(prod);
        }
        [HttpPost]
        public IActionResult Delete(Product product) 
        {
            _context.Attach(product);
            _context.Entry(product).State= EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}
