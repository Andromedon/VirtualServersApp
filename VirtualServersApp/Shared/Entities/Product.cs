namespace VirtualServersApp.Shared.Entities {

    public class Product {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public int ProductTypeId { get; set; }
    }
}