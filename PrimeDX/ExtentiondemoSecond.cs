using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{
    static class ExtentiondemoSecond
    {
        public static void Func3(this ExtensionDemoFirst p,int s)
        {
            Console.WriteLine("This is an Func3..." + s);
        }
    }
}
