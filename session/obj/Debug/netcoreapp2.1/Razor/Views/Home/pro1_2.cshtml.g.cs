#pragma checksum "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86ad10a5f9e9df78d748a7e5b02f41fd6ae82e1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_pro1_2), @"mvc.1.0.view", @"/Views/Home/pro1_2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/pro1_2.cshtml", typeof(AspNetCore.Views_Home_pro1_2))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86ad10a5f9e9df78d748a7e5b02f41fd6ae82e1d", @"/Views/Home/pro1_2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40724393d212a7492650e68aebf3ec0dc20d4b7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_pro1_2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<session.Models.HIRE>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
  
    ViewData["Title"] = "pro1_2";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(132, 124, true);
            WriteLiteral("<br>\r\n<h2>งานนที่ถูกว่าจ้าง</h2>\r\n<br>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(257, 41, false);
#line 14 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayNameFor(model => model.jname));

#line default
#line hidden
            EndContext();
            BeginContext(298, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(354, 43, false);
#line 17 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayNameFor(model => model.jdatail));

#line default
#line hidden
            EndContext();
            BeginContext(397, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(453, 44, false);
#line 20 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayNameFor(model => model.jaddress));

#line default
#line hidden
            EndContext();
            BeginContext(497, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(553, 42, false);
#line 23 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayNameFor(model => model.jprice));

#line default
#line hidden
            EndContext();
            BeginContext(595, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(651, 42, false);
#line 26 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
            EndContext();
            BeginContext(693, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(828, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(889, 40, false);
#line 36 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
               Write(Html.DisplayFor(modelItem => item.jname));

#line default
#line hidden
            EndContext();
            BeginContext(929, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(997, 42, false);
#line 39 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
               Write(Html.DisplayFor(modelItem => item.jdatail));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1107, 43, false);
#line 42 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
               Write(Html.DisplayFor(modelItem => item.jaddress));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1218, 41, false);
#line 45 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
               Write(Html.DisplayFor(modelItem => item.jprice));

#line default
#line hidden
            EndContext();
            BeginContext(1259, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 48 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
                     if (item.status == "1")
                    {

#line default
#line hidden
            BeginContext(1375, 51, true);
            WriteLiteral("                        <div>กำลังดำเนินการ</div>\r\n");
            EndContext();
#line 51 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
                    }
                    else if (item.status == "2")
                    {

#line default
#line hidden
            BeginContext(1522, 48, true);
            WriteLiteral("                        <div>สำเร็จแล้ว!</div>\r\n");
            EndContext();
#line 55 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
                    }

#line default
#line hidden
            BeginContext(1593, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 58 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
                     if (item.status == null)
                    {
                            

#line default
#line hidden
            BeginContext(1737, 87, false);
#line 60 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
                       Write(Html.ActionLink("ยอมรับ", "select", new { id = item._id },new { @class="btn btn-info"}));

#line default
#line hidden
            EndContext();
            BeginContext(1855, 95, false);
#line 61 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
                       Write(Html.ActionLink("ไม่รับงานนี้", "Delete", new { id = item._id },new { @class="btn btn-danger"}));

#line default
#line hidden
            EndContext();
#line 61 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
                                                                                                                            
                    }
                    else if (item.status == "1")
                    {
                        

#line default
#line hidden
            BeginContext(2073, 107, false);
#line 65 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
                   Write(Html.ActionLink("รายละเอียดการติดต่อ", "Detailsjob", new { id = item._id },new { @class="btn btn-warning"}));

#line default
#line hidden
            EndContext();
#line 65 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
                                                                                                                                    
                    }

#line default
#line hidden
            BeginContext(2205, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 70 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\pro1_2.cshtml"
        }

#line default
#line hidden
            BeginContext(2260, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<session.Models.HIRE>> Html { get; private set; }
    }
}
#pragma warning restore 1591
