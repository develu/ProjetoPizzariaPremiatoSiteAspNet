#pragma checksum "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b729614c0ba4c86862fdbad0df12446c8119b00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Index), @"mvc.1.0.view", @"/Views/Pizza/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pizza/Index.cshtml", typeof(AspNetCore.Views_Pizza_Index))]
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
#line 2 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b729614c0ba4c86862fdbad0df12446c8119b00", @"/Views/Pizza/Index.cshtml")]
    public class Views_Pizza_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PizzariaPremiato.Models.PizzaModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(79, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_layoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(174, 139, true);
            WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.13.6/css/jquery.dataTables.min.css\">\r\n\r\n<h2 class=\"text-center\">Pizzas</h2>\r\n\r\n");
            EndContext();
#line 13 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
 if (TempData["Mensagem"] != null)
{

#line default
#line hidden
            BeginContext(352, 74, true);
            WriteLiteral("    <div class=\"alert alert-secondary text-center\" role=\"alert\">\r\n        ");
            EndContext();
            BeginContext(427, 20, false);
#line 16 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
   Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(447, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 18 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
}

#line default
#line hidden
            BeginContext(464, 37, true);
            WriteLiteral("\r\n<p>\r\n    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 501, "\"", 541, 1);
#line 21 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 508, Url.Action("Cadastrar", "Pizza"), 508, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(542, 85, true);
            WriteLiteral(">Adicionar +</a>\r\n</p>\r\n<hr />\r\n<table class=\"table\" id=\"id_table_pizza\">\r\n    <thead");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 627, "\"", 635, 0);
            EndWriteAttribute();
            BeginContext(636, 391, true);
            WriteLiteral(@">
        <tr>
            <th scope=""col"">Nome</th>
            <th scope=""col"">Descrição</th>
            <th scope=""col"">Data de Cadastro</th>
            <th scope=""col"">Categoria</th>
            <th>Valor</th>
            <th scope=""col"">Foto</th>
            <th scope=""col"">Editar</th>
            <th scope=""col"">Deletar</th>
        </tr>

    </thead>
    <tbody>

");
            EndContext();
#line 40 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
         foreach (var item in @Model)
        {


#line default
#line hidden
            BeginContext(1079, 40, true);
            WriteLiteral("            <tr>\r\n\r\n                <td>");
            EndContext();
            BeginContext(1120, 9, false);
#line 45 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
               Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1129, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1157, 14, false);
#line 46 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
               Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(1171, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1199, 17, false);
#line 47 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
               Write(item.DataCadastro);

#line default
#line hidden
            EndContext();
            BeginContext(1216, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1244, 19, false);
#line 48 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
               Write(item.Categoria.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1263, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1291, 34, false);
#line 49 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
               Write(string.Format("{0:C}", item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1325, 45, true);
            WriteLiteral("</td>              \r\n                <td><img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 1370, "\"", 1404, 3);
#line 50 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 1376, item.Nome, 1376, 10, false);

#line default
#line hidden
            WriteAttributeValue(" ", 1386, "-", 1387, 2, true);
#line 50 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
WriteAttributeValue(" ", 1388, item.Descricao, 1389, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1405, 71, true);
            WriteLiteral(" style=\"height: 40px; width: 40px; border-radius:50px; cursor:pointer;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1476, "\"", 1492, 1);
#line 50 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 1482, item.Foto, 1482, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1493, "\"", 1541, 6);
            WriteAttributeValue("", 1503, "abrirModal(\'", 1503, 12, true);
#line 50 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 1515, item.Foto, 1515, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1525, "\',", 1525, 2, true);
            WriteAttributeValue(" ", 1527, "\'", 1528, 2, true);
#line 50 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 1529, item.Nome, 1529, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1539, "\')", 1539, 2, true);
            EndWriteAttribute();
            BeginContext(1542, 57, true);
            WriteLiteral(" /> </td>\r\n                <td><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1599, "\"", 1663, 1);
#line 51 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 1606, Url.Action("Editar", "Pizza", new { idPizza = item.Id }), 1606, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1664, 63, true);
            WriteLiteral(">Editar</a></td>\r\n                <td><a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1727, "\"", 1792, 1);
#line 52 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
WriteAttributeValue("", 1734, Url.Action("Deletar", "Pizza", new { idPizza = item.Id }), 1734, 58, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1793, 40, true);
            WriteLiteral(">Remover</a></td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 55 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1844, 575, true);
            WriteLiteral(@"

    </tbody>
</table>

<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""id_modal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content "">
            <div class=""modal-header"">
                <h5 class=""modal-title text-success"" id=""id_modal_titulo""></h5>
                <button type=""button"" class=""close"" onclick=""fecharModal();"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body text-center"">
                <img id=""id_modal_img""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2419, "\"", 2425, 0);
            EndWriteAttribute();
            BeginContext(2426, 2148, true);
            WriteLiteral(@" style=""max-width: 450px;  max-height:450px;"" />
            </div>
        </div>
    </div>
</div>

<script src=""https://code.jquery.com/jquery-3.7.0.js""></script>
<script src=""https://cdn.datatables.net/1.13.6/js/jquery.dataTables.min.js""></script>

<script>
    $('#id_table_pizza').DataTable({
        pageLength: 10,
        lengthMenu: [10, 20, 50, 100],
        oLanguage: {
            ""sEmptyTable"": ""Nenhum registro encontrado"",
            ""sInfo"": ""Mostrando de _START_ até _END_ de _TOTAL_ registros"",
            ""sInfoEmpty"": ""Mostrando 0 até 0 de 0 registros"",
            ""sInfoFiltered"": ""(Filtrados de _MAX_ registros)"",
            ""sInfoPostFix"": """",
            ""sInfoThousands"": ""."",
            ""sLengthMenu"": ""_MENU_ resultados por página"",
            ""sLoadingRecords"": ""Carregando..."",
            ""sProcessing"": ""Processando..."",
            ""sZeroRecords"": ""Nenhum registro encontrado"",
            ""sSearch"": ""Pesquisar"",
            ""oPaginate"": {
                """);
            WriteLiteral(@"sNext"": ""Próximo"",
                ""sPrevious"": ""Anterior"",
                ""sFirst"": ""Primeiro"",
                ""sLast"": ""Último""
            },
            ""oAria"": {
                ""sSortAscending"": "": Ordenar colunas de forma ascendente"",
                ""sSortDescending"": "": Ordenar colunas de forma descendente""
            },
            ""select"": {
                ""rows"": {
                    ""_"": ""Selecionado %d linhas"",
                    ""0"": ""Nenhuma linha selecionada"",
                    ""1"": ""Selecionado 1 linha""
                }
            }
        },
    })

    const modalItem = document.getElementById(""id_modal"");
    const imgModal = document.getElementById(""id_modal_img"");
    const tituloModal = document.getElementById(""id_modal_titulo"");

    const abrirModal = (foto, nome) => {

        modalItem.style.display = ""block""
        imgModal.src = foto;
        tituloModal.innerHTML = nome;
    }

    const fecharModal = () => {
        modalItem.style.d");
            WriteLiteral("isplay = \"none\"\r\n        imgModal.src = \"\";\r\n        tituloModal.innerHTML = \"\";\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PizzariaPremiato.Models.PizzaModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591