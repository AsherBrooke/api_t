using CRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static public List<Product> Products = new List<Product>{

            new Product { Id = 1, Name = "CPU", Description = "CPU AMD 5", Price = 5000, DateTime = new DateTime (1999, 09, 17) },

            new Product { Id = 2, Name = "CPU", Description = "CPU AMD 5", Price = 5000, DateTime = new DateTime (1999, 09, 17) },

            new Product { Id = 3, Name = "CPU", Description = "CPU AMD 5", Price = 5000, DateTime = new DateTime (1999, 09, 17) },

            new Product { Id = 4, Name = "CPU", Description = "CPU AMD 5", Price = 5000, DateTime = new DateTime (1999, 09, 17) },

            new Product { Id = 5, Name = "CPU", Description = "CPU AMD 5", Price = 5000, DateTime = new DateTime (1999, 09, 17) },

        };

        [HttpGet]

        public ActionResult<List<Product>> GetAllProducts()
        {
            return Ok(Products);
        }



    }
}
