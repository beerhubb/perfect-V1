#pragma checksum "C:\Users\ACER\source\repos\session\session\Views\Home\maid.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa7ab84c72da9bb6dd1a3d43045a897cab3e28fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_maid), @"mvc.1.0.view", @"/Views/Home/maid.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/maid.cshtml", typeof(AspNetCore.Views_Home_maid))]
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
#line 1 "C:\Users\ACER\source\repos\session\session\Views\_ViewImports.cshtml"
using session;

#line default
#line hidden
#line 2 "C:\Users\ACER\source\repos\session\session\Views\_ViewImports.cshtml"
using session.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa7ab84c72da9bb6dd1a3d43045a897cab3e28fc", @"/Views/Home/maid.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40724393d212a7492650e68aebf3ec0dc20d4b7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_maid : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<session.Models.Register>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ACER\source\repos\session\session\Views\Home\maid.cshtml"
  
    ViewData["Title"] = "maid";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(134, 76, true);
            WriteLiteral("\r\n<h2>แม่บ้านของเรา</h2>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 12 "C:\Users\ACER\source\repos\session\session\Views\Home\maid.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
            BeginContext(261, 126, true);
            WriteLiteral("            <h2>Card Image</h2>\r\n            <div class=\"card\" style=\"width:400px\">\r\n                <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 387, "\"", 433, 1);
#line 17 "C:\Users\ACER\source\repos\session\session\Views\Home\maid.cshtml"
WriteAttributeValue("", 393, Html.DisplayFor(model => item.pictrueP), 393, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(434, 122, true);
            WriteLiteral(" alt=\"Card image\" style=\"width:70%\">\r\n                <div class=\"card-body\">\r\n                    <h4 class=\"card-title\">");
            EndContext();
            BeginContext(557, 35, false);
#line 19 "C:\Users\ACER\source\repos\session\session\Views\Home\maid.cshtml"
                                      Write(Html.DisplayFor(model => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(592, 80, true);
            WriteLiteral("</h4>\r\n                    <p class=\"card-text\">\r\n                        อายุ :");
            EndContext();
            BeginContext(673, 34, false);
#line 21 "C:\Users\ACER\source\repos\session\session\Views\Home\maid.cshtml"
                         Write(Html.DisplayFor(model => item.age));

#line default
#line hidden
            EndContext();
            BeginContext(707, 14, true);
            WriteLiteral(" ปี  ที่อยู่ :");
            EndContext();
            BeginContext(722, 38, false);
#line 21 "C:\Users\ACER\source\repos\session\session\Views\Home\maid.cshtml"
                                                                          Write(Html.DisplayFor(model => item.address));

#line default
#line hidden
            EndContext();
            BeginContext(760, 3, true);
            WriteLiteral("   ");
            EndContext();
#line 21 "C:\Users\ACER\source\repos\session\session\Views\Home\maid.cshtml"
                                                                                                                          if (item.status == "1")
                        {

#line default
#line hidden
            BeginContext(814, 16, true);
            WriteLiteral("<h5>แม่บ้าน</h5>");
            EndContext();
#line 22 "C:\Users\ACER\source\repos\session\session\Views\Home\maid.cshtml"
                                         }

#line default
#line hidden
            BeginContext(833, 26, true);
            WriteLiteral("                    </p>\r\n");
            EndContext();
#line 24 "C:\Users\ACER\source\repos\session\session\Views\Home\maid.cshtml"
                     if (ViewBag.use != null && ViewBag.status == "2")
                    {
                        

#line default
#line hidden
            BeginContext(979, 59, false);
#line 26 "C:\Users\ACER\source\repos\session\session\Views\Home\maid.cshtml"
                   Write(Html.ActionLink("จ้างคนนี้", "hire", new { id = item._id }));

#line default
#line hidden
            EndContext();
#line 26 "C:\Users\ACER\source\repos\session\session\Views\Home\maid.cshtml"
                                                                                    
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1112, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1136, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bba490887032434cb0bbc5a7b0c115b2", async() => {
                BeginContext(1192, 23, true);
                WriteLiteral("เข้าสู่ระบบเพื่อจ้างงาน");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1219, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "C:\Users\ACER\source\repos\session\session\Views\Home\maid.cshtml"
                    }

#line default
#line hidden
            BeginContext(1244, 66, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <hr />\r\n");
            EndContext();
#line 38 "C:\Users\ACER\source\repos\session\session\Views\Home\maid.cshtml"
                                                                                         
        }

#line default
#line hidden
            BeginContext(1520, 20, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<session.Models.Register>> Html { get; private set; }
    }
}
#pragma warning restore 1591