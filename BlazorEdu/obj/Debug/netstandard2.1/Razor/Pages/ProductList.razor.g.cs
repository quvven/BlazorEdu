#pragma checksum "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d35bd5e6f8f6d86c7d4680ba5ecab49656a2c74f"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>ProductList</h3>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\ProductList.razor"
 if (products == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>Loading....</p>\r\n");
#nullable restore
#line 13 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\ProductList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<thead>\r\n        <tr>\r\n            <th>Ürün ID</th>\r\n            <th>Ürün Adı</th>\r\n            <th>Fiyat</th>\r\n            <th>Stok Adedi</th>\r\n            <th>Detay</th>\r\n        </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(7, "tbody");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "tr");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 28 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\ProductList.razor"
                 foreach (var product in products)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 30 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\ProductList.razor"
                         product.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 31 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\ProductList.razor"
                         product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 32 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\ProductList.razor"
                         product.UnitPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 33 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\ProductList.razor"
                         product.UnitsInStock

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 34 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\ProductList.razor"
                         product.QuantityPerUnit

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn btn-sm btn-primary");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\ProductList.razor"
                                                                           () => GoToDetail(product.ProductId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Detaylar");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 38 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\ProductList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#nullable restore
#line 42 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\ProductList.razor"
}

#line default
#line hidden
#nullable disable
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
