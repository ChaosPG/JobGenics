#pragma checksum "D:\DataFrom_500SSD_Projects\.NetCore\JobGenics\JobGenics\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c84f760a7d004efce9a7ee1d1152d2de57542a21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
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
#nullable restore
#line 1 "D:\DataFrom_500SSD_Projects\.NetCore\JobGenics\JobGenics\Views\_ViewImports.cshtml"
using JobGenics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DataFrom_500SSD_Projects\.NetCore\JobGenics\JobGenics\Views\_ViewImports.cshtml"
using JobGenics.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\DataFrom_500SSD_Projects\.NetCore\JobGenics\JobGenics\Views\Shared\_LoginPartial.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DataFrom_500SSD_Projects\.NetCore\JobGenics\JobGenics\Views\Shared\_LoginPartial.cshtml"
using JobGenics.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c84f760a7d004efce9a7ee1d1152d2de57542a21", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d306e5bee5b969cf8928afda48e288e34356ab2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/JobgenicsStyle.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c84f760a7d004efce9a7ee1d1152d2de57542a214327", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarTogglerDemo01"" aria-controls=""navbarTogglerDemo01"" aria-expanded=""false"" aria-label=""Toggle navigation"">
    <span class=""navbar-toggler-icon""></span>
</button>
<div class=""collapse navbar-collapse"" id=""navbarTogglerDemo01"">
    <ul class=""navbar-nav mr-auto mt-2 mt-md-0"">
        <li class=""nav-item dropdown"">
            <a class=""nav-link"" href=""#"" id=""navbarDropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                งาน
            </a>
            <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
                <li><a class=""dropdown-item"" href=""#"">กิจกรรมล่าสุด</a></li>
                <li><a class=""dropdown-item"" href=""#"">แจ้งเตือนงาน</a></li>
                <li><a class=""dropdown-item"" href=""#"">Applications</a></li>
            </ul>
        </li>

        <li class=""nav-item dropdown"">
            <a class=""nav-link "" href=""#"" id=""na");
            WriteLiteral(@"vbarDropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                บริษัท
            </a>
            <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
                <li><a class=""dropdown-item"" href=""#"">สำรวจบริษัท</a></li>
                <li><a class=""dropdown-item"" href=""#"">เปรียบเทียบบริษัท</a></li>
                <li><a class=""dropdown-item"" href=""#"">เขียนรีวิว</a></li>
            </ul>
        </li>

        <li class=""nav-item dropdown"">
            <a class=""nav-link "" href=""#"" id=""navbarDropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                เงินเดือน
            </a>
            <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
                <li><a class=""dropdown-item"" href=""#"">สำรวจค่าจ้าง</a></li>
                <li><a class=""dropdown-item"" href=""#"">คำนวนค่าจ้าง</a></li>
                <li><a class=""dropdown-item"" href=""#"">สัมภาษณ์งาน</a></li>
        ");
            WriteLiteral(@"    </ul>
        </li>

        <li class=""nav-item dropdown"">
            <a class=""nav-link "" href=""#"" id=""navbarDropdownMenuLink"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                อาชีพ
            </a>
            <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdownMenuLink"">
                <li><a class=""dropdown-item"" href=""#"">สำรวจอาชีพ</a></li>
                <li><a class=""dropdown-item"" href=""#"">คำถามสัมภาษณ์งาน</a></li>
            </ul>
        </li>

");
            WriteLiteral(@"    </ul>

    <ul class=""navbar-nav ml-auto mt-3 mt-lg-0"">
        <li class=""nav-item px-lg-2 dropdown d-menu"">
            <a class=""nav-link"" href=""#"" id=""dropdown01"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fas fa-bell fa-lg mt-2""></i>
            </a>
            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdown01"">
                <a class=""dropdown-item"" href=""#"">แจ้งเตือน 1</a>
                <a class=""dropdown-item"" href=""#"">แจ้งเตือน 2</a>
                <a class=""dropdown-item"" href=""#"">แจ้งเตือน 3</a>
            </div>
        </li>

        <li class=""nav-item px-lg-2 dropdown d-menu"">
            <a class=""nav-link"" href=""#"" id=""dropdown01"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <i class=""fa-solid fa-circle-user fa-2x""></i>
            </a>
            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdown01"">
                <a class=""dr");
            WriteLiteral("opdown-item\" href=\"#\">ประวัติส่วนตัว</a>\r\n                <a class=\"dropdown-item\" href=\"#\">Resume</a>\r\n                <a class=\"dropdown-item\" href=\"#\">งานที่สนใจ</a>\r\n            </div>\r\n        </li>\r\n    </ul>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<JobGenicsUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<JobGenicsUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591