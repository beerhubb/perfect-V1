#pragma checksum "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8b2fbd7d52ec41658f40d2a1a8fb925a6cc41e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_job2), @"mvc.1.0.view", @"/Views/Home/job2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/job2.cshtml", typeof(AspNetCore.Views_Home_job2))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8b2fbd7d52ec41658f40d2a1a8fb925a6cc41e4", @"/Views/Home/job2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40724393d212a7492650e68aebf3ec0dc20d4b7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_job2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<session.Models.Jregister>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job2.cshtml"
  
    ViewData["Title"] = "job2";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 160, true);
            WriteLiteral("<br>\r\n<br>\r\n<h2><b>งานสวนในเขตพื้นที่ศรีสะเกษ</b></h2>\r\n<hr style=\"border: 2px solid Gray;\" />\r\n<div class=\"container-fluid topDest\">\r\n    <div class=\"row\">\r\n\r\n");
            EndContext();
#line 14 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job2.cshtml"
         foreach (var item in Model)
        {
            if (item.jstatus != "2")
            {
                if (item.date != null)
                {
                    string[] splinnn = item.date.Split('-');
                    var yy = splinnn[0].ToString();
                    var mm = splinnn[1].ToString();
                    var dd = splinnn[2].ToString();
                    int mmm = int.Parse(mm);
                    int ddd = int.Parse(dd);
                    string checkyyy = DateTime.Now.ToString("yyyy");
                    var checkmm = DateTime.Now.ToString("MM");
                    var checkdd = DateTime.Now.ToString("dd");
                    var intmm = int.Parse(checkmm);
                    var intdd = int.Parse(checkdd);
                    if (mmm >= intmm && ddd >= intdd)
                    {

#line default
#line hidden
            BeginContext(1151, 264, true);
            WriteLiteral(@"                        <div class=""col-md-3 col-sm-6 col-xs-12"">
                            <a href=""#myModal"" data-toggle=""modal"" class=""destLinks"">
                                <div class=""destiBoxWrap col-sm-12"">
                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1415, "\"", 1462, 1);
#line 36 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job2.cshtml"
WriteAttributeValue("", 1421, Html.DisplayFor(model => item.jpictrue1), 1421, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1463, 176, true);
            WriteLiteral(" alt=\"Image\" title=\"Project\" class=\"img-responsive width100\">\r\n                                    <div class=\"destiBox hangBox\">\r\n                                        <h4> ");
            EndContext();
            BeginContext(1640, 36, false);
#line 38 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job2.cshtml"
                                        Write(Html.DisplayFor(model => item.jname));

#line default
#line hidden
            EndContext();
            BeginContext(1676, 52, true);
            WriteLiteral("</h4>\r\n                                        <h5> ");
            EndContext();
            BeginContext(1729, 38, false);
#line 39 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job2.cshtml"
                                        Write(Html.DisplayFor(model => item.jdatail));

#line default
#line hidden
            EndContext();
            BeginContext(1767, 61, true);
            WriteLiteral(" </h5>\r\n                                        <h5>วันที่ - ");
            EndContext();
            BeginContext(1829, 35, false);
#line 40 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job2.cshtml"
                                                Write(Html.DisplayFor(model => item.date));

#line default
#line hidden
            EndContext();
            BeginContext(1864, 70, true);
            WriteLiteral("</h5>\r\n                                        <h4 class=\"col1\">ราคา: ");
            EndContext();
            BeginContext(1935, 38, false);
#line 41 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job2.cshtml"
                                                          Write(Html.DisplayFor(modell => item.jprice));

#line default
#line hidden
            EndContext();
            BeginContext(1973, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 42 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job2.cshtml"
                                         if (@ViewBag.use != null && ViewBag.status == "1")
                                        {
                                            

#line default
#line hidden
            BeginContext(2161, 127, false);
#line 44 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job2.cshtml"
                                       Write(Html.ActionLink("ลงชื่อรับงาน", "Confirmed", new { id = item._id }, new { @class = "btn btn-info", onclick = "displayDate()" }));

#line default
#line hidden
            EndContext();
            BeginContext(2290, 321, true);
            WriteLiteral(@"                                            <script>
                                                function displayDate() {
                                                    alert(""คุณได้กดรับงานนนี้แล้ว!"");
                                                }
                                            </script>
");
            EndContext();
#line 50 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job2.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(2743, 125, true);
            WriteLiteral("                                            <a href=\"Home/Login\" class=\"btn btn-success\" role=\"button\">เข้าสู่ระบบก่อน!</a>\r\n");
            EndContext();
#line 54 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job2.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2911, 150, true);
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </a>\r\n                        </div>\r\n");
            EndContext();
#line 59 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job2.cshtml"
                    }
                }
            }
        }

#line default
#line hidden
            BeginContext(3129, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<session.Models.Jregister>> Html { get; private set; }
    }
}
#pragma warning restore 1591
