#pragma checksum "C:\Users\cb272\Documents\GitHub\Escuela\PrimeraAppCore\PrimeraAppCore\Views\Home\ListaDeCursos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b61895e342fb5b7a2e78c4fabd3786029f22f8a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListaDeCursos), @"mvc.1.0.view", @"/Views/Home/ListaDeCursos.cshtml")]
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
#line 1 "C:\Users\cb272\Documents\GitHub\Escuela\PrimeraAppCore\PrimeraAppCore\Views\_ViewImports.cshtml"
using PrimeraAppCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cb272\Documents\GitHub\Escuela\PrimeraAppCore\PrimeraAppCore\Views\_ViewImports.cshtml"
using PrimeraAppCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b61895e342fb5b7a2e78c4fabd3786029f22f8a6", @"/Views/Home/ListaDeCursos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eddf17248a9e6cdcc6a27f10eb9d1fbc12a3d54", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListaDeCursos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\cb272\Documents\GitHub\Escuela\PrimeraAppCore\PrimeraAppCore\Views\Home\ListaDeCursos.cshtml"
  
    ViewData["Title"] = "ListaDeCursos";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ListaDeCursos</h1>\r\n\r\n<table table class=\"table table-dark table-striped\">\r\n        <th>\r\n            CourseId\r\n        </th>\r\n        <th>\r\n            Title\r\n        </th>\r\n        <th>\r\n            Credits\r\n        </th>\r\n        <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\cb272\Documents\GitHub\Escuela\PrimeraAppCore\PrimeraAppCore\Views\Home\ListaDeCursos.cshtml"
             foreach (var item in ViewBag.lista)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\cb272\Documents\GitHub\Escuela\PrimeraAppCore\PrimeraAppCore\Views\Home\ListaDeCursos.cshtml"
               Write(item.CourseId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\cb272\Documents\GitHub\Escuela\PrimeraAppCore\PrimeraAppCore\Views\Home\ListaDeCursos.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\cb272\Documents\GitHub\Escuela\PrimeraAppCore\PrimeraAppCore\Views\Home\ListaDeCursos.cshtml"
               Write(item.Credits);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 27 "C:\Users\cb272\Documents\GitHub\Escuela\PrimeraAppCore\PrimeraAppCore\Views\Home\ListaDeCursos.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>");
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
