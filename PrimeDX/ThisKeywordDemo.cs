using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{

    class School
    {
        public string Student;
        public string Teacher;
        public int StudentCount;


        public void members(string Student, string Teacher,int StudentCount)
        {
            this.Student = Student;
            this.Teacher = Teacher;
            this.StudentCount = StudentCount;
        }

        public void Display()
        {
            Console.WriteLine("Student Name is " + Student + " TeacherName " + Teacher + " Student Count " + StudentCount );
        }

    }
    class ThisKeywordDemo
    {
        static void Main(string[] args)
        {
            School scl = new School();
            scl.members("Gokul", "Sanjay", 99);
            scl.Display();
            Console.ReadLine();
        }
    }
}
