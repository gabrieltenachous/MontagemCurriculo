#pragma checksum "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\InformacoesLogin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c34ca9b9d6259f747cf5899cc7552017ed52d1c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InformacoesLogin_Index), @"mvc.1.0.view", @"/Views/InformacoesLogin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/InformacoesLogin/Index.cshtml", typeof(AspNetCore.Views_InformacoesLogin_Index))]
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
#line 1 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\_ViewImports.cshtml"
using MontagemCr;

#line default
#line hidden
#line 2 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\_ViewImports.cshtml"
using MontagemCr.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c34ca9b9d6259f747cf5899cc7552017ed52d1c6", @"/Views/InformacoesLogin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69b60d8e5b39658c10a7588a88957d12c1d367a6", @"/Views/_ViewImports.cshtml")]
    public class Views_InformacoesLogin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MontagemCr.Models.InformacaoLogin>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-small green darken-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadDados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "InformacoesLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\InformacoesLogin\Index.cshtml"
  
    ViewData["Title"] = "Minhas informações de login";

#line default
#line hidden
            BeginContext(120, 112, true);
            WriteLiteral("\r\n\r\n<div class=\"tabelaLogins container\">\r\n    \r\n    <h5>Minhas informações de login</h5>\r\n    <br />\r\n    \r\n    ");
            EndContext();
            BeginContext(232, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d08692b49a04452a6bf0efc9684d164", async() => {
                BeginContext(333, 17, true);
                WriteLiteral("Exportar para CSV");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(354, 198, true);
            WriteLiteral("\r\n\r\n    <div class=\"informacoesTabela\">\r\n        <table class=\"table table-striped highlight centered\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(553, 46, false);
#line 20 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\InformacoesLogin\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.EnderecoIP));

#line default
#line hidden
            EndContext();
            BeginContext(599, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(679, 40, false);
#line 23 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\InformacoesLogin\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(719, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(799, 43, false);
#line 26 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\InformacoesLogin\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Horario));

#line default
#line hidden
            EndContext();
            BeginContext(842, 114, true);
            WriteLiteral("\r\n                    </th>                   \r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 31 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\InformacoesLogin\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1021, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1106, 45, false);
#line 35 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\InformacoesLogin\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EnderecoIP));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1243, 39, false);
#line 38 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\InformacoesLogin\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1374, 42, false);
#line 41 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\InformacoesLogin\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Horario));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 83, true);
            WriteLiteral("\r\n                        </td>                       \r\n                    </tr>\r\n");
            EndContext();
#line 44 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\InformacoesLogin\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1518, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MontagemCr.Models.InformacaoLogin>> Html { get; private set; }
    }
}
#pragma warning restore 1591
