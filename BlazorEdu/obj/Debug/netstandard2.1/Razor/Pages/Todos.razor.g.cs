#pragma checksum "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\Todos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14b8db70b118482df993555aa5751fa7ea440dfa"
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
#line 2 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\Todos.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todos")]
    public partial class Todos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Todos</h3>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\Todos.razor"
 if (todoItems == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 10 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\Todos.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>User</th>\r\n                <th>Task</th>\r\n                <th>Complete?</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 23 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\Todos.razor"
             foreach (var todoItem in todoItems)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 27 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\Todos.razor"
                         todoItem.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 28 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\Todos.razor"
                         todoItem.UserId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 29 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\Todos.razor"
                         todoItem.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 30 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\Todos.razor"
                         todoItem.Completed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 32 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\Todos.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 35 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\Todos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Bulutistan-Yazilim\source\repos\BlazorEdu\BlazorEdu\Pages\Todos.razor"
       
    private TodoItem[] todoItems;

    protected override async Task OnInitializedAsync()
    {
        todoItems = await Http.GetFromJsonAsync<TodoItem[]>("sample-data/todos.json");
    }

    public class TodoItem
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591