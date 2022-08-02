using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using taedisoft.Blazor.DataModels;

namespace taedisoft.Blazor.API.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("api/GetProducts")]
        public IActionResult GetProducts()
        {
            List<Product> productList = new()
            { 
                new() { Id = 1, Name = "Product 1", Brand = "Brand 1", Price = 1, Quantity = 1 },
                new() { Id = 2, Name = "Product 2", Brand = "Brand 2", Price = 2, Quantity = 2 },
                new() { Id = 3, Name = "Product 3", Brand = "Brand 3", Price = 3, Quantity = 3 },
                new() { Id = 4, Name = "Product 4", Brand = "Brand 4", Price = 4, Quantity = 4 },
                new() { Id = 5, Name = "Product 5", Brand = "Brand 5", Price = 5, Quantity = 5 },
            };

            return Ok(productList);
        }
    }
}
  