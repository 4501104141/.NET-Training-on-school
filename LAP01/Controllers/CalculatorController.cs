using Microsoft.AspNetCore.Mvc;

namespace LAP01.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Calculate(double a1 = 0, double b = 0, char op = '+')
        {
            switch (op)
            {
                case '+':
                    ViewBag.KetQua = a1 + b;

                    break;
                case '-':
                    ViewBag.KetQua = a1 - b;
                    break;
                case 'x':
                    ViewBag.KetQua = a1 * b;

                    break;
                case ':':
                    ViewBag.KetQua = a1 / b;

                    break;

            }
            return View("Index");
        }
    }
}
