#pragma checksum "/home/heloisa/Downloads/CentralDuplicatas-master/Views/Cad/Cad.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b36e590386f6d392362923c82d0b99b4192b672"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cad_Cad), @"mvc.1.0.view", @"/Views/Cad/Cad.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cad/Cad.cshtml", typeof(AspNetCore.Views_Cad_Cad))]
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
#line 1 "/home/heloisa/Downloads/CentralDuplicatas-master/Views/_ViewImports.cshtml"
using CentralDuplicatas;

#line default
#line hidden
#line 2 "/home/heloisa/Downloads/CentralDuplicatas-master/Views/_ViewImports.cshtml"
using CentralDuplicatas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b36e590386f6d392362923c82d0b99b4192b672", @"/Views/Cad/Cad.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f04a559329bab731b14f0328caffd1e364e330", @"/Views/_ViewImports.cshtml")]
    public class Views_Cad_Cad : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal mt3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/heloisa/Downloads/CentralDuplicatas-master/Views/Cad/Cad.cshtml"
  
    ViewData["Title"] = "Cadastro";

#line default
#line hidden
            BeginContext(41, 205, true);
            WriteLiteral("\n<script src=\"https://unpkg.com/vue\"></script>\n<script src=\"//cdnjs.cloudflare.com/ajax/libs/axios/0.18.0/axios.min.js\"></script>\n\n<div class=\"mt6\" id=\"cad\">\n  <navbarinternal></navbarinternal>\n  \n        ");
            EndContext();
            BeginContext(246, 7500, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71cca2ad6b914559a7f15790e4cfd5ba", async() => {
                BeginContext(252, 5465, true);
                WriteLiteral(@"
            <div v-if=""step === 1"">
              <div class=""mt4"">
          	<div id=""cadastro"" class=""columns is-desktop"">
          		<div class=""column is-10-touch is-offset-1-touch is-4-desktop is-offset-2-desktop flexd"">
          			<titulocadastro class="""" title=""Olá!"" subtitle=""Preencha os campos para prosseguir.""></titulocadastro>
          			<div class=""field"">
          				<label class=""label"">Escolha um tipo de documento</label>
          				<div class=""control"">
          					<div class=""checkradio100"">
          						<input v-on:click=""fisica = true"" class=""is-checkradio is-info"" id=""1"" type=""radio"" name=""exampleRadioInline"" checked=""checked"">
          							<label for=""1"">Pessoa física</label>
          						<input v-on:click=""fisica = false"" class=""is-checkradio is-info"" id=""2"" type=""radio"" name=""exampleRadioInline"">
          							<label for=""2"">Pessoa jurídica</label>
          					</div>
          				</div>
          			</div>

                    <div v-if=""fisica"">
        ");
                WriteLiteral(@"              <label class=""label mt3"">CPF</label>
            					<input class=""input"" v-model=""dados.document"" >
                      <label class=""label mt3"">Nome Completo</label>
            					<input class=""input"" v-model=""dados.fullName"">
                       <label class=""label mt3"">Data de nascimento</label>
            					<input class=""input"" style=""margin-bottom: 0.75rem"" v-model=""dados.birthDate"">
                    </div>

                    <div v-else>
                      <label class=""label mt3"">CNPJ</label>
            					<input class=""input"" v-model=""dados.entity.cnpj"" >
                      <label class=""label mt3"">Razão Social</label>
                      <input class=""input"" v-model=""dados.entity.fullname"" >
                      <label class=""label mt3"">Nome Fantasia</label>
                      <input class=""input"" style=""margin-bottom: 0.75rem"" v-model=""dados.entity.aliasname"" >
                    </div>

                    <div>
                      <label class=""la");
                WriteLiteral(@"bel mt1"">Email</label>
                    	<input class=""input"" v-model=""dados.emails.address"" label=""Email"">
                    <div class = ""columns"">
                      <div class = ""column is-2"">
                        <label class=""label mt2"">DDD</label>
                        <input class=""input"" v-model=""dados.telephones.ddd"">
                      </div>
                      <div class = ""column is-10"">
                        <label class=""label mt2"">Telefone</label>
                        <input class=""input"" v-model=""dados.telephones.number"">
                      </div>
                    </div>
                    <div class = ""columns"">
                      <div class = ""column is-2"">
                        <label class=""label mt1"">DDD</label>
                        <input class=""input"" v-model=""dados.telephones.ddd"">
                      </div>
                      <div class = ""column is-10"">
                       <label class=""label mt1"">Celular</label>
                       ");
                WriteLiteral(@" <input class=""input"" v-model=""dados.telephones.number"">
                      </div>
                    </div>
                  </div>
                  </div>
          				<div class=""column is-4 is-hidden-touch mt3"">
          					<div class=""infoc blue"">
          						<div class=""columns"">
          							<div class=""column is-2-desktop dflex1"">
          								<i class=""fa fa-cube fa-2x""></i>
          							</div>
          							<div class=""column is-10-desktop"">
          								<span class=""titlec"">Tenha em mãos seu documento de identidade (RG ou CNH)</span>
          								<br>
          								</div>
          							</div>
          						</div>
          						<div class=""infoc"">
          							<span class=""titlec"">Suporte Diário</span>
          							<br>
          								<span class=""subtitlec"">Time de analistas dedicado a auxiliar em suas operações.</span>
          							</div>
          							<div class=""infoc"">
          								<span class=""titlec"">Plataformas Especia");
                WriteLiteral(@"lizadas</span>
          								<br>
          									<span class=""subtitlec"">As melhores plataformas para diferentes perfis de trader.</span>
          								</div>
          								<div class=""infoc"">
          									<span class=""titlec"">Melhor Custo x Benefício</span>
          									<br>
          										<span class=""subtitlec"">Para o trader que opera frequentemente.</span>
          									</div>
          									<div class=""infoc"">
          										<span class=""titlec"">Segurança para Investir</span>
          										<br>
          											<span class=""subtitlec"">Posições de ativos custodiadas na CLBC e opções com proteção do FGC.</span>
          										</div>
          									</div>
          								</div>
          							</div>
            <div class=""mt5 mb5 column is-paddingless is-10-touch is-offset-1-touch is-4-desktop is-offset-2-desktop flexd"">
            <button v-on:click.prevent=""next()"" class=""button is-info"">Próximo</button>
            </div>
        </d");
                WriteLiteral(@"iv>

        <div v-if=""step === 2"">
          <div class=""mt4"">
        <div id=""cadastro1"" class=""columns is-desktop"">
          <div class=""column is-10-touch is-offset-1-touch is-4-desktop is-offset-2-desktop flexd"">
            <titulocadastro title=""Documentos"" subtitle=""Preencha os campos para prosseguir.""></titulocadastro>
            ");
                EndContext();
                BeginContext(5717, 1245, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c729ab6b5544f67b640ed6951565aab", async() => {
                    BeginContext(5751, 1204, true);
                    WriteLiteral(@"
            <div class=""control"">
            <label class=""label mt1"">CEP</label>
            <input type=""text"" class=""input"" v-model=""cep"" v-on:keyup=""searchCep()"" placeholder=""digite o cep aqui (sem hífen)"">
            <span v-if=""message"" class=""help is-danger"">CEP não encontrado.</span>
            <label class=""label mt1"">Cidade</label>
                  <input class=""input"" v-model=""dados.userInfoModel.address.city"">
                  <label class=""label mt1"">UF</label>
                  <input class=""input"" v-model=""dados.userInfoModel.address.state"">
                  <label class=""label mt1"">Endereço</label>
                  <input class=""input"" v-model=""dados.userInfoModel.address.thoroughfare"">
                  <label class=""label mt1"">Numero</label>
                  <input class=""input"" v-model=""dados.userInfoModel.address.number"">
                  <label class=""label mt1"">Bairro</label>
                  <input class=""input"" v-model=""dados.userInfoModel.address.neighborhood"">
            ");
                    WriteLiteral("       <label class=\"label mt1\">Complemento</label>\n                  <input class=\"input\" v-model=\"dados.userInfoModel.address.complement\">\n                  </div>\n              ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6962, 777, true);
                WriteLiteral(@"
              <div class=""control"">
                <div class=""checkradio100 mt1"">
                    <input class=""is-checkradio is-info"" id=""exampleCheckbox19"" type=""checkbox"" name=""exampleCheckbox"">
                        <label for=""exampleCheckbox19"">Concordo em receber notificações por e-mail</label>
                            </div>         
                </div>
            </div>
          </div>
        </div>
            <div class=""mt5 mb5 column is-paddingless is-10-touch is-offset-1-touch is-4-desktop is-offset-2-desktop flexd"">
            <button v-on:click.prevent=""prev()"" class=""button is-light"">Anterior</button>
             <button v-on:click.prevent=""submit()"" class=""button is-info"">Salvar</button>
            </div>
        </div>
   
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7746, 25, true);
            WriteLiteral("\n    \n    </div>\n</div>\n\n");
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