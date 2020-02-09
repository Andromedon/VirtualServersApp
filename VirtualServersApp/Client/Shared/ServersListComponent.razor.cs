using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using VirtualServersApp.Shared.Models;
using VirtualServersApp.Shared.Services;

namespace VirtualServersApp.Client.Shared {

    public partial class ServersListComponent {

        [Parameter]
        public List<Server> Servers { get; set; }

        [Parameter]
        public int NumberOfServersOnlineLeft { get; set; }

        [Parameter] public EventCallback<bool> NumberOfServersOnlineChanged { get; set; }

        [Parameter] public EventCallback<List<string>> ShowMessage { get; set; }

        [Parameter] public EventCallback<Server> Removed { get; set; }

        [Parameter] public EventCallback FavouriteStatusChanged { get; set; }

        [Inject] public IServerRepository ServerRepository { get; set; }

        public void OnFavouriteStatusChanged() {
            FavouriteStatusChanged.InvokeAsync("");
        }

        public void OnServerChangeStatus(bool isOnline) {
            NumberOfServersOnlineChanged.InvokeAsync(isOnline);
        }

        public void RegisterMessage(List<string> message) {
            ShowMessage.InvokeAsync(message);
        }

        public void OnRemoveServer(Server model) {
            ServerRepository.Delete(model.Id);
            Removed.InvokeAsync(model);
        }
    }
}