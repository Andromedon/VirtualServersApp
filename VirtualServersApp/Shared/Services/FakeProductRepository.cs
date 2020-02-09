using System;
using System.Collections.Generic;
using System.Linq;
using VirtualServersApp.Shared.Models;

namespace VirtualServersApp.Shared.Services {

    public class FakeProductRepository : IProductRepository {

        private List<Product> _products = new List<Product> {
            new Product { Id = 1, Amount = 1, Price = 15, ProductTypeId = 1},
            new Product { Id = 2, Amount = 3, Price = 40, ProductTypeId = 1},
            new Product { Id = 3, Amount = 5, Price = 60, ProductTypeId = 1},
            new Product { Id = 4, Amount = 10, Price = 100, ProductTypeId = 1},

            new Product { Id = 5, Amount = 1, Price = 0, ProductTypeId = 2},
            new Product { Id = 6, Amount = 3, Price = 20, ProductTypeId = 2},
            new Product { Id = 7, Amount = 5, Price = 35, ProductTypeId = 2},
            new Product { Id = 8, Amount = 10, Price = 50, ProductTypeId = 2}
        };



        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public Product Get(int id) {
            return _products.SingleOrDefault(p => p.Id == id);
        }

        public List<Product> GetList() {
            return _products;
        }

        public void Insert(Product value) {
            throw new NotImplementedException();
        }

        public void Update(Product value) {
            throw new NotImplementedException();
        }
    }
}