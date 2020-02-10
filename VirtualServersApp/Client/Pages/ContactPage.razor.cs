using VirtualServersApp.Shared;
using VirtualServersApp.Shared.Models;

namespace VirtualServersApp.Client.Pages {

    public partial class ContactPage {
        private Order order = new Order();
        public string MessageSubject { get; set; }
        public string MessageBody { get; set; }

        public string MessageFrom { get; set; }

        public string Message = "Please enter your message here";
        public string MessageType = "Info";

        private bool IsFormValid {
            get {
                return !string.IsNullOrEmpty(MessageSubject) && !string.IsNullOrEmpty(MessageFrom) && !string.IsNullOrEmpty(MessageBody);
            }
        }

        private void ShowMessage(string content, string type) {
            Message = content;
            MessageType = type;
        }

        protected void SendMessage() {
            if (IsFormValid) {
                Logger.Write($"Sending message from {MessageFrom} - Subject: {MessageSubject} - Body: {MessageBody}...");
                ShowMessage($"Message has been sent! Wait for the reply on {MessageFrom}!", "Info");
            }
            else {
                ShowMessage($"All inputs are required!", "Error");
            }
        }
    }
}