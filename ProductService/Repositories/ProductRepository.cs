using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductService.Models;

namespace ProductService.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductDbContext _context;
        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }
        public void AddProduct(Products prod)
        {
            _context.Products.Add(prod);
            _context.SaveChanges();
        }

        public void DeleteProduct(int prodId)
        {
            Products prod=_context.Products.Find(prodId);
            _context.Products.Remove(prod);
            _context.SaveChanges();
        }

        public List<Products> GetProducts(int userId)
        {
            return _context.Products.Where(e => e.UserId == userId).ToList();
        }

        public void UpdateProduct(Products prod)
        {
            _context.Products.Update(prod);
            _context.SaveChanges();
        }
    }
}
