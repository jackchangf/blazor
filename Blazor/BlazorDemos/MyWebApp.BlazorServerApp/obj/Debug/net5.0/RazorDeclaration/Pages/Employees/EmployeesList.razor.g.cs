// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MyWebApp.BlazorServerApp.Pages.Employees
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\Blazor\BlazorDemos\MyWebApp.BlazorServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\Blazor\BlazorDemos\MyWebApp.BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\Blazor\BlazorDemos\MyWebApp.BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\Blazor\BlazorDemos\MyWebApp.BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\Blazor\BlazorDemos\MyWebApp.BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\Blazor\BlazorDemos\MyWebApp.BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\Blazor\BlazorDemos\MyWebApp.BlazorServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\Blazor\BlazorDemos\MyWebApp.BlazorServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\Blazor\BlazorDemos\MyWebApp.BlazorServerApp\_Imports.razor"
using MyWebApp.BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\Blazor\BlazorDemos\MyWebApp.BlazorServerApp\_Imports.razor"
using MyWebApp.BlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\Blazor\BlazorDemos\MyWebApp.BlazorServerApp\Pages\Employees\EmployeesList.razor"
using MyWebApp.BlazorServerApp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\Blazor\BlazorDemos\MyWebApp.BlazorServerApp\Pages\Employees\EmployeesList.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Employees/List")]
    public partial class EmployeesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\Chan\Desktop\SGUNITED FULL STACK DEV\Blazor\BlazorDemos\MyWebApp.BlazorServerApp\Pages\Employees\EmployeesList.razor"
       

    private HttpClient httpClient = new HttpClient();
    private IEnumerable<EmployeeViewModel> employees;

    protected override async Task OnInitializedAsync()
    {
        string apiUri = "https://localhost:44325/api/Employees";

        employees = await JsonSerializer.DeserializeAsync<IEnumerable<EmployeeViewModel>>(
            await httpClient.GetStreamAsync(apiUri),
            new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            });


        await base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
