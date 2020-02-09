using System;
using System.Collections.Generic;
using System.Linq;
using VirtualServersApp.Shared.Models;

namespace VirtualServersApp.Shared.Services {

    public class FakeServerRepository : IServerRepository {
        private List<Server> _servers = new List<Server> {
            new Server { Id = 1, Name = "Fake", CreatedDate = DateTime.Now }
        };

        public void Delete(int id) {
            var server = _servers.SingleOrDefault(s => s.Id == id);
            _servers.Remove(server);
        }

        public Server Get(int id) {
            return _servers.SingleOrDefault(s => s.Id == id);
        }

        public List<Server> GetList() {
            return _servers;
        }

        public void Insert(Server value) {
            _servers.Add(value);
        }

        public void Update(Server value) {
            var oldServer = _servers.SingleOrDefault(s => s.Id == value.Id);
            _servers.Remove(oldServer);
            _servers.Add(value);
        }
    }
}