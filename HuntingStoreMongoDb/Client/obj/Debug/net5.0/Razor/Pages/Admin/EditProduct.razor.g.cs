#pragma checksum "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\EditProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30ebeac182979b63f65c56e7dfce5062ffe29030"
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
#line 8 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\EditProduct.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\EditProduct.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/editor/{id}")]
    public partial class EditProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"text-center mt-2\" style=\"background-color:darkseagreen;color:white\">Edit product</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\EditProduct.razor"
                           _ => EditProductAsync()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\EditProduct.razor"
                                                             Products

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "<label style=\"font-weight:bold\"><span class=\"fa fa-id-card\" aria-hidden=\"true\"></span>&nbsp;Name\r\n        </label>\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\EditProduct.razor"
                                                          Products.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Products.Name = __value, Products.Name))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Products.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group mt-2");
                __builder2.AddMarkupContent(22, "<label style=\"font-weight:bold\"><span class=\"fa fa-folder-open\" aria-hidden=\"true\"></span>&nbsp;Desscription\r\n        </label>\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\EditProduct.razor"
                                                          Products.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Products.Description = __value, Products.Description))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Products.Description));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group mt-2");
                __builder2.AddMarkupContent(32, "<label style=\"font-weight:bold\"><span class=\"fa fa-credit-card\" aria-hidden=\"true\"></span>&nbsp;Price\r\n        </label>\r\n        ");
                __builder2.OpenElement(33, "div");
                __Blazor.HuntingStoreMongoDb.Client.Pages.Admin.EditProduct.TypeInference.CreateInputNumber_0(__builder2, 34, 35, "form-control", 36, 
#nullable restore
#line 41 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\EditProduct.razor"
                                                            Products.Price

#line default
#line hidden
#nullable disable
                , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Products.Price = __value, Products.Price)), 38, () => Products.Price);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.AddMarkupContent(40, "<div class=\"form-group\"><label></label></div>\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "mt-2");
                __builder2.AddMarkupContent(43, "<button type=\"submit\" class=\"btn btn-success\">Edit product</button>\r\n        ");
                __builder2.OpenElement(44, "button");
                __builder2.AddAttribute(45, "class", "btn btn-secondary ml-2");
                __builder2.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\EditProduct.razor"
                                                           e => Cancel(e)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(47, "Cancel");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n\r\n");
            __Blazor.HuntingStoreMongoDb.Client.Pages.Admin.EditProduct.TypeInference.CreateCascadingValue_1(__builder, 49, 50, 
#nullable restore
#line 53 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\EditProduct.razor"
                        Message

#line default
#line hidden
#nullable disable
            , 51, (__builder2) => {
                __builder2.OpenComponent<HuntingStoreMongoDb.Client.Shared.MessageModal>(52);
                __builder2.AddAttribute(53, "CloseModal", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 54 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\EditProduct.razor"
                               CloseMessageModal

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\DENIS\source\repos\HuntingStoreMongoDb\HuntingStoreMongoDb\Client\Pages\Admin\EditProduct.razor"
       

    private Product Products = new Product();
    private string Message { get; set; }

    [Parameter]
    public string id { get; set; } = "";

    protected override async Task OnParametersSetAsync()
    {
        if (id != "")
            Products = state.AdminProducts.Where(x => x.Id == id).FirstOrDefault();
        await Task.CompletedTask;
    }

    private async Task EditProductAsync()
    {

        var response = await adminService.EditProductAsync(Products);
        if (response.IsSuccessStatusCode)
        {
            Message = await response.Content.ReadAsStringAsync();
            await jsRuntime.InvokeVoidAsync("ShowMessageModal");
        }
    }

    private void Cancel(MouseEventArgs e)
    {
        navigatinManager.NavigateTo("/admin/products");
    }

    private void CloseMessageModal()
    {
        jsRuntime.InvokeVoidAsync("HideMessageModal");
        navigatinManager.NavigateTo("/admin/products");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdminService adminService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private State state { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigatinManager { get; set; }
    }
}
namespace __Blazor.HuntingStoreMongoDb.Client.Pages.Admin.EditProduct
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateCascadingValue_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591