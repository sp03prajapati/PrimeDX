using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{
    public interface Machine
    {
        void Car();
    }
    public class TATASumo : Machine
    {
        public void Car()
        {
            Console.WriteLine("This is a Tata Sumo.");
        }
    }
    public class Suzuki : Machine
    {
        public void Car()
        {
            Console.WriteLine("This is a Suzuki!!!");
        }
    }
        

    class InterFaceDemo
    {
        static void Main(string[] args)
        {
            TATASumo T = new TATASumo();
            T.Car();

            Suzuki s = new Suzuki();
            s.Car();
        }
    }
}
