using System;
using System.Collections.Generic;
using System.Linq;
using VirtualServersApp.Shared.Entities;

namespace VirtualServersApp.Client.Repositories {

    public class FakeOrderRepository : IOrderRepository {

        private List<Order> _orders = new List<Order> {
            new Order { Id = 1, ProductId = 2, CreatedDate = DateTime.Now.AddHours(-2).AddSeconds(15), Completed = true},
            new Order { Id = 2, ProductId = 1, CreatedDate = DateTime.Now.AddHours(-3).AddMinutes(-5).AddSeconds(-15), Completed = true},
            new Order { Id = 3, ProductId = 1, CreatedDate = DateTime.Now.AddDays(-2).AddSeconds(47), Completed = true},
            new Order { Id = 4, ProductId = 3, CreatedDate = DateTime.Now.AddDays(-1).AddHours(-5).AddMinutes(-34).AddSeconds(-12), Completed = false},
            new Order { Id = 5, ProductId = 6, CreatedDate = DateTime.Now, Completed = false}
        };

        public void Delete(int id) {
            var order = _orders.SingleOrDefault(s => s.Id == id);
            _orders.Remove(order);
        }

        public Order Get(int id) {
            return _orders.SingleOrDefault(o => o.Id == id);
        }

        public List<Order> GetList() {
            return _orders;
        }

        public void Insert(Order value) {
            _orders.Add(value);
        }

        public void Update(Order value) {
            var oldOrder = _orders.SingleOrDefault(o => o.Id == value.Id);
            _orders.Remove(oldOrder);
            _orders.Add(value);
        }
    }
}