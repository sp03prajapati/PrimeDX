using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{
    public abstract class X
    {
        public abstract void m1();
        public void m2()
        {
            Console.WriteLine("m2");
        }
    }
    class ab : X
    {
        public override void m1()
        {
            Console.WriteLine("m1");
        }

    }

    class AbstarctDemo
    {

        static void Main(string[] args)
        {

            ab dx = new ab();
            dx.m1();
            dx.m2();
            Console.ReadLine();
        }

    }
}
