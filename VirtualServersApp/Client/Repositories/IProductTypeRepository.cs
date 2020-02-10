using System.Collections.Generic;
using VirtualServersApp.Shared.Entities;

namespace VirtualServersApp.Client.Repositories {

    public interface IProductTypeRepository {

        void Insert(ProductType value);

        ProductType Get(int id);

        List<ProductType> GetList();

        void Delete(int id);

        void Update(ProductType value);
    }
}