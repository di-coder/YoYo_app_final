#pragma checksum "E:\Yo_Yo_web.app\Yo_Yo_web.app\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "614efc08b1817c7a49f0814ac44b8e205495dd25"
// <auto-generated/>
#pragma warning disable 1591
namespace Yo_Yo_web.app.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Yo_Yo_web.app\Yo_Yo_web.app\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Yo_Yo_web.app\Yo_Yo_web.app\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Yo_Yo_web.app\Yo_Yo_web.app\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Yo_Yo_web.app\Yo_Yo_web.app\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Yo_Yo_web.app\Yo_Yo_web.app\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Yo_Yo_web.app\Yo_Yo_web.app\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Yo_Yo_web.app\Yo_Yo_web.app\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Yo_Yo_web.app\Yo_Yo_web.app\_Imports.razor"
using Yo_Yo_web.app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Yo_Yo_web.app\Yo_Yo_web.app\_Imports.razor"
using Yo_Yo_web.app.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.OpenComponent<Yo_Yo_web.app.Shared.NavMenu>(2);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "content px-4");
            __builder.AddContent(8, 
#nullable restore
#line 13 "E:\Yo_Yo_web.app\Yo_Yo_web.app\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591