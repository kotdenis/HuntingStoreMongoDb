#pragma checksum "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Shared\StoreLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "968d20b54042bba88283c3e0ed21f5043c4678c7"
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
    public partial class StoreLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "navbar navbar-dark bg-dark");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid");
            __builder.AddMarkupContent(4, "<a class=\"navbar-brand\" href=\"/\"><strong>Hunting Store</strong></a>\r\n        ");
            __builder.OpenElement(5, "form");
            __builder.AddAttribute(6, "class", "d-flex");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "class", "btn btn-outline-success");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Shared\StoreLayout.razor"
                                                              async _ => await RedirectToAdministration()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(10, "onclick", true);
            __builder.AddEventStopPropagationAttribute(11, "onclick", true);
            __builder.AddMarkupContent(12, "\r\n                Administration\r\n            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "container-fluid");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "row");
            __builder.AddContent(18, 
#nullable restore
#line 17 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Shared\StoreLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Shared\StoreLayout.razor"
       

    [CascadingParameter]
    Task<AuthenticationState> AuthenticationState { get; set; }

    private async Task RedirectToAdministration()
    {
        if (!(await AuthenticationState).User.Identity.IsAuthenticated)
        {
            navigationManager.NavigateTo("/login");
        }
        else
        {
            navigationManager.NavigateTo("/admin/products");
        }

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
