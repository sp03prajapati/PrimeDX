using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{
    class switchcashtest
    {
        public int one;
        public int two;

        public void setinfo(int number1,int number2)
        {
            one = number1;
            two = number2;
        }

        public void getinfo(int op)
        {
            switch (op)
            {
                case 1: Console.WriteLine("Two Digit Addition {0}",(one + two));
                break;
                case 2: Console.WriteLine("Two digit subtraction {1}",(one + two));
                break;
                default: Console.WriteLine("Please Enter Correct Input.!!!!");
                break;

            }
        }
    }


    class main
    {
        static void Main(string[] args)
        {
            switchcashtest sw = new switchcashtest();

            Console.WriteLine("Enter First/1 Value: -");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second/2 Value: -");
            int number2 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Choose any One Number:-");
            Console.WriteLine("1.Addition  2.Subtraction");
            int op = int.Parse(Console.ReadLine());

            sw.setinfo(number1, number2);

            sw.getinfo(op);



        }
    }



}
