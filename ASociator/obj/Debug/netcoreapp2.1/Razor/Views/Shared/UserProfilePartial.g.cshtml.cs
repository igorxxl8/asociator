#pragma checksum "D:\5term\IGI\ASociator\ASociator\Views\Shared\UserProfilePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b18771f93f51271d7d5275e7aa8d0f70667cc6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_UserProfilePartial), @"mvc.1.0.view", @"/Views/Shared/UserProfilePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/UserProfilePartial.cshtml", typeof(AspNetCore.Views_Shared_UserProfilePartial))]
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
#line 1 "D:\5term\IGI\ASociator\ASociator\Views\_ViewImports.cshtml"
using ASociator;

#line default
#line hidden
#line 2 "D:\5term\IGI\ASociator\ASociator\Views\_ViewImports.cshtml"
using ASociator.Models;

#line default
#line hidden
#line 3 "D:\5term\IGI\ASociator\ASociator\Views\_ViewImports.cshtml"
using ASociator.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b18771f93f51271d7d5275e7aa8d0f70667cc6f", @"/Views/Shared/UserProfilePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eb65a07f3c77d23cae6743a8e1987d7211ab415", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_UserProfilePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive center-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/default.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 361, true);
            WriteLiteral(@"
<style>
    .grid-container {
        display: grid;
        grid-template-columns: auto 200px auto;
        background-color: #2196F3;
    }

    .grid-item {
        background-color: rgba(255, 255, 255, 0.8);
        padding: 30px;
        font-size: 30px;
    }
</style>

<hr />
<div class=""grid-container"">

    <div class=""grid-item"">
");
            EndContext();
#line 21 "D:\5term\IGI\ASociator\ASociator\Views\Shared\UserProfilePartial.cshtml"
         if (Model.Avatar != null)
        {

#line default
#line hidden
            BeginContext(437, 77, true);
            WriteLiteral("            <img class=\"img-responsive center-block\" width=\"400\" height=\"400\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 514, "\"", 580, 2);
            WriteAttributeValue("", 520, "data:image/jpeg;base64,", 520, 23, true);
#line 23 "D:\5term\IGI\ASociator\ASociator\Views\Shared\UserProfilePartial.cshtml"
WriteAttributeValue("", 543, Convert.ToBase64String(Model.Avatar), 543, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(581, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 24 "D:\5term\IGI\ASociator\ASociator\Views\Shared\UserProfilePartial.cshtml"

        }
        else
        {

#line default
#line hidden
            BeginContext(624, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(636, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1aee7e7a5f54a3ba0c34f68bb6d16ab", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(728, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "D:\5term\IGI\ASociator\ASociator\Views\Shared\UserProfilePartial.cshtml"
        }

#line default
#line hidden
            BeginContext(741, 68, true);
            WriteLiteral("    </div>\r\n    <div class=\"grid-item\">\r\n        <p>\r\n\r\n            ");
            EndContext();
            BeginContext(810, 41, false);
#line 34 "D:\5term\IGI\ASociator\ASociator\Views\Shared\UserProfilePartial.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(851, 43, true);
            WriteLiteral("\r\n\r\n        </p>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(895, 39, false);
#line 38 "D:\5term\IGI\ASociator\ASociator\Views\Shared\UserProfilePartial.cshtml"
       Write(Html.DisplayNameFor(model => model.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(934, 82, true);
            WriteLiteral("\r\n\r\n        </p>\r\n\r\n        <p class=\"clear_fix profile_info_row\">\r\n\r\n            ");
            EndContext();
            BeginContext(1017, 45, false);
#line 44 "D:\5term\IGI\ASociator\ASociator\Views\Shared\UserProfilePartial.cshtml"
       Write(Html.DisplayNameFor(model => model.BirdthDay));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 80, true);
            WriteLiteral("\r\n\r\n        </p>\r\n\r\n        <p class=\"clear_fix profile_info_row\">\r\n            ");
            EndContext();
            BeginContext(1143, 43, false);
#line 49 "D:\5term\IGI\ASociator\ASociator\Views\Shared\UserProfilePartial.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 82, true);
            WriteLiteral("\r\n\r\n        </p>\r\n\r\n        <p class=\"clear_fix profile_info_row\">\r\n\r\n            ");
            EndContext();
            BeginContext(1269, 40, false);
#line 55 "D:\5term\IGI\ASociator\ASociator\Views\Shared\UserProfilePartial.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 84, true);
            WriteLiteral("\r\n\r\n        </p>\r\n    </div>\r\n    <div class=\"grid-item\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(1394, 37, false);
#line 61 "D:\5term\IGI\ASociator\ASociator\Views\Shared\UserProfilePartial.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1431, 43, true);
            WriteLiteral("\r\n\r\n        </p>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(1475, 35, false);
#line 65 "D:\5term\IGI\ASociator\ASociator\Views\Shared\UserProfilePartial.cshtml"
       Write(Html.DisplayFor(model => model.Sex));

#line default
#line hidden
            EndContext();
            BeginContext(1510, 80, true);
            WriteLiteral("\r\n\r\n        </p>\r\n\r\n        <p class=\"clear_fix profile_info_row\">\r\n            ");
            EndContext();
            BeginContext(1591, 41, false);
#line 70 "D:\5term\IGI\ASociator\ASociator\Views\Shared\UserProfilePartial.cshtml"
       Write(Html.DisplayFor(model => model.BirdthDay));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 80, true);
            WriteLiteral("\r\n\r\n        </p>\r\n\r\n        <p class=\"clear_fix profile_info_row\">\r\n            ");
            EndContext();
            BeginContext(1713, 39, false);
#line 75 "D:\5term\IGI\ASociator\ASociator\Views\Shared\UserProfilePartial.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1752, 80, true);
            WriteLiteral("\r\n\r\n        </p>\r\n\r\n        <p class=\"clear_fix profile_info_row\">\r\n            ");
            EndContext();
            BeginContext(1833, 36, false);
#line 80 "D:\5term\IGI\ASociator\ASociator\Views\Shared\UserProfilePartial.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(1869, 36, true);
            WriteLiteral("\r\n\r\n        </p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
