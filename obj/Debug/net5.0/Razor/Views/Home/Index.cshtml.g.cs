#pragma checksum "C:\Users\diego\Desktop\Fia 9\Programacion1\pc3simulacro\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e2d347a888964fd079021e4d4edcd4db3333ff1"
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
#line 1 "C:\Users\diego\Desktop\Fia 9\Programacion1\pc3simulacro\Views\_ViewImports.cshtml"
using pc3simulacro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\diego\Desktop\Fia 9\Programacion1\pc3simulacro\Views\_ViewImports.cshtml"
using pc3simulacro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e2d347a888964fd079021e4d4edcd4db3333ff1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa4663e280c8bfe9ada676850c0bd3aab9161d42", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Solicitud>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
#line 2 "C:\Users\diego\Desktop\Fia 9\Programacion1\pc3simulacro\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e2d347a888964fd079021e4d4edcd4db3333ff13592", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n </p>\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Lista de Solictudes </h1>\r\n\r\n    \r\n");
#nullable restore
#line 13 "C:\Users\diego\Desktop\Fia 9\Programacion1\pc3simulacro\Views\Home\Index.cshtml"
     foreach (var solicitud in Model) {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div> \r\n                Nombre Producto : ");
#nullable restore
#line 16 "C:\Users\diego\Desktop\Fia 9\Programacion1\pc3simulacro\Views\Home\Index.cshtml"
                             Write(solicitud.NombreP);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                Nombre Producto : ");
#nullable restore
#line 17 "C:\Users\diego\Desktop\Fia 9\Programacion1\pc3simulacro\Views\Home\Index.cshtml"
                             Write(solicitud.Foto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Nombre Producto : ");
#nullable restore
#line 18 "C:\Users\diego\Desktop\Fia 9\Programacion1\pc3simulacro\Views\Home\Index.cshtml"
                             Write(solicitud.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Nombre Producto : ");
#nullable restore
#line 19 "C:\Users\diego\Desktop\Fia 9\Programacion1\pc3simulacro\Views\Home\Index.cshtml"
                             Write(solicitud.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Nombre Producto : ");
#nullable restore
#line 20 "C:\Users\diego\Desktop\Fia 9\Programacion1\pc3simulacro\Views\Home\Index.cshtml"
                             Write(solicitud.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Nombre Producto : ");
#nullable restore
#line 21 "C:\Users\diego\Desktop\Fia 9\Programacion1\pc3simulacro\Views\Home\Index.cshtml"
                             Write(solicitud.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Nombre Producto : ");
#nullable restore
#line 22 "C:\Users\diego\Desktop\Fia 9\Programacion1\pc3simulacro\Views\Home\Index.cshtml"
                             Write(solicitud.Usuario.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Nombre Producto : ");
#nullable restore
#line 23 "C:\Users\diego\Desktop\Fia 9\Programacion1\pc3simulacro\Views\Home\Index.cshtml"
                             Write(solicitud.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        \r\n\r\n            </div>\r\n");
#nullable restore
#line 27 "C:\Users\diego\Desktop\Fia 9\Programacion1\pc3simulacro\Views\Home\Index.cshtml"
           
            
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
