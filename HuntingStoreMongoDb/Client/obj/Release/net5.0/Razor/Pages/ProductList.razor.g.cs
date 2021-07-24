#pragma checksum "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23d4ad54a3c9d5beaa14396457fb95ec53ce12bb"
// <auto-generated/>
#pragma warning disable 1591
namespace HuntingStoreMongoDb.Client.Pages
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
#nullable restore
#line 1 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\ProductList.razor"
using BlazorPagination;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
#nullable restore
#line 4 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\ProductList.razor"
     if (PagedResultList.Results?.Length > 0)
    {
        foreach (var product in PagedResultList.Results)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card card-outline-primary m-1 p-1");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "bg-faded p-1");
            __builder.OpenElement(6, "h4");
            __builder.AddContent(7, 
#nullable restore
#line 11 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\ProductList.razor"
                         product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n                        ");
            __builder.OpenElement(9, "span");
            __builder.AddAttribute(10, "class", "badge badge-pill badge-primary");
            __builder.AddAttribute(11, "style", "float:right");
            __builder.OpenElement(12, "small");
            __builder.AddAttribute(13, "style", "color:black");
            __builder.AddContent(14, 
#nullable restore
#line 13 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\ProductList.razor"
                                                        product.Price.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n                ");
            __builder.OpenElement(16, "span");
            __builder.AddAttribute(17, "class", "card-text p-1");
            __builder.AddContent(18, 
#nullable restore
#line 19 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\ProductList.razor"
                     product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "submit");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\ProductList.razor"
                                                      e => AddToCart(e, product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "btn btn-success btn-sm pull-right");
            __builder.AddAttribute(24, "style", "float:right");
            __builder.AddMarkupContent(25, "\r\n                        Add To Cart\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\ProductList.razor"
        }
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\ProductList.razor"
       

    [CascadingParameter]
    public PagedResult<Product> PagedResultList { get; set; }

    [Parameter]
    public Action<MouseEventArgs, Product> AddToCart { get; set; }

    [Parameter]
    public Func<Task> GetData { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591