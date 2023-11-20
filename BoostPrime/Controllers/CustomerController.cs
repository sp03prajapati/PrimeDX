using BoostPrime.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BoostPrime.Controllers
{
    public enum Gender { Male,Female };


    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            Employee employee = new Employee();
            employee.EmployeeList = new List<SelectListItem>();
            return View();
        }
    }
}



////Drop Dwon Code
//public class CustomerController : Controller
//{
//    public IActionResult Index()
//    {

//    }
//}