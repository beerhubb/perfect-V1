#pragma checksum "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5749589697ba6f175063f82ad29698a529b7e957"
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
#line 1 "C:\Users\ACER\source\repos\session\session\Views\_ViewImports.cshtml"
using session;

#line default
#line hidden
#line 2 "C:\Users\ACER\source\repos\session\session\Views\_ViewImports.cshtml"
using session.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5749589697ba6f175063f82ad29698a529b7e957", @"/Views/Home/pro1_2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40724393d212a7492650e68aebf3ec0dc20d4b7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_pro1_2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<session.Models.HIRE>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
  
    ViewData["Title"] = "pro1_2";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(132, 115, true);
            WriteLiteral("\r\n<h2>งานที่ถูกว่าจ้าง</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(248, 41, false);
#line 14 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayNameFor(model => model.jname));

#line default
#line hidden
            EndContext();
            BeginContext(289, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(345, 45, false);
#line 17 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayNameFor(model => model.jpictrue1));

#line default
#line hidden
            EndContext();
            BeginContext(390, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(446, 45, false);
#line 20 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayNameFor(model => model.jpictrue2));

#line default
#line hidden
            EndContext();
            BeginContext(491, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(547, 45, false);
#line 23 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayNameFor(model => model.jpictrue3));

#line default
#line hidden
            EndContext();
            BeginContext(592, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(648, 43, false);
#line 26 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayNameFor(model => model.jdatail));

#line default
#line hidden
            EndContext();
            BeginContext(691, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(747, 44, false);
#line 29 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayNameFor(model => model.jaddress));

#line default
#line hidden
            EndContext();
            BeginContext(791, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(847, 42, false);
#line 32 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayNameFor(model => model.jprice));

#line default
#line hidden
            EndContext();
            BeginContext(889, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(945, 41, false);
#line 35 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayNameFor(model => model.jline));

#line default
#line hidden
            EndContext();
            BeginContext(986, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1042, 42, false);
#line 38 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayNameFor(model => model.jphone));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 44 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1202, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1251, 40, false);
#line 47 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayFor(modelItem => item.jname));

#line default
#line hidden
            EndContext();
            BeginContext(1291, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1347, 44, false);
#line 50 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayFor(modelItem => item.jpictrue1));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1447, 44, false);
#line 53 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayFor(modelItem => item.jpictrue2));

#line default
#line hidden
            EndContext();
            BeginContext(1491, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1547, 44, false);
#line 56 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayFor(modelItem => item.jpictrue3));

#line default
#line hidden
            EndContext();
            BeginContext(1591, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1647, 42, false);
#line 59 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayFor(modelItem => item.jdatail));

#line default
#line hidden
            EndContext();
            BeginContext(1689, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1745, 43, false);
#line 62 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayFor(modelItem => item.jaddress));

#line default
#line hidden
            EndContext();
            BeginContext(1788, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1844, 41, false);
#line 65 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayFor(modelItem => item.jprice));

#line default
#line hidden
            EndContext();
            BeginContext(1885, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1941, 40, false);
#line 68 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayFor(modelItem => item.jline));

#line default
#line hidden
            EndContext();
            BeginContext(1981, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2037, 41, false);
#line 71 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.DisplayFor(modelItem => item.jphone));

#line default
#line hidden
            EndContext();
            BeginContext(2078, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2134, 65, false);
#line 74 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2199, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2220, 71, false);
#line 75 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2291, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2312, 69, false);
#line 76 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2381, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 79 "C:\Users\ACER\source\repos\session\session\Views\Home\pro1_2.cshtml"
}

#line default
#line hidden
            BeginContext(2420, 24, true);
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