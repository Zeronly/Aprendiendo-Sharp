#pragma checksum "D:\DEVELOPER\repos\appMVC\Vidly\Views\Movies\Random.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6166579ef0ca3b77a72edc83d22855178819520"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Random), @"mvc.1.0.view", @"/Views/Movies/Random.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Random.cshtml", typeof(AspNetCore.Views_Movies_Random))]
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
#line 1 "D:\DEVELOPER\repos\appMVC\Vidly\Views\_ViewImports.cshtml"
using Vidly;

#line default
#line hidden
#line 2 "D:\DEVELOPER\repos\appMVC\Vidly\Views\_ViewImports.cshtml"
using Vidly.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6166579ef0ca3b77a72edc83d22855178819520", @"/Views/Movies/Random.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5f1cd008877cdb7a8309a52d389048c655f591a", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Random : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vidly.Models.CMovie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\DEVELOPER\repos\appMVC\Vidly\Views\Movies\Random.cshtml"
  
    ViewBag.Title = "Random";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(113, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(120, 10, false);
#line 7 "D:\DEVELOPER\repos\appMVC\Vidly\Views\Movies\Random.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(130, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vidly.Models.CMovie> Html { get; private set; }
    }
}
#pragma warning restore 1591
