using System.Collections.Generic;
using VirtualServersApp.Shared.Models;

namespace VirtualServersApp.Shared.Services {

    public interface IOrderRepository {

        void Insert(Order value);

        Order Get(int id);

        List<Order> GetList();

        void Delete(int id);

        void Update(Order value);
    }
}