using CodeFirstApproachCore6.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodeFirstApproachCore6.Controllers
{
    public class ManagerController : Controller
    {
        private readonly ManagerDBContext managerContext;

        public ManagerController(ManagerDBContext managerContext)
        {
            this.managerContext = managerContext;
        }

        private ManagerModel BindDDL()
        {
            ManagerModel manager = new ManagerModel();
            manager.ManagerList = new List<SelectListItem>();

            var Managerdata = managerContext.Managers.ToList();

            manager.ManagerList.Add(new SelectListItem
            {
                Text = "Select City",
                Value = "",
            });
            foreach (var item in Managerdata)
            {
                manager.ManagerList.Add(new SelectListItem
                {
                    Text = item.City,
                    Value = item.Id.ToString(),
                });
            }
            return manager;
        }
        public IActionResult Index()
        {
            var std = BindDDL();
            return View(std);
        }
        [HttpPost]
        public IActionResult Index(ManagerModel managr) 
        {
            var Mdata = managerContext.Managers.Where(x => x.Id == managr.Id).FirstOrDefault();
            if (Mdata != null)
            {
                ViewBag.selectedvalue = Mdata.City;
            }
            var Mymanager = BindDDL();
            return View(Mymanager);
            //return RedirectToAction("Index");

        }
    }
}
