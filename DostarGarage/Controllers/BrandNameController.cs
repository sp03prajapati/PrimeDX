using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DostarGarage.Models;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Configuration;

namespace DostarGarage.Controllers
{
    public class BrandNameController : Controller
    {
        // GET: BrandName
        public ActionResult BrandList()
        {
            return View();
        }

        [HttpGet]
        public JsonResult BrandListName()
        {
            string csdb = ConfigurationManager.ConnectionStrings["cardbms"].ConnectionString;
            SqlConnection cox = null;

            try
            {
                using (cox = new SqlConnection(csdb))
                {
                    List<BrandNameMode> namelist = new List<BrandNameMode>();
                    string queryy = "select * from Car_Name_List";
                    SqlDataAdapter sda = new SqlDataAdapter(queryy, cox);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        namelist.Add(new BrandNameMode
                        {
                            id = Convert.ToInt32(row["id"]),
                            BrandName = row["BrandName"].ToString(),
                            Model = row["Model"].ToString()                            
                        });
                        
                    }
                    return Json(namelist, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(ex,JsonRequestBehavior.AllowGet);
                //throw;
            }
        }

        [HttpGet]
        public JsonResult GetdataList()
        {
            try
            {
                List<CarPart> carpartlst = new List<CarPart>();

                DataTable car = new DataTable("car");
                DataColumn id = new DataColumn("id");
                id.Caption = "CarID";
                id.DataType = typeof(int);
                id.AllowDBNull = false;
                car.Columns.Add(id);

              
                DataColumn name = new DataColumn("name");
                name.Caption = "Car_Name";
                name.DataType = typeof(string);
                name.AllowDBNull = false;
                name.MaxLength = 50;
                car.Columns.Add(name);


                DataRow row1 = car.NewRow();
                row1["id"] = 1;
                row1["name"] = "shailesh";
                car.Rows.Add(row1);

                car.Rows.Add(2, "santosh");
                //car.Rows.Add(2, "jatin");

                car.PrimaryKey = new DataColumn[] { id };
                foreach (DataRow row in car.Rows)
                {
                    carpartlst.Add(new CarPart
                    {
                        id = Convert.ToInt32(row["id"]),
                        Name = row["Name"].ToString()
                    });


                    return Json(new { data = carpartlst }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {

                return Json(ex.Message,JsonRequestBehavior.AllowGet);
            }

            return Json(new { data = "Error."},JsonRequestBehavior.AllowGet);

        }
    }
}