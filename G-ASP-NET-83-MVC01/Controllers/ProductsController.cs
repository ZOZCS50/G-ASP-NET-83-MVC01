using G_ASP_NET_83_MVC01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace G_ASP_NET_83_MVC01.Controllers
{
    [Route("[controller]")]
    public class ProductsController:Controller
    {
        [HttpGet("getpros")]
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product(){Id = 1, Name = "P1", Price = 100},
                new Product(){Id = 2, Name = "P2", Price = 130},
                new Product(){Id = 3, Name = "P3", Price = 110},
            };
        }


    }
}
