#pragma checksum "C:\Users\MickvanderWoudeSynlo\source\repos\TestAppBlazor\TestAppBlazor\Pages\Test.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78a06c1d865c9e3b1db51a487775477af3cfd154"
// <auto-generated/>
#pragma warning disable 1591
namespace TestAppBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\MickvanderWoudeSynlo\source\repos\TestAppBlazor\TestAppBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MickvanderWoudeSynlo\source\repos\TestAppBlazor\TestAppBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MickvanderWoudeSynlo\source\repos\TestAppBlazor\TestAppBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MickvanderWoudeSynlo\source\repos\TestAppBlazor\TestAppBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MickvanderWoudeSynlo\source\repos\TestAppBlazor\TestAppBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MickvanderWoudeSynlo\source\repos\TestAppBlazor\TestAppBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MickvanderWoudeSynlo\source\repos\TestAppBlazor\TestAppBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\MickvanderWoudeSynlo\source\repos\TestAppBlazor\TestAppBlazor\_Imports.razor"
using TestAppBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\MickvanderWoudeSynlo\source\repos\TestAppBlazor\TestAppBlazor\_Imports.razor"
using TestAppBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\MickvanderWoudeSynlo\source\repos\TestAppBlazor\TestAppBlazor\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\MickvanderWoudeSynlo\source\repos\TestAppBlazor\TestAppBlazor\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\MickvanderWoudeSynlo\source\repos\TestAppBlazor\TestAppBlazor\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/test/{id}")]
    public partial class Test : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "test - ");
            __builder.AddContent(2, 
#nullable restore
#line 2 "C:\Users\MickvanderWoudeSynlo\source\repos\TestAppBlazor\TestAppBlazor\Pages\Test.razor"
            id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\Users\MickvanderWoudeSynlo\source\repos\TestAppBlazor\TestAppBlazor\Pages\Test.razor"
       
    [Parameter]
    public int id { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
