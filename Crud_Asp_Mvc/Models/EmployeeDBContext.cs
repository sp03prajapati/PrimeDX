using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Crud_Asp_Mvc.Models.Employee
{
    public class EmployeeDBContext
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcsNew"].ConnectionString;
        public List<Employees> GetEmployee()
        {
          

            List<Employees> EmployeeList = new List<Employees>();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("GetData_info", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Employees emp = new Employees();
                emp.Employee_ID = Convert.ToInt32(dr.GetValue(0).ToString());
                emp.Employee_FullName = (dr.GetValue(1).ToString());
                emp.Employee_Age = Convert.ToInt32(dr.GetValue(2).ToString());
                emp.Employee_Mobile = (dr.GetValue(3).ToString());
                emp.Employee_City = (dr.GetValue(4).ToString());
                emp.Employee_Salary = Convert.ToInt32(dr.GetValue(5).ToString());
                EmployeeList.Add(emp);
            }
            con.Close();

            return EmployeeList;
        }
        public bool AddEmployee(Employees emps)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Employee_Add_Data", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emp_fname", emps.Employee_FullName);
            cmd.Parameters.AddWithValue("@emp_age", emps.Employee_Age);
            cmd.Parameters.AddWithValue("@emp_mobile", emps.Employee_Mobile);
            cmd.Parameters.AddWithValue("@emp_city", emps.Employee_City);
            cmd.Parameters.AddWithValue("@emp_salary", emps.Employee_Salary);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            } 
        }

        public bool UpdateEmployee(Employees emps)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SpUpdateEmployee_Data", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emp_ID", emps.Employee_ID);
            cmd.Parameters.AddWithValue("@emp_fname", emps.Employee_FullName);
            cmd.Parameters.AddWithValue("@emp_age", emps.Employee_Age);
            cmd.Parameters.AddWithValue("@emp_mobile", emps.Employee_Mobile);
            cmd.Parameters.AddWithValue("@emp_city", emps.Employee_City);
            cmd.Parameters.AddWithValue("@emp_salary", emps.Employee_Salary);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteEmployee(int id)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SpDelete_Employee_Data", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emp_ID", id);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}