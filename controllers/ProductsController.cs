using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController :ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var products = new[]
             {
                new Product{ id= 1,category="laptop",name= "Dell", price= 75000, image= "/images/laptop.png", totalInventory=20, quantity=0 },
                new Product{ id= 2, category="phone", name= "Samsung", price= 25000, image= "/images/headphones.png" , totalInventory=20, quantity=0},
                new Product{ id= 3, category="phone", name= "iPhone", price= 60000, image= "/images/phone.png", totalInventory=20, quantity=0 },
                new Product{ id= 4, category="laptop", name= "HP", price= 75000, image= "/images/laptop.png" , totalInventory=20, quantity=0},
                new Product{ id= 5, category="electronic", name= "Washing machine", price= 30000, image= "/images/headphones.png" , totalInventory=20, quantity=0},
                new Product{ id= 6,category="electronic",  name= "Dish washer", price= 35000, image= "/images/phone.png", totalInventory=20, quantity=0 },
             };

            return Ok(products);
        }
    }
}