#pragma checksum "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cdd36d49b9b61060addb67d6b443e14c23be857"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_pro1_1), @"mvc.1.0.view", @"/Views/Home/pro1_1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/pro1_1.cshtml", typeof(AspNetCore.Views_Home_pro1_1))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cdd36d49b9b61060addb67d6b443e14c23be857", @"/Views/Home/pro1_1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40724393d212a7492650e68aebf3ec0dc20d4b7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_pro1_1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<session.Models.Confirmed>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml"
  
    ViewData["Title"] = "pro1_1";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(137, 160, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2>สถานะงานของฉัน</h2>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(298, 41, false);
#line 14 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml"
               Write(Html.DisplayNameFor(model => model.jname));

#line default
#line hidden
            EndContext();
            BeginContext(339, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(407, 43, false);
#line 17 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml"
               Write(Html.DisplayNameFor(model => model.jdatail));

#line default
#line hidden
            EndContext();
            BeginContext(450, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(518, 44, false);
#line 20 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml"
               Write(Html.DisplayNameFor(model => model.jaddress));

#line default
#line hidden
            EndContext();
            BeginContext(562, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(630, 43, false);
#line 23 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml"
               Write(Html.DisplayNameFor(model => model.jstatus));

#line default
#line hidden
            EndContext();
            BeginContext(673, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 29 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(836, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(909, 40, false);
#line 33 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml"
                   Write(Html.DisplayFor(modelItem => item.jname));

#line default
#line hidden
            EndContext();
            BeginContext(949, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1029, 42, false);
#line 36 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml"
                   Write(Html.DisplayFor(modelItem => item.jdatail));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1151, 43, false);
#line 39 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml"
                   Write(Html.DisplayFor(modelItem => item.jaddress));

#line default
#line hidden
            EndContext();
            BeginContext(1194, 55, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 42 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml"
                         if (item.jstatus == "1")
                        {

#line default
#line hidden
            BeginContext(1325, 22, true);
            WriteLiteral("<div>รอการยืนยัน</div>");
            EndContext();
#line 43 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml"
                                               }
                        else if (item.jstatus == "2")
                        {

#line default
#line hidden
            BeginContext(1430, 22, true);
            WriteLiteral("<div>อนุมัติแล้ว</div>");
            EndContext();
#line 45 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml"
                                               }
                        else if (item.jstatus == "3")
                        {

#line default
#line hidden
            BeginContext(1535, 22, true);
            WriteLiteral("<div>ทำเสร็จแล้ว</div>");
            EndContext();
#line 47 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml"
                                               }

#line default
#line hidden
            BeginContext(1560, 53, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 50 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml"
                         if (item.jstatus == "2")
                        {

#line default
#line hidden
            BeginContext(1690, 60, false);
#line 51 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml"
                    Write(Html.ActionLink("Details", "Details", new { id = item._id }));

#line default
#line hidden
            EndContext();
#line 51 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml"
                                                                                      }

#line default
#line hidden
            BeginContext(1753, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 54 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_1.cshtml"
            }

#line default
#line hidden
            BeginContext(1818, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<session.Models.Confirmed>> Html { get; private set; }
    }
}
#pragma warning restore 1591
