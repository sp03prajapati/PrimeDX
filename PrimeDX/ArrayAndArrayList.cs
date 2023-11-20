using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PrimeDX
{
    class ArrayAndArrayList
    {

        public static void Main(string[] args)
        {
            int[] arr = new int[2];    //style one

            arr[0] = 1;
            arr[1] = 15;
            

            // int[] array = { 10, 20, 30 };  // style three

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------------------------");

            ArrayList al = new ArrayList();
            al.Add("shailesh");
            al.Add(10);

            foreach (var names in al)
            {
                Console.WriteLine(names);
            }
        }
    }
}
