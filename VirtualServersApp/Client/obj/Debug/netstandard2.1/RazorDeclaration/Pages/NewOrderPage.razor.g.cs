#pragma checksum "C:\Users\RW\Documents\Dev\Repositories\VirtualServersApp\VirtualServersApp\Client\Pages\NewOrderPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ac49c9a6e966ef40b5f08c515712922b066690b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace VirtualServersApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\RW\Documents\Dev\Repositories\VirtualServersApp\VirtualServersApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RW\Documents\Dev\Repositories\VirtualServersApp\VirtualServersApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\RW\Documents\Dev\Repositories\VirtualServersApp\VirtualServersApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\RW\Documents\Dev\Repositories\VirtualServersApp\VirtualServersApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\RW\Documents\Dev\Repositories\VirtualServersApp\VirtualServersApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\RW\Documents\Dev\Repositories\VirtualServersApp\VirtualServersApp\Client\_Imports.razor"
using VirtualServersApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\RW\Documents\Dev\Repositories\VirtualServersApp\VirtualServersApp\Client\_Imports.razor"
using VirtualServersApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\RW\Documents\Dev\Repositories\VirtualServersApp\VirtualServersApp\Client\_Imports.razor"
using VirtualServersApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\RW\Documents\Dev\Repositories\VirtualServersApp\VirtualServersApp\Client\_Imports.razor"
using VirtualServersApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\RW\Documents\Dev\Repositories\VirtualServersApp\VirtualServersApp\Client\_Imports.razor"
using VirtualServersApp.Shared.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\RW\Documents\Dev\Repositories\VirtualServersApp\VirtualServersApp\Client\_Imports.razor"
using VirtualServersApp.Client.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/neworder")]
    public partial class NewOrderPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\RW\Documents\Dev\Repositories\VirtualServersApp\VirtualServersApp\Client\Pages\NewOrderPage.razor"
       
    private Order OrderModel = new Order();

    public int Amount => productRepository.Get(Convert.ToInt32(OrderModel.StringProductId)).Amount;
    public string Price => productRepository.Get(Convert.ToInt32(OrderModel.StringProductId)).Price.ToString("c");
    public string Type => productTypeRepository.Get(productRepository.Get(Convert.ToInt32(OrderModel.StringProductId)).ProductTypeId).Name;


    private void OnValidSubmit() {
        Console.WriteLine($"Validated! :) ProductId: {OrderModel.StringProductId}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductTypeRepository productTypeRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductRepository productRepository { get; set; }
    }
}
#pragma warning restore 1591
