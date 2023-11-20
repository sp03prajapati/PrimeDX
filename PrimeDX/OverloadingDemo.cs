using System;

namespace PrimeDX
{
    class Demo
    {
        public void X1(int a)
        {
            Console.WriteLine(a + " This is X1");
        }
        public void X1(int a, int b)
        {
            Console.WriteLine((a + b) + " This is x1 two parameter");
        }
        public void X1(string a, string b)
        {
            Console.WriteLine("Name Is : " + (a + b));
        }

    }
    class OverloadingDemo
    {
        static void Main(string[] args)
        {
            Demo Dx = new Demo();
            Dx.X1(10);
            Dx.X1(10, 40);
            Dx.X1("shailesh", "Prajapati");
            Console.ReadLine();
        }
    }
}
