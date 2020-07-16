using System;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class HomeController : Controller // controller gibi hareket etmesi için kullanılıyor.
    {
        

        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Greeting = saat > 12 ? "iyi günler":"günaydın";
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}