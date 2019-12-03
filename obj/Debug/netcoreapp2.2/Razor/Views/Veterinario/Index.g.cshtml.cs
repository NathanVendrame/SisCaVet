#pragma checksum "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b50a126598b1674d0787740add6009a1ec485afa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Veterinario_Index), @"mvc.1.0.view", @"/Views/Veterinario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Veterinario/Index.cshtml", typeof(AspNetCore.Views_Veterinario_Index))]
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
#line 1 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
using SisCaVet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b50a126598b1674d0787740add6009a1ec485afa", @"/Views/Veterinario/Index.cshtml")]
    public class Views_Veterinario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Veterinario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
  
    Layout= "~/Views/Shared/Layout.cshtml";

#line default
#line hidden
            BeginContext(106, 2715, true);
            WriteLiteral(@"
<!-- Barra de navegação (Home > Veterinário      SisCaVet) -->
<nav class=""top-nav green lighten-3"">
     <div class=""nav-wrapper container"">
          <!-- Logo Titulo -->
          <a href=""/Home/Index"" class=""brand-logo right"">SisCaVet</a>
          <!-- Botão de Menu que não aparece em tela grande -->
          <div class=""row"">
                <div class=""col s0 m0 l2""></div>
                <div class=""col s12 m12 l10"">
                    <a href=""#"" data-activates=""nav-mobile"" class=""button-collapse full hide-on-large-only"">
                         <i class=""material-icons"">menu</i>
                    </a>
                    <div>
                         <a href=""/Home/Index"" class=""breadcrumb"">Home</a>
                         <a href=""#!"" class=""breadcrumb"">Veterinário</a>
                    </div>
               </div>
          </div>
     </div>
</nav>
<div class=""row"">
    <div class=""col s0 m0 l2""></div>
    <div class=""col s12 m12 l10"">
        
        <div clas");
            WriteLiteral(@"s=""row valign-wrapper"">
            <div class=""col s10"">
            
                
                <h2 class=""green-text text-lighten-3"">Veterinários</h2>

                <!--<div class=""row valign-wrapper"">
                    <div class=""col s12 m9 l10"">-->

                            <!-- Botão icone add -->
                            <div class=""right-align"">
                                <a class=""btn btn-small waves-effect waves-light"" href=""/Veterinario/Create""><i class=""material-icons"">add</i></a>
                            </div>

                        <!-- Tabela Procedimentos -->
                        <table class=""striped centered"">
                            <thead>
                                <tr>
                                        <th>Nome</th>
                                        <th>CPF</th>
                                        <th>RG</th>
                                        <th>Data de Nascimento</th>
                                  ");
            WriteLiteral(@"      <th>Telefone</th>
                                        <th>Especialidade</th>
                                        <th>Salario</th>
                                        <th>CRMV</th>
                                        <th>Longadouro</th>
                                        <th>Bairro</th>
                                        <th>CEP</th>
                                        <th>Cidade</th>
                                        <th>Estado</th>
                                        <th></th>
                                        <th></th>
                                </tr>
                            </thead>
");
            EndContext();
#line 68 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
                             foreach(var veterinario in Model)
                            {

#line default
#line hidden
            BeginContext(2916, 147, true);
            WriteLiteral("                                <tr>\r\n                                        <td>                   \r\n                                            ");
            EndContext();
            BeginContext(3064, 16, false);
#line 72 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
                                       Write(veterinario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3080, 155, true);
            WriteLiteral("\r\n                                        </td>                \r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3236, 15, false);
#line 75 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
                                       Write(veterinario.Cpf);

#line default
#line hidden
            EndContext();
            BeginContext(3251, 158, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>                   \r\n                                            ");
            EndContext();
            BeginContext(3410, 14, false);
#line 78 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
                                       Write(veterinario.Rg);

#line default
#line hidden
            EndContext();
            BeginContext(3424, 155, true);
            WriteLiteral("\r\n                                        </td>                \r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3580, 26, false);
#line 81 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
                                       Write(veterinario.DataNascimento);

#line default
#line hidden
            EndContext();
            BeginContext(3606, 158, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>                   \r\n                                            ");
            EndContext();
            BeginContext(3765, 20, false);
#line 84 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
                                       Write(veterinario.Telefone);

#line default
#line hidden
            EndContext();
            BeginContext(3785, 155, true);
            WriteLiteral("\r\n                                        </td>                \r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3941, 25, false);
#line 87 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
                                       Write(veterinario.Especialidade);

#line default
#line hidden
            EndContext();
            BeginContext(3966, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(4106, 19, false);
#line 90 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
                                       Write(veterinario.Salario);

#line default
#line hidden
            EndContext();
            BeginContext(4125, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(4265, 16, false);
#line 93 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
                                       Write(veterinario.Crmv);

#line default
#line hidden
            EndContext();
            BeginContext(4281, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(4421, 22, false);
#line 96 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
                                       Write(veterinario.Longadouro);

#line default
#line hidden
            EndContext();
            BeginContext(4443, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(4583, 18, false);
#line 99 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
                                       Write(veterinario.Bairro);

#line default
#line hidden
            EndContext();
            BeginContext(4601, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(4741, 15, false);
#line 102 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
                                       Write(veterinario.Cep);

#line default
#line hidden
            EndContext();
            BeginContext(4756, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(4896, 18, false);
#line 105 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
                                       Write(veterinario.Cidade);

#line default
#line hidden
            EndContext();
            BeginContext(4914, 139, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(5054, 18, false);
#line 108 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
                                       Write(veterinario.Estado);

#line default
#line hidden
            EndContext();
            BeginContext(5072, 150, true);
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <a class=\"\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5222, "\"", 5264, 2);
            WriteAttributeValue("", 5229, "/Veterinario/Update/", 5229, 20, true);
#line 111 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
WriteAttributeValue("", 5249, veterinario.Id, 5249, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5265, 191, true);
            WriteLiteral("><i class=\"material-icons\">edit</i></a>\r\n                                        </td>  \r\n                                        <td>\r\n                                            <a class=\"\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5456, "\"", 5498, 2);
            WriteAttributeValue("", 5463, "/Veterinario/Delete/", 5463, 20, true);
#line 114 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
WriteAttributeValue("", 5483, veterinario.Id, 5483, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5499, 137, true);
            WriteLiteral("><i class=\"material-icons\">delete</i></a>\r\n                                        </td>        \r\n                                </tr>\r\n");
            EndContext();
#line 117 "E:\faculdade\POO\atualizado pt3\SisCaVet\Views\Veterinario\Index.cshtml"
                            }          

#line default
#line hidden
            BeginContext(5677, 307, true);
            WriteLiteral(@"                        </table>

                        <!--</div>
                        <div class=""col hide-on-small-only m2 l1""></div>
                </div>-->

            

            
            </div>

            <div class=""col s1""></div>
        </div>
    </div>
</div>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Veterinario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
