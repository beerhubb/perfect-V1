#pragma checksum "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f63cd7f1f7286022e10fd93aedaa591d1583b1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_job3), @"mvc.1.0.view", @"/Views/Home/job3.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/job3.cshtml", typeof(AspNetCore.Views_Home_job3))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f63cd7f1f7286022e10fd93aedaa591d1583b1a", @"/Views/Home/job3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40724393d212a7492650e68aebf3ec0dc20d4b7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_job3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<session.Models.Jregister>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
  
    ViewData["Title"] = "job3";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 204, true);
            WriteLiteral("<br>\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">งานใช้แรงในพื้นที่ศรีสะเกษ</h1>\r\n</div>\r\n<hr style=\"border: 2px solid Gray;\" />\r\n<div class=\"container-fluid topDest\">\r\n    <div class=\"row\">\r\n\r\n");
            EndContext();
#line 15 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
         foreach (var item in Model)
        {
            if (item.jstatus != "2" && item.jstatus != "3")
            {
                if (item.date != null)
                {
                    string[] splinnn = item.date.Split('-');
                    var yy = splinnn[0].ToString();
                    var mm = splinnn[1].ToString();
                    var dd = splinnn[2].ToString();
                    int yyy = int.Parse(yy);
                    int mmm = int.Parse(mm);
                    int ddd = int.Parse(dd);
                    var checkyyy = DateTime.Now.ToString("yyyy");
                    var checkmm = DateTime.Now.ToString("MM");
                    var checkdd = DateTime.Now.ToString("dd");
                    var intyy = int.Parse(checkyyy);
                    var intmm = int.Parse(checkmm);
                    var intdd = int.Parse(checkdd);
                    if (mmm >= intmm && ddd >= intdd && (yyy + 543) >= intyy)
                    {

#line default
#line hidden
            BeginContext(1339, 264, true);
            WriteLiteral(@"                        <div class=""col-md-3 col-sm-6 col-xs-12"">
                            <a href=""#myModal"" data-toggle=""modal"" class=""destLinks"">
                                <div class=""destiBoxWrap col-sm-12"">
                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1603, "\"", 1650, 1);
#line 39 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
WriteAttributeValue("", 1609, Html.DisplayFor(model => item.jpictrue1), 1609, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1651, 176, true);
            WriteLiteral(" alt=\"Image\" title=\"Project\" class=\"img-responsive width100\">\r\n                                    <div class=\"destiBox hangBox\">\r\n                                        <h4> ");
            EndContext();
            BeginContext(1828, 36, false);
#line 41 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                        Write(Html.DisplayFor(model => item.jname));

#line default
#line hidden
            EndContext();
            BeginContext(1864, 52, true);
            WriteLiteral("</h4>\r\n                                        <h5> ");
            EndContext();
            BeginContext(1917, 38, false);
#line 42 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                        Write(Html.DisplayFor(model => item.jdatail));

#line default
#line hidden
            EndContext();
            BeginContext(1955, 61, true);
            WriteLiteral(" </h5>\r\n                                        <h5>วันที่ - ");
            EndContext();
            BeginContext(2017, 35, false);
#line 43 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                Write(Html.DisplayFor(model => item.date));

#line default
#line hidden
            EndContext();
            BeginContext(2052, 70, true);
            WriteLiteral("</h5>\r\n                                        <h4 class=\"col1\">ราคา: ");
            EndContext();
            BeginContext(2123, 38, false);
#line 44 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                          Write(Html.DisplayFor(modell => item.jprice));

#line default
#line hidden
            EndContext();
            BeginContext(2161, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 45 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                         if (@ViewBag.use != null && ViewBag.status == "1")
                                        {
                                            

#line default
#line hidden
            BeginContext(2349, 127, false);
#line 47 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                       Write(Html.ActionLink("ลงชื่อรับงาน", "Confirmed", new { id = item._id }, new { @class = "btn btn-info", onclick = "displayDate()" }));

#line default
#line hidden
            EndContext();
            BeginContext(2478, 321, true);
            WriteLiteral(@"                                            <script>
                                                function displayDate() {
                                                    alert(""คุณได้กดรับงานนนี้แล้ว!"");
                                                }
                                            </script>
");
            EndContext();
#line 53 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(2931, 125, true);
            WriteLiteral("                                            <a href=\"Home/Login\" class=\"btn btn-success\" role=\"button\">เข้าสู่ระบบก่อน!</a>\r\n");
            EndContext();
#line 57 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3099, 150, true);
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                            </a>\r\n                        </div>\r\n");
            EndContext();
#line 62 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                    }
                }
            }
        }

#line default
#line hidden
            BeginContext(3317, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
