#pragma checksum "C:\Users\Chand\Desktop\Master_Folder\git_repositories\Jamie_hw_help_v1\GuitarShop\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaa9821d200b107e6a850bd6982a335bdf31709c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Chand\Desktop\Master_Folder\git_repositories\Jamie_hw_help_v1\GuitarShop\Views\Home\List.cshtml"
using GuitarShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaa9821d200b107e6a850bd6982a335bdf31709c", @"/Views/Home/List.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Chand\Desktop\Master_Folder\git_repositories\Jamie_hw_help_v1\GuitarShop\Views\Home\List.cshtml"
  
    ViewBag.Title = "My FAQs";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<header>
</header>
<div class=""text-center"">
    <div class=""row"">
        <div class=""column1"">
            <nav class=""navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3"">
                <div class=""container"">
                    <div class=""navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse"">
                        <ul class=""navbar-nav flex-grow-1"">
                            <li class=""nav-item"">
                                <a class=""nav-link text-dark""");
            BeginWriteAttribute("asp-area", " asp-area=\"", 630, "\"", 641, 0);
            EndWriteAttribute();
            WriteLiteral(" asp-controller=\"Home\" asp-action=\"List\" asp-route-id=\"All\" asp-route-id2=\"All\">All FAQs</a>\r\n                            </li>\r\n                            <li class=\"nav-item\">\r\n                                <a class=\"nav-link text-dark\"");
            BeginWriteAttribute("asp-area", " asp-area=\"", 883, "\"", 894, 0);
            EndWriteAttribute();
            WriteLiteral(" asp-controller=\"Home\" asp-action=\"List\" asp-route-id=\"boot\">BootStrap</a>\r\n                            </li>\r\n                            <li class=\"nav-item\">\r\n                                <a class=\"nav-link text-dark\"");
            BeginWriteAttribute("asp-area", " asp-area=\"", 1118, "\"", 1129, 0);
            EndWriteAttribute();
            WriteLiteral(" asp-controller=\"Home\" asp-action=\"List\" asp-route-id=\"cs\">C#</a>\r\n                            </li>\r\n                            <li class=\"nav-item\">\r\n                                <a class=\"nav-link text-dark\"");
            BeginWriteAttribute("asp-area", " asp-area=\"", 1344, "\"", 1355, 0);
            EndWriteAttribute();
            WriteLiteral(@" asp-controller=""Home"" asp-action=""List"" asp-route-id=""js"">javascript</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
            <table>
                <tbody>
                    <tr>
                        <td>
                            <a asp-controller=""Home"" asp-action=""List"" asp-route-id2=""Gen"">General</a>
                        </td>
                        <td>
                            <a asp-controller=""Home"" asp-action=""List"" asp-route-id2=""hist"">History</a>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
        <div class=""column2"">
            <table>
                <tbody>
");
#nullable restore
#line 47 "C:\Users\Chand\Desktop\Master_Folder\git_repositories\Jamie_hw_help_v1\GuitarShop\Views\Home\List.cshtml"
                     foreach (Question q in Model.questions)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td><strong>");
#nullable restore
#line 50 "C:\Users\Chand\Desktop\Master_Folder\git_repositories\Jamie_hw_help_v1\GuitarShop\Views\Home\List.cshtml"
                                   Write(q.QuestionText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>  ");
#nullable restore
#line 50 "C:\Users\Chand\Desktop\Master_Folder\git_repositories\Jamie_hw_help_v1\GuitarShop\Views\Home\List.cshtml"
                                                             Write(q.AnswerText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>Topic: ");
#nullable restore
#line 51 "C:\Users\Chand\Desktop\Master_Folder\git_repositories\Jamie_hw_help_v1\GuitarShop\Views\Home\List.cshtml"
                                  Write(q.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("         Category: ");
#nullable restore
#line 51 "C:\Users\Chand\Desktop\Master_Folder\git_repositories\Jamie_hw_help_v1\GuitarShop\Views\Home\List.cshtml"
                                                             Write(q.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Chand\Desktop\Master_Folder\git_repositories\Jamie_hw_help_v1\GuitarShop\Views\Home\List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
