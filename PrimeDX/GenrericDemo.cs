using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{
    class GenericExample
    {
        public static void ShowArray<T>(T[] arr)
        {
            int i;
            for (i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    class GenericExample2
    {
        public static bool Check<T>(T a, T b)
        {
            bool c = a.Equals(b);  /* true and false Answare*/
            return c;

        }
        //public static void Check<T>(T a)
        //{
        //    Console.WriteLine(typeof(T));  


        //}

    }
    class GenrericDemo
    {
        static void Main(string[] args)
        {
            //int[] Number = new int[3];
            //Number[0] = 11;
            //Number[1] = 12;
            //Number[2] = 13;

            //string[] Name = { "vani", "navya", "Zeel" };
            //double[] valx = { 2.5, 5.6, 8.9 };

            //GenericExample.ShowArray(Number);
            //GenericExample.ShowArray(Name);
            //GenericExample.ShowArray(valx);

            Console.WriteLine(GenericExample2.Check(10, 10));
            Console.WriteLine(GenericExample2.Check("sp", "sp"));
            Console.WriteLine(GenericExample2.Check('s', 's'));


            //GenericExample2.Check("sasas");
            //GenericExample2.Check(12);
            //GenericExample2.Check(12.5);

            Console.ReadLine();
        }
    }
}
