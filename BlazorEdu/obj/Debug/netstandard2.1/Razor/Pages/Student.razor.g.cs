#pragma checksum "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\Student.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "726ff3d79343f58f6833e340cd98cb2cde3ed46b"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/student")]
    public partial class Student : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Student</h2>\r\n\r\n");
            __builder.OpenElement(1, "h4");
            __builder.AddContent(2, 
#nullable restore
#line 5 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\Student.razor"
     StudentTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\Student.razor"
       
    public string StudentTitle { get; set; }

    protected override async Task OnInitializedAsync()
    {
        StudentTitle = "Deneme";
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591