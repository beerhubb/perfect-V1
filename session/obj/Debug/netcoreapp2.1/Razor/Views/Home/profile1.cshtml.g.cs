#pragma checksum "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b51b51b7fd336e03a35943507c6fcd41fa0d563b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_profile1), @"mvc.1.0.view", @"/Views/Home/profile1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/profile1.cshtml", typeof(AspNetCore.Views_Home_profile1))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b51b51b7fd336e03a35943507c6fcd41fa0d563b", @"/Views/Home/profile1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40724393d212a7492650e68aebf3ec0dc20d4b7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_profile1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<session.Models.Confirmed>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
  
    ViewData["Title"] = "profile1";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 298, true);
            WriteLiteral(@"<style>
    .details li {
        list-style: none;
    }

    li {
        margin-bottom: 10px;
    }
</style>
<br>
<br>
<div class=""container"">
    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-4 col-xs-12 col-sm-6 col-lg-4"">
                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 437, "\"", 459, 1);
#line 22 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
WriteAttributeValue("", 443, ViewBag.pictrue, 443, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(460, 251, true);
            WriteLiteral(" alt=\"stack photo\" class=\"img\" width=\"280\" height=\"230\">\r\n            </div>\r\n            <div class=\"col-md-6 col-xs-12 col-sm-6 col-lg-8\">\r\n                <div class=\"container\" style=\"border-bottom: 1px solid black\">\r\n                    <h2>ชื่อ ");
            EndContext();
            BeginContext(712, 12, false);
#line 26 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
                        Write(ViewBag.name);

#line default
#line hidden
            EndContext();
            BeginContext(724, 229, true);
            WriteLiteral("</h2>\r\n                </div>\r\n                <ul class=\"container details\">\r\n                    <div class=\"col-md-6 col-sm-6\">\r\n                        <li><p><span class=\"glyphicon glyphicon-user\" style=\"width:50px;\"></span>");
            EndContext();
            BeginContext(954, 11, false);
#line 30 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
                                                                                            Write(ViewBag.age);

#line default
#line hidden
            EndContext();
            BeginContext(965, 14, true);
            WriteLiteral(" ปี</p></li>\r\n");
            EndContext();
#line 31 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
                         if (ViewBag.status == "1")
                        {

#line default
#line hidden
            BeginContext(1059, 124, true);
            WriteLiteral("                            <li><p><span class=\"glyphicon glyphicon-ok-sign\" style=\"width:50px;\"></span>ผู้รับงาน</p></li>\r\n");
            EndContext();
#line 34 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
                        }

#line default
#line hidden
            BeginContext(1210, 107, true);
            WriteLiteral("                        <li><p><span class=\"glyphicon glyphicon-map-marker one\" style=\"width:50px;\"></span>");
            EndContext();
            BeginContext(1318, 11, false);
#line 35 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
                                                                                                      Write(ViewBag.add);

#line default
#line hidden
            EndContext();
            BeginContext(1329, 35, true);
            WriteLiteral("</p></li>\r\n                        ");
            EndContext();
            BeginContext(1365, 107, false);
#line 36 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
                   Write(Html.ActionLink("แก้ไขโปรไฟล์", "editprofile", new { id = ViewBag.id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 306, true);
            WriteLiteral(@"
                    </div>
                </ul>
            </div>
        </div>
    </div>
</div>

<a href=""pro1_2"" class=""btn btn-success"" role=""button"">งานที่ถูกว่าจ้าง</a>

<br>
<br>
<h2>งานของฉัน</h2>
<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
            EndContext();
            BeginContext(1779, 41, false);
#line 53 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
           Write(Html.DisplayNameFor(model => model.jname));

#line default
#line hidden
            EndContext();
            BeginContext(1820, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1876, 43, false);
#line 56 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
           Write(Html.DisplayNameFor(model => model.jdatail));

#line default
#line hidden
            EndContext();
            BeginContext(1919, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1975, 44, false);
#line 59 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
           Write(Html.DisplayNameFor(model => model.jaddress));

#line default
#line hidden
            EndContext();
            BeginContext(2019, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2075, 43, false);
#line 62 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
           Write(Html.DisplayNameFor(model => model.jstatus));

#line default
#line hidden
            EndContext();
            BeginContext(2118, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 68 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(2253, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2314, 40, false);
#line 72 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
               Write(Html.DisplayFor(modelItem => item.jname));

#line default
#line hidden
            EndContext();
            BeginContext(2354, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2422, 42, false);
#line 75 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
               Write(Html.DisplayFor(modelItem => item.jdatail));

#line default
#line hidden
            EndContext();
            BeginContext(2464, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2532, 43, false);
#line 78 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
               Write(Html.DisplayFor(modelItem => item.jaddress));

#line default
#line hidden
            EndContext();
            BeginContext(2575, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 81 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
                     if (item.jstatus == "1")
                    {

#line default
#line hidden
            BeginContext(2690, 22, true);
            WriteLiteral("<div>รอการยืนยัน</div>");
            EndContext();
#line 82 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
                                           }
                    else if (item.jstatus == "2")
                    {

#line default
#line hidden
            BeginContext(2787, 22, true);
            WriteLiteral("<div>อนุมัติแล้ว</div>");
            EndContext();
#line 84 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
                                           }
                    else if (item.jstatus == "3")
                    {

#line default
#line hidden
            BeginContext(2884, 22, true);
            WriteLiteral("<div>ทำเสร็จแล้ว</div>");
            EndContext();
#line 86 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
                                           }
                    else if (item.jstatus == "4")
                    {

#line default
#line hidden
            BeginContext(2983, 46, true);
            WriteLiteral("                        <div>สำเสร็จ!!</div>\r\n");
            EndContext();
#line 90 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
                    }

#line default
#line hidden
            BeginContext(3052, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 93 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
                     if (item.jstatus == "2")
                    {

#line default
#line hidden
            BeginContext(3166, 99, false);
#line 94 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
                Write(Html.ActionLink("รายละเอียด", "Details", new { id = item._id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
            EndContext();
#line 94 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
                                                                                                                         }

#line default
#line hidden
            BeginContext(3268, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 97 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\profile1.cshtml"
        }

#line default
#line hidden
            BeginContext(3321, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<session.Models.Confirmed>> Html { get; private set; }
    }
}
#pragma warning restore 1591
