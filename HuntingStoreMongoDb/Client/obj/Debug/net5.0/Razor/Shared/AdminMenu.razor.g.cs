#pragma checksum "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Shared\AdminMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edf8c205ba67a3f820f8b59e061aa2d07a828763"
// <auto-generated/>
#pragma warning disable 1591
namespace HuntingStoreMongoDb.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\_Imports.razor"
using HuntingStoreMongoDb.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\_Imports.razor"
using HuntingStoreMongoDb.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\_Imports.razor"
using HuntingStoreMongoDb.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\_Imports.razor"
using HuntingStoreMongoDb.Shared.State;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\_Imports.razor"
using HuntingStoreMongoDb.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\_Imports.razor"
using HuntingStoreMongoDb.Client.Pages.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\_Imports.razor"
using HuntingStoreMongoDb.Shared.IdentityModels;

#line default
#line hidden
#nullable disable
    public partial class AdminMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddAttribute(1, "class", "nav flex-column mt-3");
            __builder.OpenElement(2, "li");
            __builder.AddAttribute(3, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(4);
            __builder.AddAttribute(5, "class", "btn btn-outline-primary btn-block");
            __builder.AddAttribute(6, "href", "/admin/products");
            __builder.AddAttribute(7, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(8, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 7 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Shared\AdminMenu.razor"
                        NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "style", "width:100px");
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            Products\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "li");
            __builder.AddAttribute(14, "class", "nav-item px-3 mt-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(15);
            __builder.AddAttribute(16, "class", "btn btn-outline-primary btn-block");
            __builder.AddAttribute(17, "href", "/admin/orders");
            __builder.AddAttribute(18, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(19, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 16 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Shared\AdminMenu.razor"
                        NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "style", "width:100px");
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n            Orders\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591