#pragma checksum "C:\Users\User\Desktop\ATV3_VeterinariaLourdes\Views\Home\Confirmacao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad431e444ecee7dafbc5b76e8998986d0085df36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Confirmacao), @"mvc.1.0.view", @"/Views/Home/Confirmacao.cshtml")]
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
#line 1 "C:\Users\User\Desktop\ATV3_VeterinariaLourdes\Views\_ViewImports.cshtml"
using ATV3_VeterinariaLourdes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\ATV3_VeterinariaLourdes\Views\_ViewImports.cshtml"
using ATV3_VeterinariaLourdes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad431e444ecee7dafbc5b76e8998986d0085df36", @"/Views/Home/Confirmacao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07550e7e31baaabd6eb341db8a594814031e7ac4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Confirmacao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Agendamento>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\ATV3_VeterinariaLourdes\Views\Home\Confirmacao.cshtml"
  
    ViewData["Title"] = "Confirmacao";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"Confirmacao-content\">\r\n    <div id=\"Confirmacao-dados\">\r\n        <h1>AGENDAMENTO CONFIRMADO</h1>\r\n        <h3>SEUS DADOS:</h3>\r\n        <ul>\r\n            <li>Nome: ");
#nullable restore
#line 10 "C:\Users\User\Desktop\ATV3_VeterinariaLourdes\Views\Home\Confirmacao.cshtml"
                 Write(Dados.agendado.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Telefone: ");
#nullable restore
#line 11 "C:\Users\User\Desktop\ATV3_VeterinariaLourdes\Views\Home\Confirmacao.cshtml"
                     Write(Dados.agendado.fone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Data: ");
#nullable restore
#line 12 "C:\Users\User\Desktop\ATV3_VeterinariaLourdes\Views\Home\Confirmacao.cshtml"
                 Write(Dados.agendado.data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Animal: ");
#nullable restore
#line 13 "C:\Users\User\Desktop\ATV3_VeterinariaLourdes\Views\Home\Confirmacao.cshtml"
                   Write(Dados.agendado.animal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>Necessidade: ");
#nullable restore
#line 14 "C:\Users\User\Desktop\ATV3_VeterinariaLourdes\Views\Home\Confirmacao.cshtml"
                        Write(Dados.agendado.necessidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n\r\n\r\n        \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Agendamento> Html { get; private set; }
    }
}
#pragma warning restore 1591
