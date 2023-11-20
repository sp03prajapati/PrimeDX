using Crud_Asp_Mvc.Models;
using Crud_Asp_Mvc.Models.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_Asp_Mvc.Controllers
{
    public class EmployeeDataController : Controller
    {
        // GET: EmployeeData
        public ActionResult Index()
        {
            EmployeeDBContext db = new EmployeeDBContext();
            List<Employees> obj = db.GetEmployee();
            return View(obj);
        }

        public ActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employees emp)
        {
            try
            {
                if (ModelState.IsValid == true)
                {
                    EmployeeDBContext context = new EmployeeDBContext();
                    bool check = context.AddEmployee(emp);
                    if (check == true)
                    {
                        TempData["InsertMessage"] = "Data has been Insert Successfully!!.   ";
                        ModelState.Clear();
                        return RedirectToAction("Index");
                    }
                }
                return View();
            }
            catch (Exception ex)
            {

                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            EmployeeDBContext context = new EmployeeDBContext();
            var row = context.GetEmployee().Find(model => model.Employee_ID == id);
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(int id,Employees emp)
        {
            if (ModelState.IsValid == true)
            {
                EmployeeDBContext context = new EmployeeDBContext();
                bool check = context.UpdateEmployee(emp);
                if (check == true)
                {
                    TempData["UpdateMessage"] = "Data has been Updated Successfully!!.   ";
                    ModelState.Clear();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            EmployeeDBContext context = new EmployeeDBContext();
            var row = context.GetEmployee().Find(model => model.Employee_ID == id);
            return View(row);
        }
  

        [HttpPost]
        public ActionResult Delete(int id, Employees emp)
        {
            EmployeeDBContext context = new EmployeeDBContext();
            bool check = context.DeleteEmployee(id);
            if (check == true)
            {
                TempData["DeleteMessage"] = "Data has been Deleted Successfully!!.   ";
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            EmployeeDBContext context = new EmployeeDBContext();
            var row = context.GetEmployee().Find(model => model.Employee_ID == id);
            return View(row);
        }

    }
}