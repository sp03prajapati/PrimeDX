using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{
    public class shop
    {
        public int CustomerID;
        public string CustomerName;
        public static int Count = 0;
        public shop(int CustomerID,string CustomerName)
        {
            this.CustomerID = CustomerID;
            this.CustomerName = CustomerName;

            Count++;
        }

        public void Display()
        {
            Console.WriteLine("CustomerID : " + CustomerID + " CustomerName : " + CustomerName);
        }
    
    }
    class staticKeywordDemo
    {
        static void Main(string[] args)
        {
            
            shop sp = new shop(111,"navya");
            shop sp1 = new shop(112,"Khushi");
            shop sp2 = new shop(113,"Vani");
            shop sp3 = new shop(114,"Soham");
            sp.Display();
            sp1.Display();
            sp2.Display();
            sp3.Display();
            Console.WriteLine("Total Customer Count is Here : - " + shop.Count);
            Console.ReadLine();
        }
    }
}
