#pragma checksum "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Jugadores\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21162de5d28bd4f1ea42be09c73e04f8591b55e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TorneoFutbolDepartamental.App.Frontend.Pages.Jugadores.Pages_Jugadores_Index), @"mvc.1.0.razor-page", @"/Pages/Jugadores/Index.cshtml")]
namespace TorneoFutbolDepartamental.App.Frontend.Pages.Jugadores
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21162de5d28bd4f1ea42be09c73e04f8591b55e5", @"/Pages/Jugadores/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1aa7bef0b60a3efe64c692168ebb6dccf9c9dcd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Jugadores_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Listado de Jugadores</h1>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Documento</th>
            <th scope=""col"">Telefono</th>
            <th scope=""col"">Numero</th>
            <th scope=""col"">Posicion</th>
            <th scope=""col"">Equipo</th>
        </tr>   
    </thead>
    <tbody>
");
#nullable restore
#line 18 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Jugadores\Index.cshtml"
         foreach (var jugador in Model.jugadores)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Jugadores\Index.cshtml"
               Write(jugador.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Jugadores\Index.cshtml"
               Write(jugador.Documento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Jugadores\Index.cshtml"
               Write(jugador.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Jugadores\Index.cshtml"
               Write(jugador.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Jugadores\Index.cshtml"
               Write(jugador.Posicion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Jugadores\Index.cshtml"
               Write(jugador.Equipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\user\Desktop\ESTEBAN\Trabajos\Ciclo 3\Proyectos net core\Proyecto\TorneoFutbolDepartamental\TorneoFutbolDepartamental.App.Frontend\Pages\Jugadores\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TorneoFutbolDepartamental.App.Frontend.pages.Jugadores.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbolDepartamental.App.Frontend.pages.Jugadores.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoFutbolDepartamental.App.Frontend.pages.Jugadores.IndexModel>)PageContext?.ViewData;
        public TorneoFutbolDepartamental.App.Frontend.pages.Jugadores.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
