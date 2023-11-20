using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDX
{
    static class Product
    {
        public static int ProductId;
        public static string ProductName;
        public static int ProductPrice;
        static Product()
        {
            ProductId = 120;
            ProductName = "Watch";
            ProductPrice = 5000;
        }
        public static void GetProductDetails()
        {
            Console.WriteLine("Product Id = {0} ",ProductId);
            Console.WriteLine("Product Name = {0} ", ProductName);
            Console.WriteLine("Product Price = {0} ", ProductPrice);
            Console.WriteLine("-----------------------------------------------------");
        }
        public static void GetDiscount()
        {
            int d_amount = ProductPrice / 10;
            Console.WriteLine("Your discount amount is: {0}",d_amount);
            Console.WriteLine("Total cost Product is: {0}",(ProductPrice - d_amount));
        }
    }
    class StaticDemo
    {
        //Main Method
        public static void Main(string[] args)
        {
            Product.GetProductDetails();
            Product.GetDiscount();
            Console.ReadLine();
        }
    }
}
