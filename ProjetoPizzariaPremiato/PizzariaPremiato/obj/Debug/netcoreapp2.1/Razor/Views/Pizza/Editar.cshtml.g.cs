#pragma checksum "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3eabf838c908c094263fcb4acb76c31fe5621e4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Editar), @"mvc.1.0.view", @"/Views/Pizza/Editar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pizza/Editar.cshtml", typeof(AspNetCore.Views_Pizza_Editar))]
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
#line 2 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
using PizzariaPremiato.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eabf838c908c094263fcb4acb76c31fe5621e4a", @"/Views/Pizza/Editar.cshtml")]
    public class Views_Pizza_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzariaPremiato.Models.PizzaModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
  
    ViewData["Title"] = "Editar";
    Layout = "~/Views/Shared/_layoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(171, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
  List<CategoriaModel> lstCategoria = (List<CategoriaModel>)TempData["lstCategoria"];

#line default
#line hidden
            BeginContext(261, 386, true);
            WriteLiteral(@"
<h2 class=""text-center"">Editar</h2>

<h4 class=""text-center text-primary"">Pizzas</h4>
<hr />
<div class=""row"">
    <div class=""col-md-10 offset-md-1"">
        <form method=""post"" enctype=""multipart/form-data"" asp-controller=""Pizza"" asp-action=""Editar"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>

            <input type=""hidden"" name=""Id""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 647, "\"", 664, 1);
