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
        public IProductRepository _repo;
        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("GetProducts/{userId}")]
        public IActionResult GetProducts(int userId)
        {
            try
            {
                return Ok(_repo.GetProducts(userId));
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct(Products prod)
        {
            try 
            {
                _repo.AddProduct(prod);
                return Ok();
            }
            catch(Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        [HttpPut]
        [Route("UpdateProduct")]
        public IActionResult UpdateProduct(Products prod)
        {
            try
            {
                _repo.UpdateProduct(prod);
                return Ok();
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
    [HttpDelete]
    [Route("DeleteProduct/{prodId}")]
        public IActionResult DeleteProduct(int prodId)
        {
            try
            {
                _repo.DeleteProduct(prodId);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

    }
}