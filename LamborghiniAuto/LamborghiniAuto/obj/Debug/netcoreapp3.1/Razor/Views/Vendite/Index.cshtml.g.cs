#pragma checksum "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\Vendite\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94550065c3af397bd1f6ba68d7c47e22b6ffba71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendite_Index), @"mvc.1.0.view", @"/Views/Vendite/Index.cshtml")]
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
#line 1 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\_ViewImports.cshtml"
using LamborghiniAuto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\_ViewImports.cshtml"
using LamborghiniAuto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94550065c3af397bd1f6ba68d7c47e22b6ffba71", @"/Views/Vendite/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1bb190a5af3f140a86183200bbed1b0a1a03701", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendite_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<LamborghiniAuto.Models.Vendita>, List<string>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\Vendite\Index.cshtml"
   ViewData["Title"] = "Vendite"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\Vendite\Index.cshtml"
   string [] mesi = { "Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre"}; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Vendite</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94550065c3af397bd1f6ba68d7c47e22b6ffba715122", async() => {
                WriteLiteral("Aggiungi vendita");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>

<div class=""event-schedule-area-two bg-color pad100"">
    <div class=""tab-content"" id=""myTabContent"">
        <div class=""tab-pane fade active show"" id=""home"" role=""tabpanel"">
            <div class=""table-responsive text-white"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th class=""text-center"" scope=""col"">Data</th>
                            <th scope=""col"">Auto</th>
                            <th scope=""col"">Informazioni</th>
                            <th scope=""col""></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 27 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\Vendite\Index.cshtml"
                         for (int i = 0; i < Model.Item1.Count(); i++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"inner-box\">\r\n                            <th scope=\"row\">\r\n                                <div class=\"event-date\">\r\n                                    <span>");
#nullable restore
#line 32 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\Vendite\Index.cshtml"
                                     Write(Model.Item1[i].dataVendita.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <p>");
#nullable restore
#line 33 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\Vendite\Index.cshtml"
                                  Write(mesi[Model.Item1[i].dataVendita.Month - 1]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\Vendite\Index.cshtml"
                                                                              Write(Model.Item1[i].dataVendita.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </th>\r\n                            <td>\r\n                                <div class=\"event-img\">\r\n");
#nullable restore
#line 38 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\Vendite\Index.cshtml"
                                      string percorso = $"img/{Model.Item2[i]}.jpg";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img");
            BeginWriteAttribute("src", " src=", 1761, "", 1775, 1);
#nullable restore
#line 39 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\Vendite\Index.cshtml"
WriteAttributeValue("", 1766, percorso, 1766, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1775, "\"", 1781, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                                </div>
                            </td>
                            <td>
                                <div class=""event-wrap"">
                                    <div class=""meta"">
                                        <div class=""organizers"">
                                            <a href=""#"">Acquirente: ");
#nullable restore
#line 46 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\Vendite\Index.cshtml"
                                                               Write(Model.Item1[i].cognome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 46 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\Vendite\Index.cshtml"
                                                                                       Write(Model.Item1[i].cognome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </div>\r\n                                        <div class=\"categories\">\r\n                                            <a href=\"#\">Codice Fiscale: ");
#nullable restore
#line 49 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\Vendite\Index.cshtml"
                                                                   Write(Model.Item1[i].codFisc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </div>\r\n                                        <div>\r\n                                            <span>Ora: ");
#nullable restore
#line 52 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\Vendite\Index.cshtml"
                                                  Write(Model.Item1[i].dataVendita.TimeOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        </div>
                                    </div>
                                </div>
                            </td>
                            <td>
                                <div class=""r-no"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94550065c3af397bd1f6ba68d7c47e22b6ffba7111908", async() => {
                WriteLiteral("Modifica");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\Vendite\Index.cshtml"
                                                           WriteLiteral(Model.Item1[i].id);

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
            WriteLiteral(" |\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94550065c3af397bd1f6ba68d7c47e22b6ffba7114162", async() => {
                WriteLiteral("Dettagli");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\Vendite\Index.cshtml"
                                                              WriteLiteral(Model.Item1[i].id);

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
            WriteLiteral(" |\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94550065c3af397bd1f6ba68d7c47e22b6ffba7116419", async() => {
                WriteLiteral("Elimina");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 61 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\Vendite\Index.cshtml"
                                                             WriteLiteral(Model.Item1[i].id);

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
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 65 "C:\Users\ricky\Documents\GitHub\Gestionale-Lamborghini\LamborghiniAuto\LamborghiniAuto\Views\Vendite\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<LamborghiniAuto.Models.Vendita>, List<string>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
