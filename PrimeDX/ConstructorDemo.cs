using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{
    class ConstructorDemo
    {
        public static int Age;
 
        static ConstructorDemo()
        {
            Age = 20;
            Console.WriteLine("Static Consructor is here...!!");
        }
        public static void AgeDisplay()
        {
            
            Console.WriteLine("Age Display : - " +  Age );
        }



        //Main method Start 

        static void Main(string[] args)
        {
            //ConstructorDemo CD = new ConstructorDemo();
            ConstructorDemo.AgeDisplay();
            Console.ReadLine();
        }
    }
}
