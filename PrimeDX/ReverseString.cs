using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{
    class ReverseString
    {
        public static string Reverse(string Input)
        {
            char[] chararray = Input.ToCharArray();

            string reversedString = String.Empty;

            for (int i = chararray.Length-1; i >= 0; i--)
            {
                reversedString += chararray[i];
                
            }
            return reversedString;
        }

        static void Main(string[] args)
        {
            string teststring;
            Console.WriteLine("Enter text :-");
            teststring = Console.ReadLine();
            Console.WriteLine(Reverse(teststring));        
        }
    }
}
