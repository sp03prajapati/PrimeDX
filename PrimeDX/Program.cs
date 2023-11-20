using System;

namespace PrimeDX
{
    class Prime
    {
        //public string Name;  //   variable to store data  : also called attribute 
        //public int Number;

        //public void Bark()                  //method : function to perform spacific task
        //{
        //    Console.WriteLine("Bark Bark !!!!.");
        //}

        public string Employee_Name;
        public int Employee_Age;
        public string Employee_City;


        public void SetData(string name, int age,string city)
        {
            Employee_Name = name;
            Employee_Age = age;
            Employee_City = city;
        }

        public void getData()
        {
            Console.WriteLine("----------------Employee Final Submit-----------");

            Console.WriteLine(" Name : - {0} \n Age : - {1} \n City : - {2}",Employee_Name ,Employee_Age,Employee_City);
        }
    }

    class Doms
    {
        public string Username;
        public int Password;

        public void setinfo(string uname, int pass)
        {
            Username = uname;
            Password = pass;
        }

        public void checkuser()
         {
            if (Username == "shailesh" && Password == 123)
            {
                Console.WriteLine("Welcome {0}", Username);
            }
            else
            {
                Console.WriteLine("Incorrect Username and password!!!.");
            }
        }
    
    }


    class Program
    {
        static void Main(string[] args)
        {
         
            Prime D = new Prime();
            Doms DM = new Doms();
            //D.Name = "shailesh Prajapati";
            //D.Bark();
            //Console.WriteLine("Hello World!");
            //Console.WriteLine(" My Name is " + D.Name);

            //Console.Write("Enter your Name : -");
            //D.Employee_Name = Console.ReadLine();

            //Console.Write("Enter your Age : -");
            //D.Employee_Age = int.Parse(Console.ReadLine());

            //Console.Write("Enter your City : -");
            //D.Employee_City = Console.ReadLine();

            ////D.SetData("Shailesh", 26, "Valsad");

            //D.getData();


            Console.Write("Enter your UserName : -");
            string name = Console.ReadLine();
            Console.Write("Enter your Password : -");
            int Pass = int.Parse(Console.ReadLine());


            DM.setinfo(name,Pass);
            DM.checkuser();
        }
    }
}
