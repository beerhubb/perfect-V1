#pragma checksum "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a89b3c70eae1e6f208e69db3536572bc9474a31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_maid1), @"mvc.1.0.view", @"/Views/Home/maid1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/maid1.cshtml", typeof(AspNetCore.Views_Home_maid1))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a89b3c70eae1e6f208e69db3536572bc9474a31", @"/Views/Home/maid1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40724393d212a7492650e68aebf3ec0dc20d4b7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_maid1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<session.Models.Register>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
  
    ViewData["Title"] = "maid1";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 183, true);
            WriteLiteral("\r\n<br>\r\n<br>\r\n<h2><b>ผู้ต้องการงาน</b></h2>\r\n<hr style=\"border: 2px solid Gray;\" />\r\n\r\n<section id=\"team\" class=\"pb-5\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 16 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(375, 514, true);
            WriteLiteral(@"                    <!-- Team member -->
                    <div class=""col-xs-12 col-sm-6 col-md-4"">
                        <div class=""image-flip"" ontouchstart=""this.classList.toggle('hover');"">
                            <div class=""mainflip"">
                                <div class=""frontside"">
                                    <div class=""card"">
                                        <div class=""card-body text-center"">
                                            <p><img class="" img-fluid""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 889, "\"", 935, 1);
#line 25 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
WriteAttributeValue("", 895, Html.DisplayFor(model => item.pictrueP), 895, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(936, 95, true);
            WriteLiteral(" alt=\"card image\"></p>\r\n                                            <h4 class=\"card-title\"><b> ");
            EndContext();
            BeginContext(1032, 35, false);
#line 26 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                                  Write(Html.DisplayFor(model => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 171, true);
            WriteLiteral("</b></h4>\r\n                                            <p class=\"card-text\">\r\n                                                <h4><b>งานที่ถนัด</b></h4><div class=\"row\">\r\n");
            EndContext();
#line 29 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                     if (item.skill1 == "1")
                                                    {

#line default
#line hidden
            BeginContext(1369, 16, true);
            WriteLiteral("<h5>งานบ้าน</h5>");
            EndContext();
#line 30 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                                     }

#line default
#line hidden
            BeginContext(1388, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
#line 31 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                     if (item.skill2 == "2")
                                                    {

#line default
#line hidden
            BeginContext(1519, 15, true);
            WriteLiteral("<h5>งานสวน</h5>");
            EndContext();
#line 32 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                                    }

#line default
#line hidden
            BeginContext(1537, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
#line 33 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                     if (item.skill3 == "3")
                                                    {

#line default
#line hidden
            BeginContext(1668, 18, true);
            WriteLiteral("<h5>งานใช้แรง</h5>");
            EndContext();
#line 34 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                                       }

#line default
#line hidden
            BeginContext(1689, 52, true);
            WriteLiteral("                                                    ");
            EndContext();
#line 35 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                     if (item.skill4 == "4")
                                                    {

#line default
#line hidden
            BeginContext(1820, 17, true);
            WriteLiteral("<h5>งานอื่นๆ</h5>");
            EndContext();
#line 36 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                                      }

#line default
#line hidden
            BeginContext(1840, 528, true);
            WriteLiteral(@"                                                </div>
                                            </p>
                                        </div>
                                    </div>
                                </div>
                                <div class=""backside col-xs-12 col-sm-6 col-md-12"">
                                    <div class=""card"">
                                        <div class=""card-body text-center mt-4"">
                                            <h4 class=""card-title"">");
            EndContext();
            BeginContext(2369, 35, false);
#line 45 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                              Write(Html.DisplayFor(model => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(2404, 91, true);
            WriteLiteral("</h4>\r\n                                            <p class=\"card-text\"><b>รายละเอียด</b> :");
            EndContext();
            BeginContext(2496, 38, false);
#line 46 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                                               Write(Html.DisplayFor(model => item.address));

#line default
#line hidden
            EndContext();
            BeginContext(2534, 93, true);
            WriteLiteral("</p>\r\n                                            <p class=\"card-text\"><b>เบอร์โทรศัพท์</b> :");
            EndContext();
            BeginContext(2628, 35, false);
#line 47 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                                                  Write(Html.DisplayFor(model => item.phon));

#line default
#line hidden
            EndContext();
            BeginContext(2663, 86, true);
            WriteLiteral("</p>\r\n                                            <p class=\"card-text\"><b>E-Mail</b> :");
            EndContext();
            BeginContext(2750, 36, false);
#line 48 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                                           Write(Html.DisplayFor(model => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2786, 87, true);
            WriteLiteral("</p>\r\n                                            <p class=\"card-text\"><b>ID-Line</b> :");
            EndContext();
            BeginContext(2874, 35, false);
#line 49 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                                            Write(Html.DisplayFor(model => item.line));

#line default
#line hidden
            EndContext();
            BeginContext(2909, 76, true);
            WriteLiteral("</p>\r\n                                            <ul class=\"list-inline\">\r\n");
            EndContext();
#line 51 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                 if (ViewBag.use != null && ViewBag.status == "2")
                                                {

#line default
#line hidden
            BeginContext(3136, 139, true);
            WriteLiteral("                                                    <li class=\"list-inline-item\">\r\n                                                        ");
            EndContext();
            BeginContext(3276, 90, false);
#line 54 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                   Write(Html.ActionLink("จ้างงาน", "hire", new { id = item._id }, new { @class = "btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(3366, 200, true);
            WriteLiteral("\r\n                                                    </li>\r\n                                                    <li class=\"list-inline-item\">\r\n                                                        ");
            EndContext();
            BeginContext(3567, 96, false);
#line 57 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                   Write(Html.ActionLink("ดูคะแนน", "comment", new { id = item._id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
            EndContext();
            BeginContext(3663, 61, true);
            WriteLiteral("\r\n                                                    </li>\r\n");
            EndContext();
#line 59 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(3880, 139, true);
            WriteLiteral("                                                    <li class=\"list-inline-item\">\r\n                                                        ");
            EndContext();
            BeginContext(4020, 100, false);
#line 63 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                   Write(Html.ActionLink("เข้าสู่ระบบก่อน!", "Login", new { id = item._id }, new { @class = "btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(4120, 200, true);
            WriteLiteral("\r\n                                                    </li>\r\n                                                    <li class=\"list-inline-item\">\r\n                                                        ");
            EndContext();
            BeginContext(4321, 96, false);
#line 66 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                   Write(Html.ActionLink("ดูคะแนน", "comment", new { id = item._id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
            EndContext();
            BeginContext(4417, 61, true);
            WriteLiteral("\r\n                                                    </li>\r\n");
            EndContext();
#line 68 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
                                                }

#line default
#line hidden
            BeginContext(4529, 279, true);
            WriteLiteral(@"                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
");
            EndContext();
#line 76 "C:\PROGRAM_D\งาน\perfect-V1\session\Views\Home\maid1.cshtml"
            }

#line default
#line hidden
            BeginContext(4823, 3192, true);
            WriteLiteral(@"        </div>
    </div>
</section>
<!-- ./Team member -->

<style>

    #team {
        background: #eee !important;
    }

    .btn-primary:hover,
    .btn-primary:focus {
        background-color: #108d6f;
        border-color: #108d6f;
        box-shadow: none;
        outline: none;
    }

    .btn-primary {
        color: #fff;
        background-color: #007b5e;
        border-color: #007b5e;
    }

    section {
        padding: 60px 0;
    }

        section .section-title {
            text-align: center;
            color: #007b5e;
            margin-bottom: 50px;
            text-transform: uppercase;
        }

    #team .card {
        border: none;
        background: #ffffff;
    }

    .image-flip:hover .backside,
    .image-flip.hover .backside {
        -webkit-transform: rotateY(0deg);
        -moz-transform: rotateY(0deg);
        -o-transform: rotateY(0deg);
        -ms-transform: rotateY(0deg);
        transform: rotateY(0deg);
        bor");
            WriteLiteral(@"der-radius: .25rem;
    }

    .image-flip:hover .frontside,
    .image-flip.hover .frontside {
        -webkit-transform: rotateY(180deg);
        -moz-transform: rotateY(180deg);
        -o-transform: rotateY(180deg);
        transform: rotateY(180deg);
    }

    .mainflip {
        -webkit-transition: 1s;
        -webkit-transform-style: preserve-3d;
        -moz-transition: 1s;
        -moz-transform: perspective(1000px);
        transition: 1s;
        transform-style: preserve-3d;
        position: relative;
    }

    .frontside {
        position: relative;
        -webkit-transform: rotateY(0deg);
        -ms-transform: rotateY(0deg);
        z-index: 2;
        margin-bottom: 30px;
    }

    .backside {
        position: absolute;
        top: 0;
        left: 0;
        background: white;
        -webkit-transform: rotateY(-180deg);
        -moz-transform: rotateY(-180deg);
        -o-transform: rotateY(-180deg);
        -ms-transform: rotateY(-180deg);
     ");
            WriteLiteral(@"   transform: rotateY(-180deg);
        -webkit-box-shadow: 5px 7px 9px -4px rgb(158, 158, 158);
        -moz-box-shadow: 5px 7px 9px -4px rgb(158, 158, 158);
        box-shadow: 5px 7px 9px -4px rgb(158, 158, 158);
    }

    .frontside,
    .backside {
        -webkit-backface-visibility: hidden;
        -moz-backface-visibility: hidden;
        backface-visibility: hidden;
        -webkit-transition: 1s;
        -webkit-transform-style: preserve-3d;
        -moz-transition: 1s;
        -o-transition: 1s;
        transition: 1s;
        transform-style: preserve-3d;
    }

        .frontside .card,
        .backside .card {
            min-height: 312px;
        }

            .backside .card a {
                font-size: 18px;
                color: #fff !important;
            }

            .frontside .card .card-title,
            .backside .card .card-title {
                color: #007b5e !important;
            }

            .frontside .card .card-body img {
     ");
            WriteLiteral("           width: 120px;\r\n                height: 120px;\r\n                border-radius: 50%;\r\n            }\r\n</style>\r\n");
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
