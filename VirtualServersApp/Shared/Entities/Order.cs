using System;

namespace VirtualServersApp.Shared.Entities {

    public class Order {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Completed { get; set; }
    }
}