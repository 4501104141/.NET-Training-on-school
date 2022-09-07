using LAP01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LAP01.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowAll()
        {
            ViewData["Heading"] = "All Products";
            var products = new List<Product>();
            products.Add(new Product { ID = 101, Name = "IPad 2018", Price = 499 });
            products.Add(new Product { ID = 202, Name = "IPhone X", Price = 999 });
            products.Add(new Product { ID = 303, Name = "SS Note 9", Price = 1099 });
            return View(products);
        }
    }
}
