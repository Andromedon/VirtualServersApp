using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualServersApp.Shared.Entities;

namespace VirtualServersApp.Client.Repositories {
    public interface IServerRepository
    {
        void Insert(Server value);

        Server Get(int id);

        List<Server> GetList();

        void Delete(int id);

        void Update(Server value);
    }
}
