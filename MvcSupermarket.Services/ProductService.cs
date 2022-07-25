using MvcSupermarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcSupermarket.Services
{
    internal class ProductService : IProducService
    {
        static List<Product> _products = new List<Product>();
        public void Create(Product product)
        {
            if (product  != null)
            {
                _products.Add(product);
            }
        }

        public void Delete(int id) 
            => _products.RemoveAll(p => p.Id == id);

        public Product Get(int id)
            => _products.First(p => p.Id == id);

        public IEnumerable<Product> GetAll()
            => _products;

        public void Update(Product product)
        {
            Product? currentProduct = _products.FirstOrDefault(p => p.Id == product?.Id);
            int index = -1;
            if (currentProduct != null)
                index = _products.IndexOf(currentProduct);
            if (product != null)
                _products[index] = product;
        }
    }
}
