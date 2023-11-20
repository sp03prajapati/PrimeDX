using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{
    public class EmployeeData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    public class EmployeeMgmt
    {
        private List<EmployeeData> ListEmployeeData;

        public EmployeeMgmt()
        {
            ListEmployeeData = new List<EmployeeData>();
            ListEmployeeData.Add(new EmployeeData { ID = 1, Name = "shailesh", Gender = "Male" });
            ListEmployeeData.Add(new EmployeeData { ID = 2, Name = "santosh", Gender = "Male" });
            ListEmployeeData.Add(new EmployeeData { ID = 3, Name = "ravi", Gender = "Male" });
            ListEmployeeData.Add(new EmployeeData { ID = 4, Name = "sani", Gender = "Male" });
            ListEmployeeData.Add(new EmployeeData { ID = 5, Name = "jeet", Gender = "Male" });
            ListEmployeeData.Add(new EmployeeData { ID = 6, Name = "soham", Gender = "Male" });
            ListEmployeeData.Add(new EmployeeData { ID = 7, Name = "vani", Gender = "female" });
            ListEmployeeData.Add(new EmployeeData { ID = 8, Name = "khushi", Gender = "female" });
            ListEmployeeData.Add(new EmployeeData { ID = 9, Name = "kanak", Gender = "female" });

        }
        //Indexers
        public string this[int empid]
        {
            set
            {
                ListEmployeeData.FirstOrDefault(x => x.ID == empid).Name = value;
            }
            get 
            {
               return  ListEmployeeData.FirstOrDefault(x => x.ID == empid).Name;
            }
        }
    }
    class IndexersDemo
    {
        static void Main(string[] args)
        {
            EmployeeMgmt obj = new EmployeeMgmt();
            Console.WriteLine("Name Of Employee: " + obj[1]);
            Console.WriteLine("Press any key to enter:");
            Console.ReadLine();
        }
    }
}
