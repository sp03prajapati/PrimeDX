using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DostarGarage.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DostarGarage.Controllers
{
    public class AutoMotiveWorkController : Controller
    {
        // GET: AutoMotiveWork
        public ActionResult Index()
        {
            return View();
        }

       [HttpGet]
        public JsonResult CarInfo()
        {
            string cs = ConfigurationManager.ConnectionStrings["cardbms"].ConnectionString;
            SqlConnection con = null;
            //string status = "";
            try
            {
                using (con = new SqlConnection(cs))
                {
                    List<CarName> CarList = new List<CarName>();
                    string query = "select * from CarNameList";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //SqlCommand cmd = new SqlCommand();
                    //cmd.CommandText = query;
                    cmd.Connection = con;
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        CarList.Add(new CarName
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            FirstName = dr["firstname"].ToString(),
                            LastName = dr["lastname"].ToString(),
                            Salary = Convert.ToInt32(dr["Salary"])
                        });
                    }
                   // return Json(new { dataSrc = CarList }, JsonRequestBehavior.AllowGet);
                    return Json( CarList, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return Json(ex, JsonRequestBehavior.AllowGet);
                //throw;
            }
            finally
            {
                con.Close();
            }
        }
        public ActionResult Registration()
        {
            return View();
        }

        public JsonResult RegistrationSaveData(Register r)
        {
            string cs = ConfigurationManager.ConnectionStrings["cardbms"].ConnectionString;
            SqlConnection conn = null;
            try
            {
                using (conn = new SqlConnection(cs))
                {
                    string Insertquery = "insert into CarNameList values(@firstname,@lastname,@salary)";
                    SqlCommand cm = new SqlCommand(Insertquery, conn);
                    cm.Parameters.AddWithValue("@firstname", r.FirstName);
                    cm.Parameters.AddWithValue("@lastname", r.LastName);
                    cm.Parameters.AddWithValue("@salary", r.Salary);
                    conn.Open();
                    var test = cm.ExecuteNonQuery();
                    if (test > 0)
                    {
                       // return Json(new { data = "Data Has Been Insert Sucsessfully.!!!" }, JsonRequestBehavior.AllowGet);
                        return Json(test, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        //return Json(new { data = "Data Insertion failed..!!" }, JsonRequestBehavior.AllowGet);
                        return Json(test, JsonRequestBehavior.AllowGet);
                    }
                }
            }
            catch (Exception ex)
            {
                return Json(ex, JsonRequestBehavior.AllowGet);
            }
            finally
            {
                conn.Close();
            }
            
        }
    }
}