#line 20 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
WriteAttributeValue("", 655, Model.Id, 655, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(665, 296, true);
            WriteLiteral(@" />

            <input type=""hidden"" id=""id_update_foto"" name=""UpdateFoto"" value=""false"" />

            <div class=""form-group mb-2"">
                <label asp-for=""Nome"" class=""control-label"" style=""font-weight:bold;"">Nome</label>
                <input name=""Nome"" class=""form-control""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 961, "\"", 980, 1);
#line 26 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
WriteAttributeValue("", 969, Model.Nome, 969, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(981, 21, true);
            WriteLiteral(" />\r\n                ");
            EndContext();
            BeginContext(1003, 62, false);
#line 27 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
           Write(Html.ValidationMessage("Nome", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1065, 235, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group mb-2\">\r\n                <label asp-for=\"Descricao\" class=\"control-label\" style=\"font-weight:bold;\">Descrição</label>\r\n                <input name=\"descricao\" class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1300, "\"", 1324, 1);
#line 31 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
WriteAttributeValue("", 1308, Model.Descricao, 1308, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1325, 21, true);
            WriteLiteral(" />\r\n                ");
            EndContext();
            BeginContext(1347, 67, false);
#line 32 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
           Write(Html.ValidationMessage("Descricao", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1414, 261, true);
            WriteLiteral(@"
            </div>

            <div class=""form-group mb-2"">
                <label asp-for=""CategoriaId"" class=""control-label"" style=""font-weight:bold;"">Seleciona uma Categoria</label>

                <select name=""CategoriaId"" class=""form-control"">
");
            EndContext();
#line 39 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
                     foreach (var c in lstCategoria)
                    {


#line default
#line hidden
            BeginContext(1754, 31, true);
            WriteLiteral("                        <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1785, "\"", 1798, 1);
#line 42 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
WriteAttributeValue("", 1793, c.Id, 1793, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1799, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1802, 45, false);
#line 42 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
                                          Write(Model.Categoria.Id == c.Id ? "selected" : "" );

#line default
#line hidden
            EndContext();
            BeginContext(1848, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1850, 6, false);
#line 42 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
                                                                                          Write(c.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1856, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 43 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"

                    }

#line default
#line hidden
            BeginContext(1892, 334, true);
            WriteLiteral(@"                </select>
                <span asp-validation-for=""CategoriaId"" class=""text-danger""></span>
            </div>

            <div class=""form-group mb-2"">
                <label asp-for=""Valor"" class=""control-label"" style=""font-weight:bold;"">Valor</label>
                <input name=""Valor"" class=""form-control""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2226, "\"", 2246, 1);
#line 51 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
WriteAttributeValue("", 2234, Model.Valor, 2234, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2247, 21, true);
            WriteLiteral(" />\r\n                ");
            EndContext();
            BeginContext(2269, 63, false);
#line 52 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
           Write(Html.ValidationMessage("Valor", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2332, 204, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <hr />\r\n            <div class=\"form-group mb-2\">\r\n                <label class=\"control-label\" style=\"font-weight:bold;\">Foto Atual</label><br />\r\n                <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 2536, "\"", 2572, 3);
#line 58 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
WriteAttributeValue("", 2542, Model.Nome, 2542, 11, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2553, "-", 2554, 2, true);
#line 58 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
WriteAttributeValue(" ", 2555, Model.Descricao, 2556, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2573, 71, true);
            WriteLiteral(" style=\"height: 40px; width: 40px; border-radius:50px; cursor:pointer;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2644, "\"", 2661, 1);
#line 58 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
WriteAttributeValue("", 2650, Model.Foto, 2650, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2662, "\"", 2713, 7);
            WriteAttributeValue("", 2672, "abrirModal(\'", 2672, 12, true);
#line 58 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
WriteAttributeValue("", 2684, Model.Foto, 2684, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 2695, "\',", 2695, 2, true);
            WriteAttributeValue(" ", 2697, "\'", 2698, 2, true);
#line 58 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
WriteAttributeValue("", 2699, Model.Nome, 2699, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 2710, "\'", 2710, 1, true);
            WriteAttributeValue(" ", 2711, ")", 2712, 2, true);
            EndWriteAttribute();
            BeginContext(2714, 480, true);
            WriteLiteral(@" />
            </div>


            <br />
            <a class=""btn btn-warning"" onclick=""alterarFoto();"">Alterar Foto?</a>


            <div id=""id_alterar_foto"" style=""display:none;"">

                <br />
                <br />

                <div class=""form-group mb-2"">
                    <label asp-for=""Foto"" class=""control-label"" style=""font-weight:bold;"">Foto</label>

                    <input type=""file"" name=""Foto"" />

                    ");
            EndContext();
            BeginContext(3195, 62, false);
#line 76 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
               Write(Html.ValidationMessage("Foto", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3257, 283, true);
            WriteLiteral(@"
                </div>
            </div>


            <hr />
            <div class=""form-group float-end"">

                <div class=""d-grid gap-2"">
                    <input type=""submit"" value=""Atualizar"" class=""btn btn-primary btn-block"" />
                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3540, "\"", 3577, 1);
#line 86 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Pizza\Editar.cshtml"
WriteAttributeValue("", 3547, Url.Action("Index", "Pizza" ), 3547, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3578, 683, true);
            WriteLiteral(@" class=""btn btn-outline-warning btn-block"">Voltar</a>
                </div>
            </div>
        </form>
    </div>
</div>

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
            BeginWriteAttribute("src", " src=\"", 4261, "\"", 4267, 0);
            EndWriteAttribute();
            BeginContext(4268, 821, true);
            WriteLiteral(@" style=""max-width: 450px;  max-height:450px;"" />
            </div>
        </div>
    </div>
</div>

<script>

    const alterarFoto = () => {
        document.getElementById(""id_alterar_foto"").style.display = ""block"";
        document.getElementById(""id_update_foto"").value = true;
    }

    const modalItem = document.getElementById(""id_modal"");
    const imgModal = document.getElementById(""id_modal_img"");
    const tituloModal = document.getElementById(""id_modal_titulo"");

    const abrirModal = (foto, nome) => {

        modalItem.style.display = ""block""
        imgModal.src = foto;
        tituloModal.innerHTML = nome;
    }

    const fecharModal = () => {
        modalItem.style.display = ""none""
        imgModal.src = """";
        tituloModal.innerHTML = """";
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzariaPremiato.Models.PizzaModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
