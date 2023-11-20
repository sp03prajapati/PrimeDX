using Crud_Asp_Mvc.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_Asp_Mvc.Controllers
{
    
    public class DemoController : Controller
    {
 
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Data(string fname, string sname)
        {     
            try
            {
                SqlConnection con = new SqlConnection("data source = .;database = PrimeOcean;user ID= Shailesh.Temp ; password = pass@word");
                
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "InsertUserDetails";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = con;

                        cmd.Parameters.AddWithValue("@ffName", fname);

                        cmd.Parameters.AddWithValue("@uuName", sname);
                        
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                
                return Json("Congratulation Your Data Save Successfully.. " + "My Full Name is : " + fname + " " + sname, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                var test = ex;

                return Json(test, JsonRequestBehavior.AllowGet);
            }

                       
        }
    }
}