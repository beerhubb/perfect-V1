#pragma checksum "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc746c902bdd3ac4641c4653980be92d8ffa25c2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc746c902bdd3ac4641c4653980be92d8ffa25c2", @"/Views/Home/job3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40724393d212a7492650e68aebf3ec0dc20d4b7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_job3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<session.Models.Jregister>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
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
            BeginContext(135, 184, true);
            WriteLiteral("<br>\r\n<div class=\"text-center\">\r\n    <h1 >งานใช้แรงในพื้นที่ศรีสะเกษ</h1>\r\n</div>\r\n<hr style=\"border: 2px solid Gray;\" />\r\n<section class=\"py-1 bg-info\">\r\n    <div class=\"container\">\r\n");
            EndContext();
#line 14 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
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
                    string checkyyy = DateTime.Now.ToString("yyyy");
                    var checkmm = DateTime.Now.ToString("MM");
                    var checkdd = DateTime.Now.ToString("dd");
                    var intyy = int.Parse(checkyyy);
                    var intmm = int.Parse(checkmm);
                    var intdd = int.Parse(checkdd);
                    if (yyy + 543 >= intyy)
                    {
                        if (mmm == intmm)
                        {
                            if (ddd >= intdd)
                            {

#line default
#line hidden
            BeginContext(1436, 474, true);
            WriteLiteral(@"                                <div class=""row mb-3"">
                                    <div class=""col-md-12"">
                                        <div class=""card shadow"">
                                            <div class=""card-body"">
                                                <div class=""row text-center "">
                                                    <div class=""col-md-2 mr-2"">
                                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1910, "\"", 1957, 1);
#line 45 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
WriteAttributeValue("", 1916, Html.DisplayFor(model => item.jpictrue1), 1916, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1958, 263, true);
            WriteLiteral(@" alt=""Image"" title=""Project"" class=""img-responsive width100"">
                                                    </div>
                                                    <div class=""col-md-6"">
                                                        <h3><b> ");
            EndContext();
            BeginContext(2222, 36, false);
#line 48 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                           Write(Html.DisplayFor(model => item.jname));

#line default
#line hidden
            EndContext();
            BeginContext(2258, 90, true);
            WriteLiteral("</b></h3>\r\n                                                        <h5><b>รายละเอียด</b>: ");
            EndContext();
            BeginContext(2349, 38, false);
#line 49 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                                          Write(Html.DisplayFor(model => item.jdatail));

#line default
#line hidden
            EndContext();
            BeginContext(2387, 225, true);
            WriteLiteral(" </h5>\r\n                                                    </div>\r\n                                                    <div class=\"col-md-3\">\r\n                                                        <h5 class=\"col1\">วันที่: ");
            EndContext();
            BeginContext(2613, 35, false);
#line 52 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                                            Write(Html.DisplayFor(model => item.date));

#line default
#line hidden
            EndContext();
            BeginContext(2648, 86, true);
            WriteLiteral("</h5>\r\n                                                        <h4 class=\"col1\">ราคา: ");
            EndContext();
            BeginContext(2735, 38, false);
#line 53 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                                          Write(Html.DisplayFor(modell => item.jprice));

#line default
#line hidden
            EndContext();
            BeginContext(2773, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 54 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                         if (ViewBag.use != null && ViewBag.status == "1")
                                                        {
                                                            

#line default
#line hidden
            BeginContext(3008, 127, false);
#line 56 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                       Write(Html.ActionLink("ลงชื่อรับงาน", "Confirmed", new { id = item._id }, new { @class = "btn btn-info", onclick = "displayDate()" }));

#line default
#line hidden
            EndContext();
            BeginContext(3137, 401, true);
            WriteLiteral(@"                                                            <script>
                                                                function displayDate() {
                                                                    alert(""คุณได้กดรับงานนนี้แล้ว!"");
                                                                }
                                                            </script>
");
            EndContext();
#line 62 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
            BeginContext(3718, 60, true);
            WriteLiteral("                                                            ");
            EndContext();
            BeginContext(3778, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "309344cb55a44f8aad77a3a0328dd787", async() => {
                BeginContext(3869, 16, true);
                WriteLiteral("เข้าสู่ระบบก่อน!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3889, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 66 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                        }

#line default
#line hidden
            BeginContext(3950, 300, true);
            WriteLiteral(@"                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
            EndContext();
#line 73 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                            }
                        }
                        if (mmm != intmm)
                        {

#line default
#line hidden
            BeginContext(4378, 446, true);
            WriteLiteral(@"                            <div class=""row mb-3"">
                                <div class=""col-md-12"">
                                    <div class=""card shadow"">
                                        <div class=""card-body"">
                                            <div class=""row text-center "">
                                                <div class=""col-md-2 mr-2"">
                                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4824, "\"", 4871, 1);
#line 83 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
WriteAttributeValue("", 4830, Html.DisplayFor(model => item.jpictrue1), 4830, 41, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4872, 251, true);
            WriteLiteral(" alt=\"Image\" title=\"Project\" class=\"img-responsive width100\">\r\n                                                </div>\r\n                                                <div class=\"col-md-6\">\r\n                                                    <h3><b> ");
            EndContext();
            BeginContext(5124, 36, false);
#line 86 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                       Write(Html.DisplayFor(model => item.jname));

#line default
#line hidden
            EndContext();
            BeginContext(5160, 86, true);
            WriteLiteral("</b></h3>\r\n                                                    <h5><b>รายละเอียด</b>: ");
            EndContext();
            BeginContext(5247, 38, false);
#line 87 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                                      Write(Html.DisplayFor(model => item.jdatail));

#line default
#line hidden
            EndContext();
            BeginContext(5285, 213, true);
            WriteLiteral(" </h5>\r\n                                                </div>\r\n                                                <div class=\"col-md-3\">\r\n                                                    <h5 class=\"col1\">วันที่: ");
            EndContext();
            BeginContext(5499, 35, false);
#line 90 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                                        Write(Html.DisplayFor(model => item.date));

#line default
#line hidden
            EndContext();
            BeginContext(5534, 82, true);
            WriteLiteral("</h5>\r\n                                                    <h4 class=\"col1\">ราคา: ");
            EndContext();
            BeginContext(5617, 38, false);
#line 91 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                                      Write(Html.DisplayFor(modell => item.jprice));

#line default
#line hidden
            EndContext();
            BeginContext(5655, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 92 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                     if (ViewBag.use != null && ViewBag.status == "1")
                                                    {
                                                        

#line default
#line hidden
            BeginContext(5878, 127, false);
#line 94 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                   Write(Html.ActionLink("ลงชื่อรับงาน", "Confirmed", new { id = item._id }, new { @class = "btn btn-info", onclick = "displayDate()" }));

#line default
#line hidden
            EndContext();
            BeginContext(6007, 381, true);
            WriteLiteral(@"                                                        <script>
                                                            function displayDate() {
                                                                alert(""คุณได้กดรับงานนนี้แล้ว!"");
                                                            }
                                                        </script>
");
            EndContext();
#line 100 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
            BeginContext(6556, 56, true);
            WriteLiteral("                                                        ");
            EndContext();
            BeginContext(6612, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f5a62f3521d4527a30bfacfc2b2b3ed", async() => {
                BeginContext(6703, 16, true);
                WriteLiteral("เข้าสู่ระบบก่อน!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6723, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 104 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(6780, 276, true);
            WriteLiteral(@"                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
");
            EndContext();
#line 111 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\job3.cshtml"
                        }
                    }
                }
            }
        }

#line default
#line hidden
            BeginContext(7151, 24, true);
            WriteLiteral("    </div>\r\n</section>\r\n");
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
