#pragma checksum "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Arbitros\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f16a80f5ab10f28b0fce37e6b3c206f752d6055"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TorneoFutbolDepartamental.App.Frontend.Pages.Arbitros.Pages_Arbitros_Index), @"mvc.1.0.razor-page", @"/Pages/Arbitros/Index.cshtml")]
namespace TorneoFutbolDepartamental.App.Frontend.Pages.Arbitros
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
#line 1 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\_ViewImports.cshtml"
using TorneoFutbolDepartamental.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f16a80f5ab10f28b0fce37e6b3c206f752d6055", @"/Pages/Arbitros/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1aa7bef0b60a3efe64c692168ebb6dccf9c9dcd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Arbitros_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Listado de Arbitros</h1>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Documento</th>
            <th scope=""col"">Telefono</th>
            <th scope=""col"">ColegioPertenece</th>
        </tr>   
    </thead>
    <tbody>
");
#nullable restore
#line 16 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Arbitros\Index.cshtml"
         foreach (var arbitro in Model.arbitros)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Arbitros\Index.cshtml"
               Write(arbitro.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Arbitros\Index.cshtml"
               Write(arbitro.Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Arbitros\Index.cshtml"
               Write(arbitro.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Arbitros\Index.cshtml"
               Write(arbitro.ColegioPertenece);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Arbitros\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TorneoFutbolDepartamental.App.Frontend.pages.Arbitros.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbolDepartamental.App.Frontend.pages.Arbitros.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbolDepartamental.App.Frontend.pages.Arbitros.IndexModel>)PageContext?.ViewData;
        public TorneoFutbolDepartamental.App.Frontend.pages.Arbitros.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
