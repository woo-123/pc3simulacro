#pragma checksum "C:\Users\diego\Desktop\Fia 9\Programacion1\teoria\pc3simulacro\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f2b8ed3888e04db466e847835fc74254215ac78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\diego\Desktop\Fia 9\Programacion1\teoria\pc3simulacro\Views\_ViewImports.cshtml"
using pc3simulacro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\diego\Desktop\Fia 9\Programacion1\teoria\pc3simulacro\Views\_ViewImports.cshtml"
using pc3simulacro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f2b8ed3888e04db466e847835fc74254215ac78", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa4663e280c8bfe9ada676850c0bd3aab9161d42", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Solicitud>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("boton1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\diego\Desktop\Fia 9\Programacion1\teoria\pc3simulacro\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout="_Layout2";
     DateTime limitDate = DateTime.Today.AddDays(-5);

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f2b8ed3888e04db466e847835fc74254215ac784045", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n </p>\r\n <h1 class=\"display-4 titulo\">Lista de Solictudes de los ultimos 5 Dias </h1>\r\n <p>Solo se visualizara los registros que se hagan los ultimos 5 dias a fecha de hoy  </p>\r\n<div class=\"text-center grid\">\r\n    \r\n");
#nullable restore
#line 15 "C:\Users\diego\Desktop\Fia 9\Programacion1\teoria\pc3simulacro\Views\Home\Index.cshtml"
   if (Model.Count == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No hay Registros a??n , se le invita a registrar una compra presionando el boton de create new.</p>\r\n");
#nullable restore
#line 17 "C:\Users\diego\Desktop\Fia 9\Programacion1\teoria\pc3simulacro\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n");
#nullable restore
#line 19 "C:\Users\diego\Desktop\Fia 9\Programacion1\teoria\pc3simulacro\Views\Home\Index.cshtml"
     foreach (var solicitud in Model) {
        if((DateTime.Compare(@solicitud.Fecha,limitDate)>=0) ){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\'columnas\'> \r\n                <div>\r\n                    <ul>\r\n               <li> Nombre Producto : ");
#nullable restore
#line 24 "C:\Users\diego\Desktop\Fia 9\Programacion1\teoria\pc3simulacro\Views\Home\Index.cshtml"
                                 Write(solicitud.NombreP);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n               <li> URL de foto : ");
#nullable restore
#line 25 "C:\Users\diego\Desktop\Fia 9\Programacion1\teoria\pc3simulacro\Views\Home\Index.cshtml"
                             Write(solicitud.Foto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n               <li> Descripcion : ");
#nullable restore
#line 26 "C:\Users\diego\Desktop\Fia 9\Programacion1\teoria\pc3simulacro\Views\Home\Index.cshtml"
                             Write(solicitud.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n               <li> Precio del Producto : ");
#nullable restore
#line 27 "C:\Users\diego\Desktop\Fia 9\Programacion1\teoria\pc3simulacro\Views\Home\Index.cshtml"
                                     Write(solicitud.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n              <li> Tetelfono del comprador : ");
#nullable restore
#line 28 "C:\Users\diego\Desktop\Fia 9\Programacion1\teoria\pc3simulacro\Views\Home\Index.cshtml"
                                        Write(solicitud.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li> \r\n             <li>  direccion del comprador : ");
#nullable restore
#line 29 "C:\Users\diego\Desktop\Fia 9\Programacion1\teoria\pc3simulacro\Views\Home\Index.cshtml"
                                        Write(solicitud.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li> \r\n             <li>   Nombre del comprador : ");
#nullable restore
#line 30 "C:\Users\diego\Desktop\Fia 9\Programacion1\teoria\pc3simulacro\Views\Home\Index.cshtml"
                                      Write(solicitud.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n              <li> categoria del producto : ");
#nullable restore
#line 31 "C:\Users\diego\Desktop\Fia 9\Programacion1\teoria\pc3simulacro\Views\Home\Index.cshtml"
                                       Write(solicitud.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li> \r\n              <li>  fecha de la compra : ");
#nullable restore
#line 32 "C:\Users\diego\Desktop\Fia 9\Programacion1\teoria\pc3simulacro\Views\Home\Index.cshtml"
                                    Write(solicitud.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li> \r\n                 </ul>\r\n                </div>     \r\n\r\n            </div>\r\n");
#nullable restore
#line 37 "C:\Users\diego\Desktop\Fia 9\Programacion1\teoria\pc3simulacro\Views\Home\Index.cshtml"
           
        } 
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Solicitud>> Html { get; private set; }
    }
}
#pragma warning restore 1591
