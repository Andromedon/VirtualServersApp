using System.Collections.Generic;
using VirtualServersApp.Shared.Models;

namespace VirtualServersApp.Shared.Services {

    public interface IProductRepository {

        void Insert(Product value);

        Product Get(int id);

        List<Product> GetList();

        void Delete(int id);

        void Update(Product value);
    }
}