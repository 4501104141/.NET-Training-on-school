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
        [HttpPost]
        public IActionResult Create3([Bind("ID", "Name", "Price")] Product product)
        {
            //thêm vào danh sách
            products.Add(product);
            //gọi hiển thị danh sách
            return RedirectToAction("ShowAll");
        }

        public IActionResult Edit(int id)
        {
            Product p = products.SingleOrDefault(q => q.ID == id);
            if (p != null) //tìm thấy
            {
                return View(p);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public IActionResult Edit33(int id, [Bind("Id", "Name", "Price")] Product product)
        {
            //Sửa vào danh sách
            Product p = products.SingleOrDefault(q => q.ID == id);
            if (p != null) //tìm thấy
            {
                p.Name = product.Name;
                p.Price = product.Price;
            }
            //gọi hiển thị danh sách
            return RedirectToAction("ShowAll");
        }

        public IActionResult Delete33(int id)
        {
            //tìm Product cần xóa (dùng LINQ)
            Product p = products.SingleOrDefault(q => q.ID == id);
            if (p != null) //tìm thấy
            {
                products.Remove(p);
            }
            //gọi hiển thị danh sách
            return RedirectToAction("ShowAll");
        }

    }
}
