using System;

namespace PrimeDX
{
    public class C1
    {
        public virtual void X1()
        {
            Console.WriteLine("This is Base Class");
        }
    }
    public class C2 : C1
    {
        public override void X1()
        {
            Console.WriteLine("This is Derived Class");
        }
    }
    class OverridingDemo
    {
        static void Main(string[] args)
        {
            C2 xd = new C2();
            xd.X1();
        }
    }
}
