using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEcommerce2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Home Page";

            return View();
        }


        public IActionResult About()
        {
            ViewBag.Message = "About Page";

            return View();
        }

        public IActionResult Services()
        {
            ViewBag.Message = "Services Page";

            return View();
        }

        public IActionResult Detail(int id)
        {

            return View();
        }
    }
}
