using Microsoft.AspNetCore.Mvc;
using MultipleBindModel6.Models;

namespace MultipleBindModel6.Controllers
{
    public class DynamicPartialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductPage()
        {
            List<ProductModel> products = new List<ProductModel>()
            {
                 new ProductModel() { Id = 1, Name = "Reebok Shoes", Description ="Safe and Comfortable as walking and running.", Price= 850.20, Image ="~/Images/Reebok_photo.jpg"},
                 new ProductModel() { Id = 2, Name = "Gram_Warthy_Chasma", Description ="It's very good qaulity and smooth wearing as traveling and Drive Bike.", Price= 450.45, Image ="~/Images/Chasma_Gram_warthy_2022.jpg"},
                 new ProductModel() { Id = 3, Name = "Nike cap", Description ="It has to wear cap to protect haeavy sunlight and safe for your good life.", Price= 200.2, Image ="~/Images/pexels-aman-jakhar-1124465.jpg"}
            };
            return View(products);
        }
    }
}
