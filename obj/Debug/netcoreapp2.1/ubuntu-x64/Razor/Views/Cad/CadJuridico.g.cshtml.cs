#pragma checksum "/home/thallis/Área de Trabalho/CentralDuplicatas/Views/Cad/CadJuridico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b56844827d07e7387621e638d1b77ded08633c73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cad_CadJuridico), @"mvc.1.0.view", @"/Views/Cad/CadJuridico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cad/CadJuridico.cshtml", typeof(AspNetCore.Views_Cad_CadJuridico))]
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
#line 1 "/home/thallis/Área de Trabalho/CentralDuplicatas/Views/_ViewImports.cshtml"
using CentralDuplicatas;

#line default
#line hidden
#line 2 "/home/thallis/Área de Trabalho/CentralDuplicatas/Views/_ViewImports.cshtml"
using CentralDuplicatas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b56844827d07e7387621e638d1b77ded08633c73", @"/Views/Cad/CadJuridico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f04a559329bab731b14f0328caffd1e364e330", @"/Views/_ViewImports.cshtml")]
    public class Views_Cad_CadJuridico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/home/thallis/Área de Trabalho/CentralDuplicatas/Views/Cad/CadJuridico.cshtml"
  
    ViewData["Title"] = "Cadastro jurídico";

#line default
#line hidden
            BeginContext(51, 1129, true);
            WriteLiteral(@"
<script src=""https://unpkg.com/vue""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/axios/0.18.0/axios.min.js""></script>

<section class=""hero infoc blue"">
    <div class=""hero-body mt5"">
        <div class=""container has-text-centered"">
            <titulocadastro id=""tabscadastrotitle""  class=""title"">Olá!<br> Preencha os campos para prosseguir</titulocadastro>
        </div>
    </div>

    <div class=""hero-foot"">
        <nav class=""tabs is-boxed is-fullwidth is-default"">
            <div class=""container"">
                <ul>
                    <li class=""tab is-active"" onclick=""openTab(event,'WebDev')"">
                        <a>Dados da Empresa</a></li>
                    <li class=""tab"" onclick=""openTab(event,'cadastroadministrador')""><a>Dados do Administrador</a></li>
                    <li class=""tab"" onclick=""openTab(event,'cadastrousuarios')""><a>Dados do Usuário</a></li>
                </ul>
            </div>
        </nav>
    </div>
</section>

<div id=""navbarcad"">
    <navbarinte");
            WriteLiteral("rnal></navbarinternal>\n</div>\n\n<div id=\"WebDev\" class=\"content-tab\">\n    <div class=\"\" id=\"cad\">\n        ");
            EndContext();
            BeginContext(1180, 6008, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a213d00c05ed4f7d9fcfd4ac66b452c9", async() => {
                BeginContext(1186, 1315, true);
                WriteLiteral(@"
            <div v-if=""step === 1"">
                <div class=""mt5"">
                    <div id=""cadastro"" class=""columns is-desktop"">
                        <div class=""column is-10-touch is-offset-1-touch is-4-desktop is-offset-2-desktop"">
                            <div class=""mt4"">
                                        <label class=""label mt3"">CNPJ</label>
                                        <input class=""input"" id=""cnpj"" type=""text"" name=""cnpj"" data-validate=""cnpj"" placeholder=""00.000.000/0000-00"" v-model=""dados.entity.cnpj"">
                                        <label class=""label mt3"">Razão Social</label>
                                        <input class=""input"" data-validate=""text"" v-model=""dados.entity.fullname"">
                                        <label class=""label mt3"">Nome Fantasia</label>
                                        <input class=""input"" data-validate=""text"" style=""margin-bottom: 0.75rem"" v-model=""dados.entity.aliasname"">
                                        <");
                WriteLiteral(@"label class=""label mt1"">Atividade</label>
                                        <div class=""control"">
                                            <div class=""select is-fullwidth"">
                                                <select>
                                                    ");
                EndContext();
                BeginContext(2501, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa724ab245fc4519acae022df996c462", async() => {
                    BeginContext(2509, 21, true);
                    WriteLiteral("Selecione a atividade");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2539, 53, true);
                WriteLiteral("\n                                                    ");
                EndContext();
                BeginContext(2592, 29, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3aebe94ae0f4baaa304868926ecf9d2", async() => {
                    BeginContext(2600, 12, true);
                    WriteLiteral("With options");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2621, 2444, true);
                WriteLiteral(@"
                                                </select>
                                            </div>
                                        </div>
                                    <div>
                                        <label class=""label mt1"">Email</label>
                                        <input class=""input"" v-model=""dados.emails.address"" label=""Email"">
                                        <div class=""columns"" v-for=""(telephones, index) in dados.telephones"">
                                            <div class=""column is-2"">
                                                <label class=""label mt1"">DDD</label>
                                                <input class=""input"" v-model=""telephones.ddd"">
                                            </div>
                                            <div class=""column is-6"">
                                                <label class=""label mt1"">Telefone</label>
                                                <input type=""text"" d");
                WriteLiteral(@"ata-validate=""brPhone"" class=""input"" v-model=""telephones.number"">
                                            </div>
                                            <div class=""column is-4"">
                                                <label class=""label mt1"">Telefone</label>
                                                <button class=""button is-info"" v-on:click.prevent=""deleteUser(index)"">Deletar</button>
                                                <button class=""button is-info"" v-on:click.prevent=""addUser"">Adicionar</button>
                                            </div>
                                        </div>

                                    </div>

                                    <div class=""mt4 mb5 column is-paddingless is-10-touch is-4-desktop flexd"">
                                        <button v-on:click.prevent=""next()"" class=""button is-info"">Próximo</button>
                                    </div>
                                </div>
                        </div>
  ");
                WriteLiteral(@"                       <infocadastro></infocadastro>
                    </div>
                </div>
            </div>
            <div v-if=""step === 2"">
                <div class=""mt5"">
                    <div id=""cadastro1"" class=""columns is-desktop"">
                        <div class=""column is-10-touch is-offset-1-touch is-4-desktop is-offset-2-desktop"">
                            ");
                EndContext();
                BeginContext(5065, 1654, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "430aa856687d4f42a3ebcb21ac0e34a4", async() => {
                    BeginContext(5099, 1613, true);
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
                                        <label class=""labe");
                    WriteLiteral(@"l mt1"">Numero</label>
                                        <input class=""input"" v-model=""dados.userInfoModel.address.number"">
                                        <label class=""label mt1"">Bairro</label>
                                        <input class=""input"" v-model=""dados.userInfoModel.address.neighborhood"">
                                        <label class=""label mt1"">Complemento</label>
                                        <input class=""input"" v-model=""dados.userInfoModel.address.complement"">
                                    </div>
                            ");
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
                BeginContext(6719, 462, true);
                WriteLiteral(@"
                            <div class=""mt5 mb5 column is-paddingless is-10-touch is-4-desktop flexd"">
                                <button v-on:click.prevent=""prev()"" class=""button is-light"">Anterior</button>
                                <button v-on:click.prevent=""submit()"" class=""button is-info"">Salvar</button>
                            </div>
                        </div>
                    </div>
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
            BeginContext(7188, 97, true);
            WriteLiteral("\n    </div>\n</div>\n<div id=\"cadastroadministrador\" class=\"content-tab\" style=\"display:none\">\n    ");
            EndContext();
            BeginContext(7285, 7255, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9415d5c9372b4b9e85b4f0f3a54b5a18", async() => {
                BeginContext(7291, 4806, true);
                WriteLiteral(@"
        <div v-if=""step === 1"">
            <div class=""mt5"">
                <div id=""cadastro"" class=""columns is-desktop"">
                    <div class=""column is-10-touch is-offset-1-touch is-4-desktop is-offset-2-desktop"">
                            <div class=""mt4"">
                                <div>
                                    <label class=""label mt3"">CPF</label>
                                    <input class=""input"" id=""cpf"" type=""text"" name=""cpf"" data-validate=""cpf"" placeholder=""000.000.000-00"" maxlength=""14"" v-model=""dados.document"">
                                    <label class=""label mt3"">Nome Completo</label>
                                    <input class=""input"" data-validate=""text"" v-model=""dados.fullName"">
                                    <label class=""label mt3"">Data de nascimento</label>
                                    <input class=""input"" data-validate=""date"" style=""margin-bottom: 0.75rem"" v-model=""dados.birthDate"">
                                </div>
        ");
                WriteLiteral(@"                        <div>
                                    <label class=""label mt1"">Email</label>
                                    <input class=""input"" v-model=""dados.emails.address"" label=""Email"">
                                    <label class=""label mt2"">Confirmação Email</label>
                                    <input class=""input"" v-model=""dados.emails.address"" label=""Email"">
                                    <div class=""columns"">
                                        <div class=""column is-4"">
                                            <div class=""checkradio100 mt1"">
                                                <input class=""is-checkradio is-info"" id=""checkboxEmail"" type=""checkbox"" name=""checkboxEmail"">
                                                <label for=""checkboxEmail"">Receber notificações por e-mail</label></div>
                                        </div>
                                        <div class=""column is-6"">
                                            <div c");
                WriteLiteral(@"lass=""checkradio100 mt1"">
                                                <input class=""is-checkradio is-info"" id=""checkboxNews"" type=""checkbox"" name=""checkboxNews"">
                                                <label for=""checkboxNews"">Receber Newsletter</label></div>
                                        </div>
                                    </div>
                                    <div class=""columns"" v-for=""(telephones, index) in dados.telephones"">
                                        <div class=""column is-2"">
                                            <label class=""label mt1"">DDD</label>
                                            <input class=""input"" v-model=""telephones.ddd"">
                                        </div>

                                        <div class=""column is-6"">
                                            <label class=""label mt1"">Telefone</label>
                                            <input type=""text"" data-validate=""brPhone"" class=""input"" v-model=""telepho");
                WriteLiteral(@"nes.number"">
                                        </div>
                                        <div class=""column is-4"">
                                            <label class=""label mt1"">Telefone</label>
                                            <button class=""button is-info"" v-on:click.prevent=""deleteUser(index)"">Deletar</button>
                                            <button class=""button is-info"" v-on:click.prevent=""addUser"">Adicionar</button>
                                        </div>
                                    </div>
                                    <div class=""control"">

                                        <div class=""checkradio100 mt1"">
                                            <input class=""is-checkradio is-info"" id=""checkboxSms"" type=""checkbox"" name=""checkboxSms"">
                                            <label for=""checkboxSms"">Receber notificações por SMS</label>
                                        </div>
                                    </div>
       ");
                WriteLiteral(@"                         </div>

                                <div class=""mt4 mb5 column is-paddingless is-10-touch is-4-desktop flexd"">
                                    <button v-on:click.prevent=""next()"" class=""button is-info"">Próximo</button>
                                </div>
                        </div>
                    </div>
                    <infocadastro></infocadastro>
                </div>
            </div>
        </div>
        <div v-if=""step === 2"">
            <div class=""mt5"">
                <div id=""cadastro1"" class=""columns is-desktop"">
                    <div class=""column is-10-touch is-offset-1-touch is-4-desktop is-offset-2-desktop"">
                        ");
                EndContext();
                BeginContext(12097, 1582, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "528c9e92276e4ea58a4a45d57c01d800", async() => {
                    BeginContext(12131, 1541, true);
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
                      ");
                    WriteLiteral(@"              <input class=""input"" v-model=""dados.userInfoModel.address.number"">
                                    <label class=""label mt1"">Bairro</label>
                                    <input class=""input"" v-model=""dados.userInfoModel.address.neighborhood"">
                                    <label class=""label mt1"">Complemento</label>
                                    <input class=""input"" v-model=""dados.userInfoModel.address.complement"">
                                </div>
                        ");
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
                BeginContext(13679, 854, true);
                WriteLiteral(@"
                        <div class=""control"">
                            <div class=""checkradio100 mt1"">
                                <input class=""is-checkradio is-info"" id=""exampleCheckbox19"" type=""checkbox"" name=""exampleCheckbox"">
                                <label for=""exampleCheckbox19"">Concordo em receber notificações por e-mail</label>
                            </div>
                        </div>

                        <div class=""mt5 mb5 column is-paddingless is-10-touch is-offset-1-touch is-4-desktop flexd"">

                            <button v-on:click.prevent=""prev()"" class=""button is-light"">Anterior</button>
                            <button v-on:click.prevent=""submit()"" class=""button is-info"">Salvar</button>
                        </div>
                    </div>
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
            BeginContext(14540, 100, true);
            WriteLiteral("\n    </div>\n</div>\n</div>\n\n<div id=\"cadastrousuarios\" class=\"content-tab\" style=\"display:none\">\n    ");
            EndContext();
            BeginContext(14640, 4235, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09614296a68942b9b09276ee02535a2f", async() => {
                BeginContext(14646, 4222, true);
                WriteLiteral(@"
        <div class=""container mt5"">
            <div class=""columns is-desktop"">
                    <div class=""column is-8-desktop is-offset-2-desktop is-10-touch is-offset-1-touch"">
                        <div class=""mt4"">
                            <div v-for=""(user, index) in users"">
                            <label class=""label mt3"">CPF</label>
                            <input class=""input"" data-validate=""cpf"" placeholder=""000.000.000-00"" v-model=""user.cpf""><br>
                            <label class=""label mt3"">Nome completo</label>
                            <input class=""input"" data-validate=""text"" v-model=""user.nome"">
                            <label class=""label mt3"">Celular</label>
                            <input class=""input"" data-validate=""brPhone"" v-model=""user.celular"">
                            <label class=""label mt3"">E-mail</label>
                        <input class=""input"" v-model=""user.email"">
                        <label class=""label mt3"">Confirmar e-mail</label>
   ");
                WriteLiteral(@"                     <input class=""input"" v-model=""user.confirmaremail"">
                        <label class=""label mt3"">Autorizações</label>
                        <div class=""columns"">
                            <div class=""column is-6"">
                                <div class=""checkradio100 mt1"">
                                    <input class=""is-checkradio is-info"" id=""checkboxValidar"" type=""checkbox"" name=""exampleCheckboxa"">
                                    <label for=""checkboxValidar"">Carregar e validar duplicatas</label>
                                </div>
                            </div>
                            <div class=""column is-6"">
                                <div class=""checkradio100 mt1"">
                                    <input class=""is-checkradio is-info"" id=""checkboxAceite"" type=""checkbox"" name=""exampleCheckboxa"">
                                    <label for=""checkboxAceite"">Dar aceite/recusar duplicata</label>
                                </div>
             ");
                WriteLiteral(@"               </div>
                        </div>
                        <div class=""columns"">
                            <div class=""column is-6"">
                                <div class=""checkradio100 mt1"">
                                    <input class=""is-checkradio is-info"" id=""checkboxAutorizar"" type=""checkbox"" name=""exampleCheckboxa"">
                                    <label for=""checkboxAutorizar"">Autorizar transferência de titularidades de duplicatas</label>
                                </div>
                            </div>
                            <div class=""column is-6"">
                                <div class=""checkradio100 mt1"">
                                    <input class=""is-checkradio is-info"" id=""checkboxInformar"" type=""checkbox"" name=""exampleCheckboxa"">
                                    <label for=""checkboxInformar"">Informar entrega e liquidação</label>
                                </div>
                            </div>
                        </div>
   ");
                WriteLiteral(@"                     <div class=""columns"">
                            <div class=""column is-6"">
                                <div class=""checkradio100 mt1"">
                                    <input class=""is-checkradio is-info"" id=""checkboxEnviar"" type=""checkbox"" name=""exampleCheckboxa"">
                                    <label for=""checkboxEnviar"">Enviar duplicatas para Protesto</label>
                                </div>
                            </div>
                            <div class=""column is-6"">
                                <div class=""checkradio100 mt1"">
                                    <input class=""is-checkradio is-info"" id=""checkboxEndosso"" type=""checkbox"" name=""exampleCheckboxa"">
                                    <label for=""checkboxEndosso"">Informar endosso</label>
                                </div>
                            </div>
                        </div>
                        <button class=""button is-info"" v-on:click.prevent=""deleteUser(index)"">Deletar</");
                WriteLiteral("button>\n                        <button class=\"button is-info\" v-on:click.prevent=\"addUser\">Novo Usuário</button>\n            ");
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
            BeginContext(18875, 433, true);
            WriteLiteral(@"
        </div>
    </div>
    </div>

    </div>
    <div class=""mb4"" style=""text-align: center"">
    <div style=""text-align: center""> 
    <div style=""text-align: center"">
        <div style=""text-align: center""> 
            <div style=""text-align: center"">
                <button class=""button is-info"" v-on:click.prevent=""enviar"">Enviar convite</button>
            </div>
        </div>
    </div>

</div>
</div>
</div>
</div>");
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
