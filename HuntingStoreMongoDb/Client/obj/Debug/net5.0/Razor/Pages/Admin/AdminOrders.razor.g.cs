#pragma checksum "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\AdminOrders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2cadaf1a2bad6521c70f5cb5f0d61147ae5318b"
// <auto-generated/>
#pragma warning disable 1591
namespace HuntingStoreMongoDb.Client.Pages.Admin
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
#line 8 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\AdminOrders.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\AdminOrders.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/orders")]
    public partial class AdminOrders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 12 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\AdminOrders.razor"
 if (!isLoaded)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"container mt-3\"><div class=\"spinner-border text-success align-self-sm-center\" role=\"status\"><span class=\"visually-hidden\">Loading...</span></div>\r\n        <h2>Getting datas from database...</h2></div>");
#nullable restore
#line 20 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\AdminOrders.razor"
}

else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<HuntingStoreMongoDb.Client.Pages.Admin.OrderTable>(1);
            __builder.AddAttribute(2, "TableTitle", "Unshipped Orders");
            __builder.AddAttribute(3, "Orders", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<HuntingStoreMongoDb.Shared.State.OrderViewModel>>(
#nullable restore
#line 24 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\AdminOrders.razor"
                                                      UnshippedOrders

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ButtonLabel", "Ship");
            __builder.AddAttribute(5, "OrderSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 25 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\AdminOrders.razor"
                                                  ShipOrder

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.OpenComponent<HuntingStoreMongoDb.Client.Pages.Admin.OrderTable>(6);
            __builder.AddAttribute(7, "TableTitle", "Shipped Orders");
            __builder.AddAttribute(8, "Orders", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<HuntingStoreMongoDb.Shared.State.OrderViewModel>>(
#nullable restore
#line 27 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\AdminOrders.razor"
                                                    ShippedOrders

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ButtonLabel", "Reset");
            __builder.AddAttribute(10, "OrderSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 28 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\AdminOrders.razor"
                                                   ResetOrder

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-info");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\AdminOrders.razor"
                                             e => UpdateData()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Refresh Data");
            __builder.CloseElement();
            __Blazor.HuntingStoreMongoDb.Client.Pages.Admin.AdminOrders.TypeInference.CreateCascadingValue_0(__builder, 15, 16, 
#nullable restore
#line 32 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\AdminOrders.razor"
                            Message

#line default
#line hidden
#nullable disable
            , 17, (__builder2) => {
                __builder2.OpenComponent<HuntingStoreMongoDb.Client.Shared.MessageModal>(18);
                __builder2.AddAttribute(19, "CloseModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 33 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\AdminOrders.razor"
                                   CloseMessageModal

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 35 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\AdminOrders.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\AdminOrders.razor"
       


    private List<OrderViewModel> UnshippedOrders { get; set; } = new List<OrderViewModel>();
    private List<OrderViewModel> ShippedOrders { get; set; } = new List<OrderViewModel>();
    private string Message { get; set; }
    private bool isLoaded = false;

    protected override async Task OnParametersSetAsync()
    {
        if (state.AllOrders.Count == 0)
        {
            state.AllOrders = await adminService.GetAllOrdersAsync();

        }
        UnshippedOrders = state.AllOrders.Where(x => x.Shipped == false).ToList();
        ShippedOrders = state.AllOrders.Where(x => x.Shipped == true).ToList();
        isLoaded = true;
    }

    private async Task UpdateData()
    {
        state.AllOrders = await adminService.GetAllOrdersAsync();
        UnshippedOrders = state.AllOrders.Where(x => x.Shipped == false).ToList();
        ShippedOrders = state.AllOrders.Where(x => x.Shipped == true).ToList();
    }

    private async Task ShipOrder(string id) => await UpdateOrder(id, true);
    private async Task ResetOrder(string id) => await UpdateOrder(id, false);

    private async Task UpdateOrder(string id, bool shipValue)
    {
        var order = state.AllOrders.Where(x => x.Id == id).FirstOrDefault();
        order.Shipped = shipValue;
        var response = await adminService.UpdateOrderAsync(order);
        if (response.IsSuccessStatusCode)
        {
            Message = await response.Content.ReadAsStringAsync();
            await jsRuntime.InvokeVoidAsync("ShowMessageModal");

        }
        else
        {
            Message = await response.Content.ReadAsStringAsync();
            await jsRuntime.InvokeVoidAsync("ShowMessageModal");
        }
    }

    private void CloseMessageModal()
    {
        jsRuntime.InvokeVoidAsync("HideMessageModal");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private State state { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdminService adminService { get; set; }
    }
}
namespace __Blazor.HuntingStoreMongoDb.Client.Pages.Admin.AdminOrders
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591