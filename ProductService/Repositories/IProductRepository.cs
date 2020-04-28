using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductService.Models;
namespace ProductService.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Products product);
        List<Products> GetProducts(int userId);
        void UpdateProduct(Products product);
        void DeleteProduct(int productId);
    }
}
