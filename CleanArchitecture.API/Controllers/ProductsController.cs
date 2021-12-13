using CleanArchitecture.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productServices)
        {
            _productService = productServices;
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            var product = _productService.GetById(id);
            if(product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

    }
}
