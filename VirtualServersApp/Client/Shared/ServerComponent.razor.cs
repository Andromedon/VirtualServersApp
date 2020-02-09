using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VirtualServersApp.Shared.Models;
using VirtualServersApp.Shared.Services;

namespace VirtualServersApp.Client.Shared {

    public partial class ServerComponent {
        private ConfirmationComponent confirmation { get; set; }

        protected string ServerStatusButtonName = string.Empty;

        [Parameter] public EventCallback<bool> NumberOfServersOnlineChanged { get; set; }

        [Parameter] public EventCallback<List<string>> RegisterMessage { get; set; }

        [Parameter] public EventCallback<Server> Removed { get; set; }

        [Parameter] public EventCallback FavouriteStatusChanged { get; set; }

        [Parameter] public Server ServerModel { get; set; }

        [Parameter] public int NumberOfServersOnlineLeft { get; set; }

        [CascadingParameter] public string TextStyle { get; set; }

        [Inject] public IServerRepository ServerRepository { get; set; }

        //[Inject] private IJSRuntime js { get; set; }

        protected string ServerCreationStatusStyle => GetServerCreationStatusColor();
        protected string ServerStatusButtonStyle => GetServerStatusButtonStyle();

        protected string ServerStatus => GetServerStatus();

        protected string FavouriteButtonStyle {
            get {
                return ServerModel.IsFavourite ? "btn btn-warning btn-sm" : "btn btn-primary btn-sm";
            }
        }

        protected override void OnInitialized() => SetServerStatusButtonName();

        protected async Task RemoveServer() {
            if (!ServerModel.Online) {
                //var confirmed = await js.Confirm($"Are you sure you want to delete {ServerModel.Name} server?");
                //if (confirmed) {
                //    await Removed.InvokeAsync(ServerModel);
                //}
                confirmation.Show();
            }
            else {
                await RegisterMessage.InvokeAsync(new List<string> { "Deleting online servers is forbidden!", "Error" });
            }
        }

        protected void OnCancel() {
            //{ }
            //{ { { { { { { { { { { { { lalalalala: 123} } } } } } } } } } } } }
            confirmation.Hide();
        }

        protected async Task OnConfirm() {
            confirmation.Hide();
            await Removed.InvokeAsync(ServerModel);
        }

        protected void OnFavouriteStatusChanged() {
            ServerModel.IsFavourite = !ServerModel.IsFavourite;
            ServerModel.FavouriteSince = DateTime.Now.AddHours(1);
            ServerRepository.Update(ServerModel);
            FavouriteStatusChanged.InvokeAsync("");
        }

        protected void OnStatusButtonClick() {
            if (NumberOfServersOnlineLeft > 0 || ServerModel.Online) {
                ServerModel.Online = !ServerModel.Online;
                ServerRepository.Update(ServerModel);
                SetServerStatusButtonName();
                NumberOfServersOnlineChanged.InvokeAsync(ServerModel.Online);
            }
            else {
                RegisterMessage.InvokeAsync(new List<string> { "No more servers online allowed!", "Error" });
            }
        }

        private void SetServerStatusButtonName() {
            ServerStatusButtonName = ServerModel.Online ? "Go Offline" : "Go Online";
        }

        protected string GetServerStatusButtonStyle() {
            return ServerModel.Online ? "btn btn-danger btn-sm" : "btn btn-success btn-sm";
        }

        protected string GetServerCreationStatusColor() {
            string style = "color: ";
            style += ServerModel.Online ? "green" : "red";
            return $"{style}; font-weight: bold;";
        }

        private string GetServerStatus() {
            return ServerModel.Online ? "Online" : "Offline";
        }
    }
}