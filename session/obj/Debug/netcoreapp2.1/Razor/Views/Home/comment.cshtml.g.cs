#pragma checksum "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8038ad9f082d4602acb146e88390c7d977262abc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_comment), @"mvc.1.0.view", @"/Views/Home/comment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/comment.cshtml", typeof(AspNetCore.Views_Home_comment))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8038ad9f082d4602acb146e88390c7d977262abc", @"/Views/Home/comment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40724393d212a7492650e68aebf3ec0dc20d4b7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_comment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<session.Models.Star>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
  
    ViewData["Title"] = "comment";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(133, 380, true);
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">
<style>
    .checked {
        color: orange;
    }
</style>

<br>
<br>
<h2>คะแนนและความคิดเห็น</h2>
<hr />

<div class=""container"">
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>
                    ");
            EndContext();
            BeginContext(514, 43, false);
#line 25 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
               Write(Html.DisplayNameFor(model => model.namejob));

#line default
#line hidden
            EndContext();
            BeginContext(557, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(625, 45, false);
#line 28 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
               Write(Html.DisplayNameFor(model => model.detailjob));

#line default
#line hidden
            EndContext();
            BeginContext(670, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(738, 45, false);
#line 31 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
               Write(Html.DisplayNameFor(model => model.namesesid));

#line default
#line hidden
            EndContext();
            BeginContext(783, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(851, 43, false);
#line 34 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
               Write(Html.DisplayNameFor(model => model.comment));

#line default
#line hidden
            EndContext();
            BeginContext(894, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(962, 40, false);
#line 37 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
               Write(Html.DisplayNameFor(model => model.star));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 43 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1165, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1238, 42, false);
#line 47 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
                   Write(Html.DisplayFor(modelItem => item.namejob));

#line default
#line hidden
            EndContext();
            BeginContext(1280, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1360, 44, false);
#line 50 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
                   Write(Html.DisplayFor(modelItem => item.detailjob));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1484, 44, false);
#line 53 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
                   Write(Html.DisplayFor(modelItem => item.namesesid));

#line default
#line hidden
            EndContext();
            BeginContext(1528, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1608, 42, false);
#line 56 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
                   Write(Html.DisplayFor(modelItem => item.comment));

#line default
#line hidden
            EndContext();
            BeginContext(1650, 55, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            EndContext();
#line 59 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
                         if (item.star == "1")
                        {

#line default
#line hidden
            BeginContext(1780, 198, true);
            WriteLiteral("                            <span class=\"fa fa-star checked\"></span><span class=\"fa fa-star\"></span><span class=\"fa fa-star\"></span><span class=\"fa fa-star\"></span><span class=\"fa fa-star\"></span>\r\n");
            EndContext();
#line 62 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
                        }
                        else if (item.star == "2")
                        {

#line default
#line hidden
            BeginContext(2084, 206, true);
            WriteLiteral("                            <span class=\"fa fa-star checked\"></span><span class=\"fa fa-star checked\"></span><span class=\"fa fa-star\"></span><span class=\"fa fa-star\"></span><span class=\"fa fa-star\"></span>\r\n");
            EndContext();
#line 66 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
                        }
                        else if (item.star == "3")
                        {

#line default
#line hidden
            BeginContext(2396, 214, true);
            WriteLiteral("                            <span class=\"fa fa-star checked\"></span><span class=\"fa fa-star checked\"></span><span class=\"fa fa-star checked\"></span><span class=\"fa fa-star\"></span><span class=\"fa fa-star\"></span>\r\n");
            EndContext();
#line 70 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
                        }
                        else if (item.star == "4")
                        {

#line default
#line hidden
            BeginContext(2716, 222, true);
            WriteLiteral("                            <span class=\"fa fa-star checked\"></span><span class=\"fa fa-star checked\"></span><span class=\"fa fa-star checked\"></span><span class=\"fa fa-star checked\"></span><span class=\"fa fa-star\"></span>\r\n");
            EndContext();
#line 74 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
                        }
                        else if (item.star == "5")
                        {

#line default
#line hidden
            BeginContext(3044, 230, true);
            WriteLiteral("                            <span class=\"fa fa-star checked\"></span><span class=\"fa fa-star checked\"></span><span class=\"fa fa-star checked\"></span><span class=\"fa fa-star checked\"></span><span class=\"fa fa-star checked\"></span>\r\n");
            EndContext();
#line 78 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
                        }

#line default
#line hidden
            BeginContext(3301, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 81 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\comment.cshtml"
            }

#line default
#line hidden
            BeginContext(3366, 38, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<session.Models.Star>> Html { get; private set; }
    }
}
#pragma warning restore 1591
