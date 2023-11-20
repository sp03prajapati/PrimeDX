using System;

namespace Partial_Class_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.FirstName = "Navya";
            std.LastName = "Prajapati";
            Console.WriteLine("Your Complete Name is : - " + std.GetCompleteName());
            Console.ReadLine();
        }
    }
}
