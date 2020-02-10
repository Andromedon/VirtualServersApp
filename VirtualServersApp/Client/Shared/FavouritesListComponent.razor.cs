using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using VirtualServersApp.Shared.Entities;

namespace VirtualServersApp.Client.Shared {

    public partial class FavouritesListComponent {
        [Parameter] public List<Server> Favourites { get; set; }

    }
}