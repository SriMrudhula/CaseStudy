using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Repositories;
using ProductService.Models;


namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        public IProductRepository iProductRepository;
        public ProductController(IProductRepository iProductRepository)
        {
            this.iProductRepository = iProductRepository;
        }

        [HttpGet]
        [Route("GetProducts/{userId}")]
        public IActionResult GetProducts(int userId)
        {
            try
            {
                return Ok(iProductRepository.GetProducts(userId));
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct(Products product)
        {
            try 
            {
                iProductRepository.AddProduct(product);
                return Ok();
            }
            catch(Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        [HttpPut]
        [Route("UpdateProduct")]
        public IActionResult UpdateProduct(Products product)
        {
            try
            {
                iProductRepository.UpdateProduct(product);
                return Ok();
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
    [HttpDelete]
    [Route("DeleteProduct/{prodId}")]
        public IActionResult DeleteProduct(int productId)
        {
            try
            {
                iProductRepository.DeleteProduct(productId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

    }
}