using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{
    class ExtensionDemoFirst
    {

        public void Func1()
        {
            Console.WriteLine("This is an Func1..");
        }
        public  void Func2()
        {
            Console.WriteLine("This is an Func2..");
        }

        static void Main(string[] args)
        {
            ExtensionDemoFirst p = new ExtensionDemoFirst();
            p.Func1();
            p.Func2();
            Console.ReadLine();
        }
    }
}
