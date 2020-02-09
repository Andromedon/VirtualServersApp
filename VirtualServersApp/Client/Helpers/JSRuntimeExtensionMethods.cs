using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace VirtualServersApp.Client.Helpers {

    public static class JSRuntimeExtensionMethods {

        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message) {
            return await js.InvokeAsync<bool>("confirm", message);
        }
    }
}