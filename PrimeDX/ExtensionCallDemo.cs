using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{
    class ExtensionCallDemo
    {
        static void Main(string[] args)
        {
            ExtensionDemoFirst EX = new ExtensionDemoFirst();
            EX.Func1();
            EX.Func2();
            EX.Func3(5);

            Console.ReadLine();
        }
    }
}
