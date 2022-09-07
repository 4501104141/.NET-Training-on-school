using LAP01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LAP01.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new List<Product>();
        public IActionResult ShowAll()
        {
            return View("ShowAll", products);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create3([Bind("ID", "Name", "Price")] Product product)
        {
            //thêm vào danh sách
            products.Add(product);
            //gọi hiển thị danh sách
            return RedirectToAction("ShowAll");
        }
    }
}
