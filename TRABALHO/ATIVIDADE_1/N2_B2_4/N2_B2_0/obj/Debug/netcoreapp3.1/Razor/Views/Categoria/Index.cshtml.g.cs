#pragma checksum "C:\Users\Gabriel\Videos\TRABALHO\ATIVIDADE_1\N2_B2_4\N2_B2_0\Views\Categoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f1f72cbdf99dfefeef32fbbc4b9ab584191bd20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_Index), @"mvc.1.0.view", @"/Views/Categoria/Index.cshtml")]
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
#line 1 "C:\Users\Gabriel\Videos\TRABALHO\ATIVIDADE_1\N2_B2_4\N2_B2_0\Views\_ViewImports.cshtml"
using N2_B2_0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gabriel\Videos\TRABALHO\ATIVIDADE_1\N2_B2_4\N2_B2_0\Views\_ViewImports.cshtml"
using N2_B2_0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f1f72cbdf99dfefeef32fbbc4b9ab584191bd20", @"/Views/Categoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d7ee4f2dbea667f12a076758bc112f70d86907", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoriaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Gabriel\Videos\TRABALHO\ATIVIDADE_1\N2_B2_4\N2_B2_0\Views\Categoria\Index.cshtml"
  
    ViewData["Title"] = "Consulta de Categoria";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""main-content"">

    <a href=""/Categoria/Create"" class=""insert"">Cadastrar nova categoria</a>

    <div class=""card"">
        <ul class=""user-profiles-list-basic"">
            <table class=""table table-responsive table-dark"">
                <tr>
                    <th>Ações</th>
                    <th>Descrição</th>
                    <th>ID</th>
                    <th>Finalidade</th>
                    <th>Tamanho</th>
                </tr>

");
#nullable restore
#line 23 "C:\Users\Gabriel\Videos\TRABALHO\ATIVIDADE_1\N2_B2_4\N2_B2_0\Views\Categoria\Index.cshtml"
                 foreach (CategoriaViewModel a in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 764, "\"", 794, 2);
            WriteAttributeValue("", 771, "Categoria/Edit?id=", 771, 18, true);
#nullable restore
#line 27 "C:\Users\Gabriel\Videos\TRABALHO\ATIVIDADE_1\N2_B2_4\N2_B2_0\Views\Categoria\Index.cshtml"
WriteAttributeValue("", 789, a.ID, 789, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Editar</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 859, "\"", 891, 2);
            WriteAttributeValue("", 866, "Categoria/Delete?id=", 866, 20, true);
#nullable restore
#line 28 "C:\Users\Gabriel\Videos\TRABALHO\ATIVIDADE_1\N2_B2_4\N2_B2_0\Views\Categoria\Index.cshtml"
WriteAttributeValue("", 886, a.ID, 886, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Apagar</a>\r\n                        </td>\r\n\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\Gabriel\Videos\TRABALHO\ATIVIDADE_1\N2_B2_4\N2_B2_0\Views\Categoria\Index.cshtml"
                       Write(a.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\Gabriel\Videos\TRABALHO\ATIVIDADE_1\N2_B2_4\N2_B2_0\Views\Categoria\Index.cshtml"
                       Write(a.ID.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\Gabriel\Videos\TRABALHO\ATIVIDADE_1\N2_B2_4\N2_B2_0\Views\Categoria\Index.cshtml"
                       Write(a.Finalidade.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 34 "C:\Users\Gabriel\Videos\TRABALHO\ATIVIDADE_1\N2_B2_4\N2_B2_0\Views\Categoria\Index.cshtml"
                       Write(a.Tamanho.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Gabriel\Videos\TRABALHO\ATIVIDADE_1\N2_B2_4\N2_B2_0\Views\Categoria\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </table>\r\n        </ul>\r\n\r\n        <a href=\"/locacao/index\" class=\"btn btn-light\" >Voltar</a>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoriaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
