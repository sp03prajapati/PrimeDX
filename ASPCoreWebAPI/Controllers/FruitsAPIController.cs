using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsAPIController : ControllerBase
    {
        public List<string> Fruits = new List<string>()
        {
              "Apple",
              "Watermelon",
              "Mango",
              "Cherry",
              "Lemon",
              "Grapes",
              "Banana",
              "Coconut",
              "DargonFruit",
              "Oranges"
        };
        [HttpGet]
        public List<string> GetFruits()
        {
            return Fruits;
        }

        [HttpGet("{id}")]
        public string GetFruitsByIndex(int id)
        {
            if (id < 10)
            {
                return Fruits.ElementAt(id);
            }
            else
            {
                return "Data Not Found";
            }
            
        }
    }
}
