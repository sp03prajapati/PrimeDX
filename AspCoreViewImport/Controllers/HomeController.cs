using Microsoft.AspNetCore.Mvc;
using AspCoreViewImport.Models;

namespace AspCoreViewImport.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }    
        public IActionResult About()
        {
            
            return View();
        }   
        public int Contact(int id)
        {
            
            return id;
        }
    }
}

//List<Student> students = new List<Student>
//            {
//                 new Student { Student_Id = 2,Student_Name = "Santosh", Student_Gender = "Male" },
//                 new Student { Student_Id = 3,Student_Name = "Sani",    Student_Gender = "Male" },
//                 new Student { Student_Id = 4,Student_Name = "Ravi",    Student_Gender = "Male" },
//                 new Student { Student_Id = 1,Student_Name = "shailesh",Student_Gender = "Male" },
//                 new Student { Student_Id = 5,Student_Name = "Gattu",   Student_Gender = "Male" },
//                 new Student { Student_Id = 6,Student_Name = "Soham",   Student_Gender = "Male" }
//            };


