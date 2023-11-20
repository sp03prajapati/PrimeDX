using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{

    class ExampleDemo
    {
        string Name;
        int Age;

        public ExampleDemo(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public ExampleDemo(ExampleDemo e)
        {
            this.Name = e.Name;
            this.Age = e.Age;
        }

        public void Getdata()
        {
            Console.WriteLine("My Name is {0} and I am {1} Year Old. : ", Name, Age);
        }
    }


    class CopyConstructorDemo
    {
        static void Main(string[] args)
        {
            ExampleDemo obj = new ExampleDemo("shailesh",26);
            
            obj.Getdata();

            ExampleDemo obj1 = new ExampleDemo(obj);
            obj1.Getdata();
            Console.ReadLine();
        }
    }
}
