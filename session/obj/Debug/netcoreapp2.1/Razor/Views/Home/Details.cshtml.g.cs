#pragma checksum "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bf142f691eedec48cd34ad9c7f004ad7d9c7d3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bf142f691eedec48cd34ad9c7f004ad7d9c7d3a", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40724393d212a7492650e68aebf3ec0dc20d4b7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<session.Models.Confirmed>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(125, 111, true);
            WriteLiteral("\r\n<h2>รายละเอียดของงานนี้</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(237, 41, false);
#line 14 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.jname));

#line default
#line hidden
            EndContext();
            BeginContext(278, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(322, 37, false);
#line 17 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.jname));

#line default
#line hidden
            EndContext();
            BeginContext(359, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(403, 45, false);
#line 20 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.jpictrue1));

#line default
#line hidden
            EndContext();
            BeginContext(448, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(492, 41, false);
#line 23 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.jpictrue1));

#line default
#line hidden
            EndContext();
            BeginContext(533, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(577, 45, false);
#line 26 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.jpictrue2));

#line default
#line hidden
            EndContext();
            BeginContext(622, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(666, 41, false);
#line 29 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.jpictrue2));

#line default
#line hidden
            EndContext();
            BeginContext(707, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(751, 45, false);
#line 32 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.jpictrue3));

#line default
#line hidden
            EndContext();
            BeginContext(796, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(840, 41, false);
#line 35 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.jpictrue3));

#line default
#line hidden
            EndContext();
            BeginContext(881, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(925, 43, false);
#line 38 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.jdatail));

#line default
#line hidden
            EndContext();
            BeginContext(968, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1012, 39, false);
#line 41 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.jdatail));

#line default
#line hidden
            EndContext();
            BeginContext(1051, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1095, 44, false);
#line 44 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.jaddress));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1183, 40, false);
#line 47 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.jaddress));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1267, 42, false);
#line 50 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.jprice));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1353, 38, false);
#line 53 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.jprice));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1435, 41, false);
#line 56 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.jline));

#line default
#line hidden
            EndContext();
            BeginContext(1476, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1520, 37, false);
#line 59 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.jline));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1601, 42, false);
#line 62 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.jphone));

#line default
#line hidden
            EndContext();
            BeginContext(1643, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1687, 38, false);
#line 65 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.jphone));

#line default
#line hidden
            EndContext();
            BeginContext(1725, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1773, 59, false);
#line 70 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\Details.cshtml"
Write(Html.ActionLink("เสร็จแล้ว", "OK", new {  id = Model._id }));

#line default
#line hidden
            EndContext();
            BeginContext(1832, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1840, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddebda3f97734cfa8ee4f5ead1f8188a", async() => {
                BeginContext(1862, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1878, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<session.Models.Confirmed> Html { get; private set; }
    }
}
#pragma warning restore 1591
