using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductService.Models;
namespace ProductService.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Products prod);
        List<Products> GetProducts(int userId);
        void UpdateProduct(Products prod);
        void DeleteProduct(int prodId);
    }
}
