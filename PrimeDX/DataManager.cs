using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX.linq
{
    internal class Employee 
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int std { get; set; }
    }

    internal static class DataManager
    {
        internal static List<Employee> GetData()
        {
            return new List<Employee>
           {
             new Employee { ID = 1, FirstName = "shailesh",LastName = "Prajapti",Age = 26, std = 12},
             new Employee { ID = 2, FirstName = "santosh" ,LastName = "Prajapti",Age = 29, std = 10},
             new Employee { ID = 3, FirstName = "jeet"    ,LastName = "Prajapti",Age = 18, std = 9},       
             new Employee { ID = 4, FirstName = "shailesh",LastName = "Ahir",Age = 26, std = 5},       
             new Employee { ID = 5, FirstName = "Ravi"    ,LastName = "Prajapti",Age = 20, std = 5}       
           };
        }
    }
}
