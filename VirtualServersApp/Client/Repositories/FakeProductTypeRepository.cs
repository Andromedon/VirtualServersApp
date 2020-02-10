using System;
using System.Collections.Generic;
using System.Linq;
using VirtualServersApp.Shared.Entities;

namespace VirtualServersApp.Client.Repositories {

    public class FakeProductTypeRepository : IProductTypeRepository {

        private static List<ProductType> _productTypes = new List<ProductType> {
            new ProductType { Id = 1, Name = "Server"},
            new ProductType { Id = 2, Name = "Online access"}
        };

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public ProductType Get(int id) {
            return _productTypes.SingleOrDefault(t => t.Id == id);
        }

        public List<ProductType> GetList() {
            return _productTypes;
        }

        public void Insert(ProductType value) {
            throw new NotImplementedException();
        }

        public void Update(ProductType value) {
            throw new NotImplementedException();
        }
    }
}