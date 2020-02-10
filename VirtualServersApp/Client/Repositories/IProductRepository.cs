using System.Collections.Generic;
using VirtualServersApp.Shared.Entities;

namespace VirtualServersApp.Client.Repositories {

    public interface IProductRepository {

        void Insert(Product value);

        Product Get(int id);

        List<Product> GetList();

        void Delete(int id);

        void Update(Product value);
    }
}