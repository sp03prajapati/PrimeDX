using Microsoft.AspNetCore.Mvc;
using Online_Store.Models;
using Online_Store.Repository;
using System.Diagnostics;

namespace Online_Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CustomerRepository _customerRepository = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _customerRepository = new CustomerRepository();
        }
        public  List<CustomerMode> GetAllCustomers() 
        {
            return _customerRepository.GetAllCustomer();
        }
        public CustomerMode GetById(int id)
        { 
            return _customerRepository.getCustomerById(id);
        }


        public IActionResult Index()
        {
            // List<CustomerMode> customers = _customerRepository.GetAllCustomer();
            // ViewBag.test = customers;

            //CustomerMode cust = new CustomerMode()
            //{
            //    Customer_Id = 101,
            //    Customer_Name = "sp",
            //    Customer_Age = 30,
            //    Customer_Description = "We Are Make New Idea."
            //};
            ////ViewData["data"] = cust;
            //TempData["data"] = cust;



            var MyCustomer = new List<CustomerMode>
                {
                     new CustomerMode{ Customer_Id = 1,Customer_Name ="sp",Customer_Age=25,Customer_Description="We are Brave"},
                     new CustomerMode{ Customer_Id = 2,Customer_Name ="santosh",Customer_Age=29,Customer_Description="We are happy"},
                     new CustomerMode{ Customer_Id = 3,Customer_Name ="soham",Customer_Age=10,Customer_Description="We are honest"}
                };
            //ViewData["data"] = MyCustomer;
            return View(MyCustomer);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //public IActionResult Index()
        //{
        //    var Cust = new List<CustomerMode>
        //    {
        //         new CustomerMode { Id = 1,Name = "shailesh",Age = 27 },
        //         new CustomerMode { Id = 2,Name = "Santosh",Age = 29 },
        //         new CustomerMode { Id = 3,Name = "Sani",Age = 22 },
        //         new CustomerMode { Id = 4,Name = "Ravi",Age = 20 },
        //         new CustomerMode { Id = 5,Name = "Gattu",Age = 18 },
        //         new CustomerMode { Id = 6,Name = "Soham",Age = 9 }
        //    };

        //    ViewBag.Custo = Cust;

        //    //ViewData["data1"] = "Hello Dostar";
        //    //ViewData["data2"] = "26";
        //    //ViewData["data3"] = DateTime.Now.ToLongDateString();
        //    //ViewData["Title1"] = "spdop";
        //    //string[] arrok = { "shailesh", "santosh", "Gokul" };
        //    //ViewData["data4"] = arrok;
        //    //ViewData["data5"] = new List<string>()
        //    //{
        //    //     "cricket","football","Hockey"
        //    //};


        //    //ViewBag.Dox1 = "Ocean"; DateTime.Now.ToLongDateString(); ;
        //    //ViewBag.Dox2 = 26;
        //    //ViewBag.Dox3 = new List<string>()
        //    //{
        //    //        "Air","Fire","water"
        //    //};

        //    return View();
        //}
    }
}