#pragma checksum "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d35bd5e6f8f6d86c7d4680ba5ecab49656a2c74f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorEdu.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\_Imports.razor"
using BlazorEdu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\_Imports.razor"
using BlazorEdu.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\ProductList.razor"
using BlazorEdu.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\ProductList.razor"
using BlazorEdu.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productlist")]
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\ProductList.razor"
       

    ProductListViewModel[] products;

    protected async override Task OnInitializedAsync()
    {
        products = await ProductService.GetProducts();
    }

    void GoToDetail(int productId)
    {
        NavigationManager.NavigateTo("/productdetail/"+productId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591