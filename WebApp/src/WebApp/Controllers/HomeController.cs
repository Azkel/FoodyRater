using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Header"] = "Hello world!";
            return View();
        }
        
        public IActionResult Error()
        {
            return View();
        }
    }
}
