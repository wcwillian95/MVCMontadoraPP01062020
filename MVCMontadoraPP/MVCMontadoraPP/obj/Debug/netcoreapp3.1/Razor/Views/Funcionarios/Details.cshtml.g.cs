#pragma checksum "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34d7b99af0306f4e4462fb6c66dee73ad368793d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionarios_Details), @"mvc.1.0.view", @"/Views/Funcionarios/Details.cshtml")]
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
#line 1 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\_ViewImports.cshtml"
using MVCMontadoraPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\_ViewImports.cshtml"
using MVCMontadoraPP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34d7b99af0306f4e4462fb6c66dee73ad368793d", @"/Views/Funcionarios/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab87423b252b185f44359c45596cdf9115024310", @"/Views/_ViewImports.cshtml")]
    public class Views_Funcionarios_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCMontadoraPP.Models.Funcionario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Funcionario</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 14 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 17 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 20 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cargo_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 23 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cargo_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 26 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CPF_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 29 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.CPF_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 32 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataNascimento_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 35 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataNascimento_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 38 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contato_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 41 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Contato_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 44 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contatodois_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 47 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Contatodois_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 50 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 53 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 56 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CEP_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 59 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.CEP_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 62 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rua_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 65 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rua_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 68 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bairro_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 71 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Bairro_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 74 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cidade_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 77 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cidade_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 80 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 83 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado_Funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 86 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataCadastroFuncionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 89 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataCadastroFuncionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34d7b99af0306f4e4462fb6c66dee73ad368793d13833", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\wcwil\Desktop\Pratica Profissional\PPMontadoraMVC\MVCMontadoraPP\MVCMontadoraPP\Views\Funcionarios\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34d7b99af0306f4e4462fb6c66dee73ad368793d16017", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCMontadoraPP.Models.Funcionario> Html { get; private set; }
    }
}
#pragma warning restore 1591
