#pragma checksum "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1c0a9b3974854959c696291f0be355802661296"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_conf), @"mvc.1.0.view", @"/Views/Home/conf.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/conf.cshtml", typeof(AspNetCore.Views_Home_conf))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1c0a9b3974854959c696291f0be355802661296", @"/Views/Home/conf.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40724393d212a7492650e68aebf3ec0dc20d4b7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_conf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<session.Models.Confirmed>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
  
    ViewData["Title"] = "conf";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 332, true);
            WriteLiteral(@"<br>
<br>

<h2>คนที่รับงานนี้ </h2>
<hr />

<table class=""table"">
    <thead>
        <tr>
            <th>
                ชื่องาน
            </th>
            <th>
                คนรับงาน
            </th>
            <th>
                สถานะงาน
            </th>
        </tr>
    </thead>
    <tbody>

");
            EndContext();
#line 29 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#line 31 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
             if (item.jstatus == "1")
            {

#line default
#line hidden
            BeginContext(570, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(643, 40, false);
#line 35 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
                   Write(Html.DisplayFor(modelItem => item.jname));

#line default
#line hidden
            EndContext();
            BeginContext(683, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(763, 41, false);
#line 38 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nsesid));

#line default
#line hidden
            EndContext();
            BeginContext(804, 55, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 41 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
                         if (item.jstatus == "1")
                        {
                            

#line default
#line hidden
            BeginContext(966, 95, false);
#line 43 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
                       Write(Html.ActionLink("เลือกคนนี้", "get", new { id = item.Jid }, new { @class = "btn btn-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 92, false);
#line 44 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
                       Write(Html.ActionLink("ไม่เลือก", "del", new { id = item.Jid }, new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
#line 44 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
                                                                                                                         
                        }

#line default
#line hidden
            BeginContext(1213, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 48 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
            }
            else if (item.jstatus == "2" || item.jstatus == "3" || item.jstatus == "4")
            {

#line default
#line hidden
            BeginContext(1382, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1455, 40, false);
#line 53 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
                   Write(Html.DisplayFor(modelItem => item.jname));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1575, 41, false);
#line 56 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nsesid));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 55, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 59 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
                         if (item.jstatus == "2")
                        {

#line default
#line hidden
            BeginContext(1749, 55, true);
            WriteLiteral("                            <div>กำลังดำเนินการ</div>\r\n");
            EndContext();
#line 62 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
                        }
                        else if (item.jstatus == "3")
                        {

#line default
#line hidden
            BeginContext(1913, 61, true);
            WriteLiteral("                            <div>ดำเนินงานเสร็จแล้ว!!</div>\r\n");
            EndContext();
#line 66 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
                        }
                        else if (item.jstatus == "4")
                        {

#line default
#line hidden
            BeginContext(2083, 52, true);
            WriteLiteral("                            <div>เรียบร้อย!!</div>\r\n");
            EndContext();
#line 70 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
                        }

#line default
#line hidden
            BeginContext(2162, 53, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 73 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
                         if (item.jstatus == "3")
                        {
                            

#line default
#line hidden
            BeginContext(2322, 94, false);
#line 75 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
                       Write(Html.ActionLink("ยืนยัน", "finish", new { id = item.Jid }, new { @class = "btn btn-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(2418, 89, true);
            WriteLiteral("                            <a href=\"#\" class=\"btn btn-danger\" role=\"button\">รายงาน</a>\r\n");
            EndContext();
#line 77 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
                        }

#line default
#line hidden
            BeginContext(2534, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 80 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
            }

#line default
#line hidden
#line 80 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\conf.cshtml"
             
        }

#line default
#line hidden
            BeginContext(2610, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
