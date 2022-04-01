#pragma checksum "D:\C#_dotnet\projetos_dotnet\cadastro\Views\Contas\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddcee289adf2ca092256a6a92673c52e6760f5a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contas_Lista), @"mvc.1.0.view", @"/Views/Contas/Lista.cshtml")]
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
#line 1 "D:\C#_dotnet\projetos_dotnet\cadastro\Views\_ViewImports.cshtml"
using cadastro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#_dotnet\projetos_dotnet\cadastro\Views\_ViewImports.cshtml"
using cadastro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddcee289adf2ca092256a6a92673c52e6760f5a6", @"/Views/Contas/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5986f5279facf2699522804c3d745932e8250ef8", @"/Views/_ViewImports.cshtml")]
    public class Views_Contas_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
  table {
    font-family: arial, sans-serif;
    border-collapse: collapse;
    width: 100%;
  }

  td,
  th {
    border: 1px solid #dddddd;
    text-align: center;
    padding: 8px;
  }

  tr:nth-child(even) {
    background-color: #dddddd;
  }
</style>

<br><br>
<h1>Lista Contas</h1>

<table>
  <tr>
    <th>Cliente</th>
    <th>Agência</th>
    <th>Tipo</th>
    <th>Saldo</th>
    <th>Operações</th>
  </tr>

");
#nullable restore
#line 32 "D:\C#_dotnet\projetos_dotnet\cadastro\Views\Contas\Lista.cshtml"
   foreach (Conta conta in ViewBag.Contas)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n      <td>");
#nullable restore
#line 35 "D:\C#_dotnet\projetos_dotnet\cadastro\Views\Contas\Lista.cshtml"
     Write(conta.Cliente.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 36 "D:\C#_dotnet\projetos_dotnet\cadastro\Views\Contas\Lista.cshtml"
     Write(conta.Agencia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 37 "D:\C#_dotnet\projetos_dotnet\cadastro\Views\Contas\Lista.cshtml"
     Write(conta.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 38 "D:\C#_dotnet\projetos_dotnet\cadastro\Views\Contas\Lista.cshtml"
     Write(conta.Saldo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>\r\n        <a class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 684, "\"", 707, 2);
            WriteAttributeValue("", 691, "/conta/", 691, 7, true);
#nullable restore
#line 40 "D:\C#_dotnet\projetos_dotnet\cadastro\Views\Contas\Lista.cshtml"
WriteAttributeValue("", 698, conta.Id, 698, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n        <a class=\"btn btn-danger\" href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 763, "\"", 808, 3);
            WriteAttributeValue("", 773, "excluir(\'/conta/", 773, 16, true);
#nullable restore
#line 41 "D:\C#_dotnet\projetos_dotnet\cadastro\Views\Contas\Lista.cshtml"
WriteAttributeValue("", 789, conta.Id, 789, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 798, "/excluir\')", 798, 10, true);
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n      </td>\r\n    </tr>\r\n");
#nullable restore
#line 44 "D:\C#_dotnet\projetos_dotnet\cadastro\Views\Contas\Lista.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n<script>\r\n  function excluir(url) {\r\n    if (confirm(\"deseja realmente excluir?\")) {\r\n      window.location.href = url\r\n    }\r\n  }\r\n</script>");
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