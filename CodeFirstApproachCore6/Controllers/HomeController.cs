using CodeFirstApproachCore6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CodeFirstApproachCore6.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDBContext studentdb;

        public HomeController(StudentDBContext studentdb)
        {
            this.studentdb = studentdb;
        }

        public async Task<IActionResult> Index()
        {
            var stddata = await studentdb.Students.ToListAsync();
            return View(stddata);
        }
       
        public IActionResult Create()
        {    
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student std)
        {
            if (ModelState.IsValid)
            {
               await studentdb.Students.AddAsync(std);
                await studentdb.SaveChangesAsync();
                TempData["insert_Success"] = "Inserted...";
                return RedirectToAction("Index","Home");
            }
         
            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || studentdb.Students == null)
            { 
               return NotFound();
            }
            var stddata = await studentdb.Students.FirstOrDefaultAsync(x => x.Id == id);

            if (stddata == null )
            {
                return NotFound();
            }
            return View(stddata);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || studentdb.Students == null)
            {
                return NotFound();
            }
            var stddata = await studentdb.Students.FindAsync(id);

            if (stddata == null)
            {
                return NotFound();
            }
            return View(stddata);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,Student std)
        {
            if (id != std.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                studentdb.Update(std);
                await studentdb.SaveChangesAsync();
                TempData["update_success"] = "Updated...";
                return RedirectToAction("Index", "Home");
            }
            return View(std);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || studentdb.Students == null)
            {
                return NotFound();
            }
            var stddata = await studentdb.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (stddata == null)
            {
                return NotFound();
            }
            return View(stddata);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id,Student std)
        {
            var stddata = await studentdb.Students.FindAsync(id);
            if (stddata != null)
            { 
               studentdb.Students.Remove(stddata);

            }
            await studentdb.SaveChangesAsync();
            TempData["delete_success"] = "Deleted...";
            return RedirectToAction("Index","Home");
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