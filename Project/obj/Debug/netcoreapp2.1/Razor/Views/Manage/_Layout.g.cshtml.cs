#pragma checksum "/Users/wajeehahmed/Projects/newProject/Project/Views/Manage/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0362a0f063ee223f0412d842137fa1926c600983"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage__Layout), @"mvc.1.0.view", @"/Views/Manage/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/_Layout.cshtml", typeof(AspNetCore.Views_Manage__Layout))]
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
#line 1 "/Users/wajeehahmed/Projects/newProject/Project/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/wajeehahmed/Projects/newProject/Project/Views/_ViewImports.cshtml"
using Project;

#line default
#line hidden
#line 3 "/Users/wajeehahmed/Projects/newProject/Project/Views/_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
#line 4 "/Users/wajeehahmed/Projects/newProject/Project/Views/_ViewImports.cshtml"
using Project.Models.AccountViewModels;

#line default
#line hidden
#line 5 "/Users/wajeehahmed/Projects/newProject/Project/Views/_ViewImports.cshtml"
using Project.Models.ManageViewModels;

#line default
#line hidden
#line 1 "/Users/wajeehahmed/Projects/newProject/Project/Views/Manage/_ViewImports.cshtml"
using Project.Views.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0362a0f063ee223f0412d842137fa1926c600983", @"/Views/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"323ac28eeb9cb5e7f9e42622c4826d3f63182176", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4e5f76d8b4122b2a93fec70cd7c7ee7f0ae02c5", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/wajeehahmed/Projects/newProject/Project/Views/Manage/_Layout.cshtml"
   
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(54, 163, true);
            WriteLiteral("\r\n<h2>Manage your account</h2>\r\n\r\n<div>\r\n    <h4>Change your account settings</h4>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(218, 37, false);
#line 12 "/Users/wajeehahmed/Projects/newProject/Project/Views/Manage/_Layout.cshtml"
       Write(await Html.PartialAsync("_ManageNav"));

#line default
#line hidden
            EndContext();
            BeginContext(255, 62, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            ");
            EndContext();
            BeginContext(318, 12, false);
#line 15 "/Users/wajeehahmed/Projects/newProject/Project/Views/Manage/_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(330, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(388, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(395, 41, false);
#line 21 "/Users/wajeehahmed/Projects/newProject/Project/Views/Manage/_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(436, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(441, 10, true);
            WriteLiteral("        \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
