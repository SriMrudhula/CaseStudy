using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductService.Models;

namespace ProductService.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductDbContext productDbContext;
        public ProductRepository(ProductDbContext productDbContext)
        {
            this.productDbContext = productDbContext;
        }
        public void AddProduct(Products product)
        {
            productDbContext.Products.Add(product);
            productDbContext.SaveChanges();
        }

        public void DeleteProduct(int prodId)
        {
            Products product= productDbContext.Products.Find(prodId);
            productDbContext.Products.Remove(product);
            productDbContext.SaveChanges();
        }

        public List<Products> GetProducts(int userId)
        {
            return productDbContext.Products.Where(e => e.UserId == userId).ToList();
        }

        public void UpdateProduct(Products product)
        {
            productDbContext.Products.Update(product);
            productDbContext.SaveChanges();
        }
    }
}
