using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using VirtualServersApp.Client.Shared;
using VirtualServersApp.Shared.Entities;
using VirtualServersApp.Shared.Services;
using VirtualServersApp.Client.Repositories;

namespace VirtualServersApp.Client.Pages {

    public partial class ServersPage {
        public List<Server> Servers = new List<Server>();
        public string Message = "No server was created!";
        public string MessageType = "Info";
        public bool AllowNewServer = true;
        public bool ServerCreated = false;
        public string ServerButtonName = string.Empty;
        public int MaximumAmountOfServersOnline => GetMaximumNumberOfServersOnline();

        public int NumberOfServersOnline = 0;
        public int NumberOfServersOnlineLeft = 0;
        public int NumberOfServersAllowed => GetNumberOfAllowedServers();

        public int NumberOfServersAlreadyCreated = 0;
        public string ServerName = string.Empty;
        public int ServersLeft = 0;
        public bool ServersButtonDisabled => (!AllowNewServer || string.IsNullOrEmpty(ServerName));

        public bool ServerNameInputDisabled { get; set; }

        public StatusPanelComponent StatusPanel;
        [Inject] public IOrderRepository OrderRepository { get; set; }
        [Inject] public IProductRepository ProductRepository { get; set; }

        [Inject] public IServerRepository ServerRepository { get; set; }

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        [Inject]
        public MemoryCacheService MemoryCache { get; set; }

        private Timer _timer;

        private int _progressCounter;

        protected override void OnInitialized() {
            Servers = ServerRepository.GetList();
            ServersLeft = NumberOfServersAllowed - Servers.Count;
            NumberOfServersOnlineLeft = MaximumAmountOfServersOnline - Servers.Where(s => s.Online).Count();
            PrepareServerButtonName();
            PrepareServerCreationStatus();
            ValidateServerName();
        }

        private int GetMaximumNumberOfServersOnline() {
            return OrderRepository.GetList().Where(o => o.Completed && ProductRepository.Get(o.ProductId).ProductTypeId == 2).Sum(o => ProductRepository.Get(o.ProductId).Amount) + 1;
        }

        private int GetNumberOfAllowedServers() {
            return OrderRepository.GetList().Where(o => o.Completed && ProductRepository.Get(o.ProductId).ProductTypeId == 1).Sum(o => ProductRepository.Get(o.ProductId).Amount);
        }

        public void OnKeyPress(KeyboardEventArgs e) {
            if (e.Key == "Enter") {
                OnServerButtonClick();
            }
        }

        public void OnServerRemoved(Server model) {
            ShowMessage($"Server {model.Name} has been deleted!", "Info");
            NumberOfServersAlreadyCreated--;
            ServersLeft = NumberOfServersAllowed - NumberOfServersAlreadyCreated;
            CheckIfNewServerIsAllowed();
            PrepareServerButtonName();
        }

        public void PrepareServerButtonName() {
            if (ServersLeft > 0) {
                var serverName = !string.IsNullOrEmpty(GetServerName()) ? $"'{GetServerName()}'" : GetServerName();
                ServerButtonName = $"Add {serverName} Server";
            }
            else {
                ServerButtonName = "No More Servers Are Available!";
            }
        }

        public void OnServerChangeStatus(bool isOnline) {
            if (isOnline) {
                NumberOfServersOnline++;
            }
            else {
                NumberOfServersOnline--;
            }
            NumberOfServersOnlineLeft = MaximumAmountOfServersOnline - NumberOfServersOnline;
        }

        private void PrepareServerCreationStatus() {
            if (NumberOfServersAlreadyCreated > 0) {
                if (NumberOfServersAlreadyCreated == 1) {
                    ShowMessage("", "Info");
                }
                ShowMessage($"Server {GetServerName()} has been created!", "Info");
                ServerCreated = true;
            }
            else {
                ShowMessage("Create your unique server! :)", "Info");
                ServerCreated = false;
            }
        }

        protected void OnFavouriteStatusChanged() {
            StateHasChanged();
        }

        public string GetServerName() {
            return ServerName.Trim();
        }

        private void ValidateServerName() {
            AllowNewServer = !string.IsNullOrEmpty(GetServerName().Replace(" ", "").Replace(" ", "")) && ServersLeft > 0 ? true : false;
        }

        public void ShowMessage(List<string> message) {
            if (message.Count == 2) {
                ShowMessage(message[0], message[1]);
            }
        }

        private void ShowMessage(string content, string type) {
            Message = content;
            MessageType = type;
        }

        public void OnUpdateServerName() {
            ValidateServerName();
            PrepareServerButtonName();
        }

        protected void OnServerButtonClick() {
            if (Servers.Any(s => s.Name.Equals($"{ServerName}"))) {
                ShowMessage($"Server with name {ServerName} already exists. Please enter other server name.", "Error");
            }
            else {
                //await JSRuntime.InvokeVoidAsync("fakeProgress", DotNetObjectReference.Create(this));
                AllowNewServer = false;
                ServerNameInputDisabled = true;
                ShowMessage($"Creating server {ServerName} in progress...", "Info");
                _timer = new Timer();
                _timer.Interval = 20;
                _timer.Elapsed += FakeProgress;
                _timer.Start();
            }
        }

        public void Dispose() {
            if (_timer != null) {
                _timer.Dispose();
            }
        }

        private void ClearServerName() {
            ServerName = string.Empty;
        }

        private void CheckIfNewServerIsAllowed() {
            if (NumberOfServersAllowed <= NumberOfServersAlreadyCreated) {
                AllowNewServer = false;
            }
            else {
                AllowNewServer = true;
            }
        }

        private void FakeProgress(object sender, ElapsedEventArgs args) {
            _progressCounter++;
            ServerButtonName = $"{_progressCounter}%";

            if (_progressCounter >= 100) {
                _timer.Stop();
                _progressCounter = 0;
                CreateNewServer();
            }
            StateHasChanged();
        }

        //[JSInvokable]
        public void CreateNewServer() {
            CheckIfNewServerIsAllowed();
            NumberOfServersAlreadyCreated++;
            ServersLeft = NumberOfServersAllowed - NumberOfServersAlreadyCreated;
            ServerNameInputDisabled = ServersLeft <= 0;
            int id = Servers?.Count > 0 ? Servers.OrderByDescending(s => s.Id).FirstOrDefault().Id : 0;
            ServerRepository.Insert(new Server { Id = id + 1, Name = GetServerName(), Online = false, CreatedDate = DateTime.Now.AddHours(1) });
            StateHasChanged();
            PrepareServerCreationStatus();
            ClearServerName();
            PrepareServerButtonName();
            ValidateServerName();
            MemoryCache.ServersAlreadyCreated++;
        }
    }
}