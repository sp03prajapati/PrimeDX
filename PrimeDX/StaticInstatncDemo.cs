using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{
        class Student
        {
           public int RollNo;
           public string Name;
           public int Standard;
           public static string School = "XYZ School";
 
            public void PrintFullName()
            {
                String fullname = this.RollNo + " " + this.Name;
                Console.WriteLine("Your RollNo and Name is  {0} ",fullname);
            }

        }   
    class StaticInstatncDemo
    {
        static void Main(string[] args)
        {
            Student Piyush = new Student();
            Piyush.RollNo = 20;
            Piyush.Name = "Piyush";
            Piyush.Standard = 11;
            

            Student Vinay = new Student();
            Vinay.RollNo = 25;
            Vinay.Name = "Vinay";
            Vinay.Standard = 12;

            Console.WriteLine(Piyush.RollNo);
            Console.WriteLine(Piyush.Name);
            Console.WriteLine(Piyush.Standard);
            Piyush.PrintFullName();
            Console.WriteLine(Student.School);

            Console.WriteLine("--------------------------------");
            Console.WriteLine(Vinay.RollNo);
            Console.WriteLine(Vinay.Name);
            Console.WriteLine(Vinay.Standard);
            Vinay.PrintFullName();
            Console.WriteLine(Student.School);
            Console.ReadLine();
        }
    }
}
