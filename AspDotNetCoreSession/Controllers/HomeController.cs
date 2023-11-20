using AspDotNetCoreSession.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace AspDotNetCoreSession.Controllers
{
    public class HomeController : Controller
    {
        private readonly CarryZoneContext zoneContext;

        public HomeController(CarryZoneContext zoneContext)
        {
            this.zoneContext = zoneContext;
        }

        public IActionResult Login()   //Login nu View chhhe
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {          
                return RedirectToAction("Dashboard");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(Customer cost) //Login par click kare tayre calla ave.
        {
            var checkpass = zoneContext.Customers.Where(x => x.EmailId == cost.EmailId && x.Password == cost.Password && x.ConfirmPassword == cost.ConfirmPassword).FirstOrDefault();
            if (checkpass != null)
            {
                HttpContext.Session.SetString("UserSession", checkpass.EmailId);
                TempData["textmsg"] = "Success!";
                return RedirectToAction("Dashboard");
            }
            else
            { 
               ViewBag.Message = "Oppssss Login failed..!!  TRY Again..!";
            }
            return View();
        }
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                ViewBag.Mysession = HttpContext.Session.GetString("UserSession").ToString();
            }
            else
            {
                return RedirectToAction("Login");
            }
            return View();
        }       
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                HttpContext.Session.Remove("UserSession");
                return RedirectToAction("Login");
            }
          
            return View();
        }



        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Customer cust)
        {
            if (ModelState.IsValid)
            { 
                await zoneContext.Customers.AddAsync(cust);
                await zoneContext.SaveChangesAsync();
                TempData["success"] = "Resgietr Successfully..";
                return RedirectToAction("Login");
            }    
            return View();
        }

        public IActionResult Index()
        {
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