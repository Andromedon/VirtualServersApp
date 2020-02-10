using System.Collections.Generic;
using VirtualServersApp.Shared.Entities;

namespace VirtualServersApp.Client.Repositories {

    public interface IOrderRepository {

        void Insert(Order value);

        Order Get(int id);

        List<Order> GetList();

        void Delete(int id);

        void Update(Order value);
    }
}