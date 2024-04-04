using Microsoft.AspNetCore.Mvc;

namespace PropertyProject.Controllers
{
    public class PropertyController : Controller
    {
        public IActionResult HomePage()
        {
            return View();
        }
        public IActionResult ForSale()
        {
            return View();
        }
        public IActionResult ForRent()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult PropertyNews()
        {
            return View();
        }
    }
}
