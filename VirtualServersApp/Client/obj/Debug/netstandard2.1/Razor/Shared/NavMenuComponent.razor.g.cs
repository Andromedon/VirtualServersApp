#pragma checksum "C:\Users\RW\Documents\Dev\Repositories\VirtualServersApp\VirtualServersApp\Client\Shared\NavMenuComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cda7d3c6edb4a96c5ca5f864d92608b9e910cc5d"
// <auto-generated/>
#pragma warning disable 1591
namespace VirtualServersApp.Client.Shared
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
    public partial class NavMenuComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-light bg-light");
            __builder.AddAttribute(2, "style", "width: 100%; background-color: white !important;");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "navbar-nav");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(7);
            __builder.AddAttribute(8, "class", "nav-link");
            __builder.AddAttribute(9, "href", "/");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.AddMarkupContent(12, "<span class=\"nav-item\" aria-hidden=\"true\">Home</span>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(14);
            __builder.AddAttribute(15, "class", "nav-link");
            __builder.AddAttribute(16, "href", "servers");
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.AddMarkupContent(19, "<span class=\"nav-item\" aria-hidden=\"true\">Servers</span>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "nav-link");
            __builder.AddAttribute(23, "href", "pricing");
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.AddMarkupContent(26, "<span class=\"nav-item\" aria-hidden=\"true\">Pricing</span>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(28);
            __builder.AddAttribute(29, "class", "nav-link");
            __builder.AddAttribute(30, "href", "orders");
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.AddMarkupContent(33, "<span class=\"nav-item\" aria-hidden=\"true\">Orders</span>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(35);
            __builder.AddAttribute(36, "class", "nav-link");
            __builder.AddAttribute(37, "href", "contact");
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.AddMarkupContent(40, "<span class=\"nav-item\" aria-hidden=\"true\">Contact</span>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
