using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PrimeDX
{
    public class ListDemo
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Mr.Shailesh, Dont't Worry you will be go to the right path.");

            Console.WriteLine("--------------------------------------------------------------");

            string greeting;

            //double dbldata = 1.5;
            //int intdbl = (int)dbldata;

            //Console.WriteLine(dbldata);
            //Console.WriteLine(intdbl);

            //Console.WriteLine("Enter UserName : ");

            //string getdata = Console.ReadLine();

            //Console.WriteLine("This is the Output :" + getdata);

            //Console.WriteLine("Enter teh Age : ");

            //string getdata = Console.ReadLine();

            //int temp = Convert.ToInt32(getdata);
            //Console.WriteLine("This is the Output :" + temp);



            //string gift = "Gift For you";

            //Console.WriteLine(gift);

            //Console.WriteLine(gift.Length);
            //Console.WriteLine(gift.ToUpper());
            //Console.WriteLine(gift.ToLower());


            //string fname = "shailesh";
            //string lname = "prajapati";
            //string fullname = fname + " " + lname;
            //Console.WriteLine(fullname);

            //string name2 = string.Concat(fname, lname);
            //Console.WriteLine(name2);


            ////string interplation
            //string xfname = "Dino";
            //string xlname = "James";
            //string xname = $"ny full name : {xfname} {xlname} ";
            //Console.WriteLine(xname);


            //greeting = "hellow";
            //Console.WriteLine(greeting[1]);

            //Console.WriteLine(greeting.IndexOf("h"));


            //for (int i = 0; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i == 5)
            //    {
            //        continue;
            //    }
            //}

            string[] cars = { "valvo", "bmw", "aston martin" };
            Console.WriteLine(cars[1]);

            string[] cars2 = new string[3] { "valvo", "bmw", "aston martin" };

        }
    }
}












//static void Main(string[] args)
//{
//    Console.WriteLine("Hello Mr.Shailesh, Dont't Worry you will be go to the right path.");

//    Console.WriteLine("--------------------------------------------------------------");


//    Dictionary<int, string> dic = new Dictionary<int, string>();

//    dic.Add(1, "Hello");
//    dic.Add(10, "World");
//    dic.Add(12, "Orange");

//    //dic.Remove(1);


//    //if (dic.TryGetValue(10,out string value))
//    //    Console.WriteLine(value);
//    //else
//    //    Console.WriteLine("false");

//    dic[1] = "deno";
//    dic[2] = "James";

//    foreach (var item in dic)
//        Console.WriteLine(item);


//}




//static void Main(string[] args)
//{
//    Console.WriteLine("Hello Mr.Shailesh, Dont't Worry you will be go to the right path.");

//    Console.WriteLine("--------------------------------------------------------------");

//    List<string> arrlst = new List<string>();
//    //arrlst.Add(1);
//    arrlst.Add("Hey");
//    //arrlst.Add(true);

//    List<string> fruits = new List<string>();
//    {
//        fruits.Add("Mango");
//        fruits.Add("Bitroot");
//        fruits.Add("Sweet Potato");
//        fruits.Add("cherry");
//        fruits.Add("lemon");
//        fruits.Add("Bitroot");

//    };

//    arrlst.AddRange(fruits);

//    //Console.WriteLine(arrlst.Capacity);
//    //Console.WriteLine(arrlst.Count);

//    //arrlst.Insert(0, "Banana");

//    //arrlst[0] = "Tomato";

//    //arrlst.Remove("Cherry");
//    //arrlst.RemoveAt(1);

//    if (arrlst.Contains("cherry"))
//    { Console.WriteLine("True"); }
//    else
//    { Console.WriteLine("False"); }


//    arrlst.Clear();
//    foreach (string o in arrlst)
//    {
//        Console.WriteLine(o);
//    }


//    //ArrayList arrlst = new ArrayList();
//    //arrlst.Add(1);
//    //arrlst.Add("Hey");
//    //arrlst.Add(true);

//    //foreach (Object o in arrlst)
//    //{ 
//    //   Console.WriteLine(o);
//    //} 



//}