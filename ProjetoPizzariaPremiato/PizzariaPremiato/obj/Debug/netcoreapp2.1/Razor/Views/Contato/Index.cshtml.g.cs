#pragma checksum "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Contato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c274f0e680356664463de0b40a0e519aaceb2449"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Index), @"mvc.1.0.view", @"/Views/Contato/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contato/Index.cshtml", typeof(AspNetCore.Views_Contato_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c274f0e680356664463de0b40a0e519aaceb2449", @"/Views/Contato/Index.cshtml")]
    public class Views_Contato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/contato.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Contato\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(90, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c274f0e680356664463de0b40a0e519aaceb24493845", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(140, 371, true);
            WriteLiteral(@"
<h1 id=""id_titulo"">Formulário de Contato</h1>

<div class=""conteudo"">
    <!--CONTEÚDO DA PÁGINA-->

    <div class=""row"">

        <div class=""col-lg-6 col-sm-12"">
            <form method=""post"" action=""/contato/recebercontato"">

                <p>
                    <label for=""nome"">Nome</label><br>
                    <input type=""text"" name=""nome""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 511, "\"", 540, 1);
#line 19 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Contato\Index.cshtml"
WriteAttributeValue("", 519, ViewBag.Contato.Nome, 519, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(541, 83, true);
            WriteLiteral(" id=\"id_nome\" placeholder=\"Digite o seu nome\" maxlength=\"33\">\r\n                    ");
            EndContext();
            BeginContext(625, 30, false);
#line 20 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Contato\Index.cshtml"
               Write(Html.ValidationMessage("nome"));

#line default
#line hidden
            EndContext();
            BeginContext(655, 167, true);
            WriteLiteral("\r\n                </p>\r\n\r\n\r\n                <p>\r\n                    <label for=\"telefone\">Telefone</label><br>\r\n                    <input type=\"text\" name=\"telefone\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 822, "\"", 855, 1);
#line 26 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Contato\Index.cshtml"
WriteAttributeValue("", 830, ViewBag.Contato.Telefone, 830, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(856, 76, true);
            WriteLiteral(" id=\"id_telefone\" placeholder=\"Digite o seu telefone\">\r\n                    ");
            EndContext();
            BeginContext(933, 34, false);
#line 27 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Contato\Index.cshtml"
               Write(Html.ValidationMessage("telefone"));

#line default
#line hidden
            EndContext();
            BeginContext(967, 157, true);
            WriteLiteral("\r\n                </p>\r\n\r\n                <p>\r\n                    <label for=\"email\">E-mail</label><br>\r\n                    <input type=\"text\" name=\"email\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1124, "\"", 1154, 1);
#line 32 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Contato\Index.cshtml"
WriteAttributeValue("", 1132, ViewBag.Contato.Email, 1132, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1155, 71, true);
            WriteLiteral(" id=\"id_email\" placeholder=\"Digite o seu e-mail\">\r\n                    ");
            EndContext();
            BeginContext(1227, 31, false);
#line 33 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Contato\Index.cshtml"
               Write(Html.ValidationMessage("email"));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 125, true);
            WriteLiteral("\r\n                </p>\r\n                <label for=\"mensagem\">Mensagem</label><br>\r\n                <textarea name=\"mensagem\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1383, "\"", 1412, 1);
#line 36 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Contato\Index.cshtml"
WriteAttributeValue("", 1391, ViewBag.Contato.Nome, 1391, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1413, 101, true);
            WriteLiteral(" id=\"id_mensagem\" cols=\"30\" rows=\"10\" placeholder=\"Digite sua mensagem\"></textarea>\r\n                ");
            EndContext();
            BeginContext(1515, 34, false);
#line 37 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Contato\Index.cshtml"
           Write(Html.ValidationMessage("mensagem"));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 531, true);
            WriteLiteral(@"
                <br>

                <button type=""submit"" id=""id_enviar"">Enviar</button>


            </form>

        </div>
        <div class=""col-lg-6 col-sm-12"">
            <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3654.887702619049!2d-46.515313723702555!3d-23.64419236464243!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94ce6826e84c76b5%3A0x38d22b382674049a!2sPizzaria%20da%20Mama!5e0!3m2!1spt-BR!2sbr!4v1688151047382!5m2!1spt-BR!2sbr"" width=""600"" height=""600"" style=""border:0;""");
            EndContext();
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 2080, "\"", 2098, 0);
            EndWriteAttribute();
            BeginContext(2099, 103, true);
            WriteLiteral(" loading=\"lazy\" referrerpolicy=\"no-referrer-when-downgrade\"></iframe>\r\n        </div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(2203, 16, false);
#line 50 "C:\dev\Projetos\C# em Desenvolvimento\ProjetoPizzariaPremiato\ProjetoPizzariaPremiato\PizzariaPremiato\Views\Contato\Index.cshtml"
Write(ViewBag.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(2219, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
