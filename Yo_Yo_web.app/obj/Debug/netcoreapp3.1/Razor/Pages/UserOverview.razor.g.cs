#pragma checksum "E:\Yo_Yo_web.app\Yo_Yo_web.app\Pages\UserOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "117e4f046fffa6bd9ed687230bd45c8b23970d10"
// <auto-generated/>
#pragma warning disable 1591
namespace Yo_Yo_web.app.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class UserOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style type=\"text/css\"></style>\r\n\r\n\r\n");
            __builder.OpenElement(1, "body");
            __builder.AddAttribute(2, "translate", "no");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "ctn");
            __builder.AddMarkupContent(5, "<h3 class=\"title\">YoYo Test</h3>\r\n        ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn-danger");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "E:\Yo_Yo_web.app\Yo_Yo_web.app\Pages\UserOverview.razor"
                                             StartFunction

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Start Test");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "<br><br>\r\n\r\n        <canvas height=\"100\" width=\"200\" padding-top=\"200\" id=\"counter\"></canvas>\r\n\r\n        ");
            __builder.AddMarkupContent(11, @"<div class=""container""><div class=""shuttle""><p>NEXT SHUTTLE</p><p id=""next_shuttle"">0:00 s</p></div><p class=""vl""></p>
            <div class=""time""><p>TOTAL TIME</p><p id=""total_time"">0:00 m</p></div><p class=""v2""></p>
            <div class=""distance""><p>TOTAL DISTANCE</p><p id=""total_distance"">0 m</p></div></div>
        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "tbl");
#nullable restore
#line 30 "E:\Yo_Yo_web.app\Yo_Yo_web.app\Pages\UserOverview.razor"
             if (Users == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<p><em>Loading...</em></p>");
#nullable restore
#line 33 "E:\Yo_Yo_web.app\Yo_Yo_web.app\Pages\UserOverview.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table");
            __builder.AddAttribute(17, "id", "tbl");
            __builder.AddMarkupContent(18, "<thead><tr><th>Track</th>\r\n                            <th></th>\r\n                            <th></th>\r\n                            <th></th>\r\n                            <th></th></tr></thead>\r\n                    ");
            __builder.OpenElement(19, "tbody");
#nullable restore
#line 47 "E:\Yo_Yo_web.app\Yo_Yo_web.app\Pages\UserOverview.razor"
                         foreach (var user in Users)
                        {
                           

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "tr");
            __builder.OpenElement(21, "td");
            __builder.AddAttribute(22, "id", 
#nullable restore
#line 51 "E:\Yo_Yo_web.app\Yo_Yo_web.app\Pages\UserOverview.razor"
                                    user.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, 
#nullable restore
#line 51 "E:\Yo_Yo_web.app\Yo_Yo_web.app\Pages\UserOverview.razor"
                                               user.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                            ");
            __builder.OpenElement(25, "td");
            __builder.AddAttribute(26, "id", 
#nullable restore
#line 52 "E:\Yo_Yo_web.app\Yo_Yo_web.app\Pages\UserOverview.razor"
                                      user.Id+user.Id

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "E:\Yo_Yo_web.app\Yo_Yo_web.app\Pages\UserOverview.razor"
                                                                          () => CountFunction(user)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "class", "btn-warning");
            __builder.AddAttribute(30, "id", 
#nullable restore
#line 52 "E:\Yo_Yo_web.app\Yo_Yo_web.app\Pages\UserOverview.razor"
                                                                                                                             user.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, "Warn");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            ");
            __builder.OpenElement(33, "td");
            __builder.AddAttribute(34, "id", 
#nullable restore
#line 53 "E:\Yo_Yo_web.app\Yo_Yo_web.app\Pages\UserOverview.razor"
                                      user.Id+user.Id

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn-danger");
            __builder.AddAttribute(37, "id", 
#nullable restore
#line 53 "E:\Yo_Yo_web.app\Yo_Yo_web.app\Pages\UserOverview.razor"
                                                                                       user.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "E:\Yo_Yo_web.app\Yo_Yo_web.app\Pages\UserOverview.razor"
                                                                                                         () => EndFunction(user)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Stop");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                            ");
            __builder.OpenElement(41, "td");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn-danger edit");
            __builder.AddAttribute(44, "id", 
#nullable restore
#line 54 "E:\Yo_Yo_web.app\Yo_Yo_web.app\Pages\UserOverview.razor"
                                                                     user.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "E:\Yo_Yo_web.app\Yo_Yo_web.app\Pages\UserOverview.razor"
                                                                                       () => EditUser(user)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "E:\Yo_Yo_web.app\Yo_Yo_web.app\Pages\UserOverview.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "E:\Yo_Yo_web.app\Yo_Yo_web.app\Pages\UserOverview.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
