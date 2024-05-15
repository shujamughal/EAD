using Generic_repostory_mvc_example.Models.Interfaces;
// ProductRepository.cs
using System.Collections.Generic;
using System.Linq;


namespace Generic_repostory_mvc_example.Models.Repositories
{
   

    public class ProductRepository : IRepository<Product>
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>();
        }

        public void Add(Product entity)
        {
            _products.Add(entity);
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product entity)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == entity.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = entity.Name;
                existingProduct.Price = entity.Price;
            }
        }

        public void Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }

}
