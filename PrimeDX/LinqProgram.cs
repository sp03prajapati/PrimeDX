using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX.linq
{
    class LinqProgram
    {
       public static void Main(string[] args)
        {
            List<Employee> employees = DataManager.GetData();

            Console.WriteLine(employees.Any(e => e.Age > 30));
            Console.WriteLine(employees.Count(e => e.Age < 25));

            //Employee employee = employees.Take(x => x.FirstName == "shailesh");

            // if (employee != null)
            // {
            //     Console.WriteLine("ID : {0}, FirstName : {1}, LastName: {2}, Age : {3}, Std : {4}", employee.ID, employee.FirstName, employee.LastName, employee.Age, employee.std);
            // }
            // else
            // { 
            //     Console.WriteLine("Not found");
            // }



            // employees = employees.Where(e => e.Age > 25).ToList();


            // employees = employees.OrderBy(e => e.FirstName).ThenBy(e => e.LastName).ToList();

            //IEnumerable<string> names =  employees.Select(x => x.Name).Distinct();

            //foreach (string name in names)
            //{ 
            //    Console.WriteLine(name); 
            //}


            //employees.ForEach(Data => Console.WriteLine("ID : {0}, Name : {1}, Age : {2}, Std : {3}", Data.ID, Data.Name, Data.Age, Data.std));

            //foreach (Employee Data in employees)
            //{
            //    Console.WriteLine("ID : {0}, FirstName : {1}, LastName: {2}, Age : {3}, Std : {4}", Data.ID, Data.FirstName, Data.LastName, Data.Age, Data.std);
            //}
        }
    }
}
