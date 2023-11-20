using Crud_Asp_Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_Asp_Mvc.Controllers
{
    public class StudentController : Controller
    {
        StudentDBDataContext db = new StudentDBDataContext();
        // GET: Student
        public ActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {
            db.Students.InsertOnSubmit(s);
            db.SubmitChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var std = db.Students.Single(x => x.Id == id);
            return View(std);
        }
        [HttpPost]
        public ActionResult Edit(int id,Student s)
        {
            Student std = db.Students.Single(x => x.Id == id);
            std.Name = s.Name;
            std.Age = s.Age;
            std.Std = s.Std;
            db.SubmitChanges();          
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var stds = db.Students.Single(x => x.Id == id);

            return View(stds);
        }
        [HttpPost]
        public ActionResult Delete(int id,Student s)
        {
            var std = db.Students.Single(x => x.Id == id);
            db.Students.DeleteOnSubmit(std);
            db.SubmitChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var std1 = db.Students.Single(x => x.Id == id);
            return View(std1);
        }

    }
}