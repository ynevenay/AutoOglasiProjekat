#pragma checksum "C:\Users\Luka\Desktop\AutoOglasi\AutoOglasi\Views\Account\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46a5b7e33e9347f7cfc45892ef0eff349b9dd8e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AccessDenied), @"mvc.1.0.view", @"/Views/Account/AccessDenied.cshtml")]
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
#line 1 "C:\Users\Luka\Desktop\AutoOglasi\AutoOglasi\Views\_ViewImports.cshtml"
using AutoOglasi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Luka\Desktop\AutoOglasi\AutoOglasi\Views\_ViewImports.cshtml"
using AutoOglasi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a5b7e33e9347f7cfc45892ef0eff349b9dd8e2", @"/Views/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41e8ea8ae792480e7970653be68fb99f445ffd84", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Luka\Desktop\AutoOglasi\AutoOglasi\Views\Account\AccessDenied.cshtml"
  
    ViewData["Title"] = "Access Denied";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container mt-5"">
    <div class=""row justify-content-center"">
        <div class=""col-md-8"">
            <div class=""card border-danger"">
                <div class=""card-header bg-danger text-white"">
                    <h4 class=""mb-0"">Greska</h4>
                </div>
                <div class=""card-body text-center"">
                    <h1 class=""display-4"">403</h1>
                    <p class=""lead"">Nemate dozvolu da pristupite korisnickom meniju</p>
                    <hr>
                    <p>Pristup je dozvoljen samo administratorima.</p>
                    <a href=""javascript:history.back()"" class=""btn btn-primary mt-3"">
                        <i class=""fas fa-arrow-left""></i> Go Back
                    </a>
                    <a");
            BeginWriteAttribute("href", " href=\"", 884, "\"", 919, 1);
#nullable restore
#line 21 "C:\Users\Luka\Desktop\AutoOglasi\AutoOglasi\Views\Account\AccessDenied.cshtml"
WriteAttributeValue("", 891, Url.Action("Index", "Home"), 891, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary mt-3\">\r\n                        <i class=\"fas fa-home\"></i> Nazad na pocetnu\r\n                    </a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://kit.fontawesome.com/a076d05399.js\"></script>\r\n");
            }
            );
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
