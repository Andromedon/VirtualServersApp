using System;
using System.ComponentModel.DataAnnotations;

namespace VirtualServersApp.Shared.Models {

    public class Order {
        public int Id { get; set; }
        [Required(ErrorMessage = "Product field is required!")]
        public int ProductId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Completed { get; set; }

        public string StringProductId { get; set; }
    }
}