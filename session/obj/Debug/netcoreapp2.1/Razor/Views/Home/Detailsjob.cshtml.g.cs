#pragma checksum "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Detailsjob.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b980b8dcc8d4da10b9ef7392df5422c3f372b2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detailsjob), @"mvc.1.0.view", @"/Views/Home/Detailsjob.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detailsjob.cshtml", typeof(AspNetCore.Views_Home_Detailsjob))]
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
#line 1 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\_ViewImports.cshtml"
using session;

#line default
#line hidden
#line 2 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\_ViewImports.cshtml"
using session.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b980b8dcc8d4da10b9ef7392df5422c3f372b2e", @"/Views/Home/Detailsjob.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40724393d212a7492650e68aebf3ec0dc20d4b7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detailsjob : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<session.Models.HIRE>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Detailsjob.cshtml"
  
    ViewData["Title"] = "Detailsjob";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(123, 316, true);
            WriteLiteral(@"
<hr />

<div class=""container"">
    <div class=""card"">
        <div class=""container-fliud"">
            <div class=""wrapper row"">
                <div class=""preview col-md-6"">

                    <div class=""preview-pic tab-content"">
                        <div class=""tab-pane active"" id=""pic-1""><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 439, "\"", 487, 1);
#line 17 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Detailsjob.cshtml"
WriteAttributeValue("", 445, Html.DisplayFor(model => model.jpictrue1), 445, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(488, 97, true);
            WriteLiteral(" width=\"600\" height=\"400\" /></div>\r\n                        <div class=\"tab-pane\" id=\"pic-2\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 585, "\"", 633, 1);
#line 18 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Detailsjob.cshtml"
WriteAttributeValue("", 591, Html.DisplayFor(model => model.jpictrue2), 591, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(634, 97, true);
            WriteLiteral(" width=\"600\" height=\"400\" /></div>\r\n                        <div class=\"tab-pane\" id=\"pic-3\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 731, "\"", 779, 1);
#line 19 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Detailsjob.cshtml"
WriteAttributeValue("", 737, Html.DisplayFor(model => model.jpictrue3), 737, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(780, 218, true);
            WriteLiteral(" width=\"600\" height=\"400\" /></div>\r\n                    </div>\r\n                    <ul class=\"preview-thumbnail nav nav-tabs\">\r\n                        <li class=\"active\"><a data-target=\"#pic-1\" data-toggle=\"tab\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 998, "\"", 1046, 1);
#line 22 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Detailsjob.cshtml"
WriteAttributeValue("", 1004, Html.DisplayFor(model => model.jpictrue1), 1004, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1047, 88, true);
            WriteLiteral(" /></a></li>\r\n                        <li><a data-target=\"#pic-2\" data-toggle=\"tab\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1135, "\"", 1183, 1);
#line 23 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Detailsjob.cshtml"
WriteAttributeValue("", 1141, Html.DisplayFor(model => model.jpictrue2), 1141, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1184, 88, true);
            WriteLiteral(" /></a></li>\r\n                        <li><a data-target=\"#pic-3\" data-toggle=\"tab\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1272, "\"", 1320, 1);
#line 24 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Detailsjob.cshtml"
WriteAttributeValue("", 1278, Html.DisplayFor(model => model.jpictrue3), 1278, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1321, 218, true);
            WriteLiteral(" /></a></li>\r\n                    </ul>\r\n\r\n                </div>\r\n                <div class=\"details col-md-6\">\r\n                    <h2><b>รายละเอียดงาน</b></h2>\r\n                    <h3 class=\"product-title\">งาน : ");
            EndContext();
            BeginContext(1540, 37, false);
#line 30 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Detailsjob.cshtml"
                                               Write(Html.DisplayFor(model => model.jname));

#line default
#line hidden
            EndContext();
            BeginContext(1577, 58, true);
            WriteLiteral("</h3>\r\n                    <p class=\"product-description\">");
            EndContext();
            BeginContext(1636, 39, false);
#line 31 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Detailsjob.cshtml"
                                              Write(Html.DisplayFor(model => model.jdatail));

#line default
#line hidden
            EndContext();
            BeginContext(1675, 60, true);
            WriteLiteral("</p>\r\n                    <h4 class=\"price\">ราคางาน : <span>");
            EndContext();
            BeginContext(1736, 38, false);
#line 32 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Detailsjob.cshtml"
                                                 Write(Html.DisplayFor(model => model.jprice));

#line default
#line hidden
            EndContext();
            BeginContext(1774, 94, true);
            WriteLiteral("</span></h4>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<session.Models.HIRE> Html { get; private set; }
    }
}
#pragma warning restore 1591
