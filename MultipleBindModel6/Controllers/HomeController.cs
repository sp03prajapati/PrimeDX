using Microsoft.AspNetCore.Mvc;
using MultipleBindModel6.Models;
using System.Diagnostics;

namespace MultipleBindModel6.Controllers
{
    public class HomeController : Controller
    {
      

        public IActionResult Index()
        {
            List<Student> std = new List<Student>
            {
                 new Student { Id = 1,Name = "Piyush",Gender = "male",Age=12,Standard = "8th" },
                 new Student { Id = 2,Name = "Soham",Gender = "male",Age=9,Standard = "4th" },
                 new Student { Id = 3,Name = "khushi",Gender = "female",Age=13,Standard = "9th" },
                 new Student { Id = 4,Name = "Vani",Gender = "female",Age=7,Standard = "2th" },
            };

            List<Teacher> teach = new List<Teacher>
            {
                 new Teacher { Id = 1,Name = "Piyush", Qualification = "MSC",Phone="8866456521",Salary = 12500 },
                 new Teacher { Id = 2,Name = "Soham",  Qualification = "B.ED",Phone="9913045785",Salary = 20500 },
                 new Teacher { Id = 3,Name = "khushi", Qualification = "B.COM",Phone="9727998855",Salary = 11000 },
                 new Teacher { Id = 4,Name = "Vani",   Qualification = "B.ed MSC",Phone="986578596",Salary = 25000 }
            };
            ViewSchoolModel vsm = new ViewSchoolModel()
            {
                   MyStudent = std,
                   MyTeachers = teach
            };
            return View(vsm);
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