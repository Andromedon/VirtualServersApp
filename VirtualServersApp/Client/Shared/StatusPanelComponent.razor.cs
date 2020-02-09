using Microsoft.AspNetCore.Components;

namespace VirtualServersApp.Client.Shared {

    public partial class StatusPanelComponent {
        [Parameter] public string Message { get; set; }
        [Parameter] public string MessageType { get; set; }

        [Parameter]
        public string ClassName {
            get => GetStatusBoxStyle();
            set { }
        }

        private string GetStatusBoxStyle() {
            string style = string.Empty;
            switch (MessageType) {
                case "Info":
                    style = "alert alert-info";
                    break;

                case "Error":
                    style = "alert alert-danger";
                    break;
            }
            return style;
        }
    }
}