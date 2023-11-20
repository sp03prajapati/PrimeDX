using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{
    class PatternDesign
    {
        public static void Main(string[] args)
        {
            //int x,y;
            //for (x = 1; x <= 5; x++)
            //{
            //    for (y = 1; y <= x; y++)
            //    {
            //        Console.Write("*");
            //    }              
            //    Console.WriteLine();
            //}

            //int value = 5;
            //for (int x = 1; x <= value; x++)
            //{
            //    for (int y = 1; y <= value - x; y++)
            //    {
            //        Console.Write(" ");
            //    }
            //    //for (int z = 1; z <= x; z++)
            //    //{
            //    //    Console.Write("*");
            //    //}
            //    Console.WriteLine();
            //}


            //int count = 0;
            //for (int i = 1; i <= 4; i++) // i = 1
            //{

            //    for (int j = 1; j <= i; j++)   //  j = 1
            //    {
            //        count++;
            //        Console.Write(count);
            //    }

            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++) // i = 1
            //{
            //    for (int j = i; j <= 4; j++)   //  j = 1
            //    {
            //        Console.Write("- ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

           int n = 10;
            for (int i = 1; i <= n; i++) 
            {
                for (int j = 1; j <= n; j++)   
                {
                    if (i == n/2+1 || j == n / 2 + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
              
                Console.WriteLine();
            }

        }
    }
}
