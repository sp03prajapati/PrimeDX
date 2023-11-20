using AspDotCoreSessionRun.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace AspDotCoreSessionRun.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("MyKey", "PrimeOcean");
            TempData["sessionid"] = HttpContext.Session.Id;
            return View();
        }
        public IActionResult About()
        {
            if (HttpContext.Session.GetString("MyKey") != null)
            {
                ViewBag.Test = HttpContext.Session.GetString("MyKey").ToString();
            }
            return View();
        }
        public IActionResult Details()
        {
            if (HttpContext.Session.GetString("MyKey") != null)
            {
                ViewBag.Test = HttpContext.Session.GetString("MyKey").ToString();
            }
            return View();
        }

        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("MyKey") != null)
            {
               HttpContext.Session.Remove("MyKey");
            }   
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}