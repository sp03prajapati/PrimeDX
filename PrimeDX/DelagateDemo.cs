using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{

    public delegate void Calculation(int a, int b);
    class DelagateDemo
    {
        public static void Addition(int a, int b)
        {
            int Result = a + b;
            Console.WriteLine("Addditon is : {0}" ,Result);
        }


        static void Main(string[] args)
        {
            Calculation cal = new Calculation(DelagateDemo.Addition);
            cal.Invoke(10,50);
            Console.ReadLine();
        }
    }
}
