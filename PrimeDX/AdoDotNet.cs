using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PrimeDX
{
    class AdoDotNet
    {
        static void Connection()
        {
            string cs = "Data Source = DESKTOP-1T5ECI0; Initial Catalog=Ado_DB;User Id = Shailesh.Temp;Password=pass@word;";
            SqlConnection con = null;


            try
            {
                using (con = new SqlConnection(cs))
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        Console.WriteLine("Connection Has been Successfull.!");
                    }
                }
            }
            catch (SqlException ex)
            {

                Console.WriteLine(ex.Message); ;
            }
            finally
            {
                con.Close();
            }



        } 


        static void Main(string[] args)
        {
            AdoDotNet.Connection();
            Console.ReadLine();
        }
    }
}
