using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace PrimeDX
{
    class LinqDemo
    {
        static void Main(string[] args)
        {
            //int[] age = {12, 21, 29, 34, 78, 23, 45, 50, 96, 56, 35, 75 };
            //var data = from x in age where x > 30  orderby x descending select x;

            //foreach (int itemlist in data)
            //{
            //    Console.WriteLine(itemlist);
            //}

            string[] Data = { "shailesh", "santosh", "sani", "ravi", "jeet" };
            //var coll = from name in Data where name.Contains("o") select name;  
            var coll = from name in Data where name.StartsWith("s") select name;  

            foreach(string itemlist in coll)
            {
                Console.WriteLine(itemlist);
            }
        }
    }
}
