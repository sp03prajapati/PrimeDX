using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{
    class ExceptionHandleDemo
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine("Enter the One Digit...!");
            int j = Convert.ToInt32(Console.ReadLine());
            int Ans = 0;
            try
            {
                 Ans = i / j;
            }
            catch (Exception e)
            {

            Console.WriteLine("Divide By Zero not Allowed..");
            }
            Console.WriteLine(" Result is : " + Ans);
            Console.ReadLine();
        }
    }
}
