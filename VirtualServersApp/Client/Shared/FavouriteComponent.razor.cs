using Microsoft.AspNetCore.Components;
using VirtualServersApp.Shared.Models;

namespace VirtualServersApp.Client.Shared
{
    public partial class FavouriteComponent
    {
        [Parameter] public Server ServerModel { get; set; }
    }
}
