using System;

namespace VirtualServersApp.Shared.Models {

    public class Server {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Online { get; set; }
        public bool IsFavourite { get; set; }

        public DateTime FavouriteSince { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}