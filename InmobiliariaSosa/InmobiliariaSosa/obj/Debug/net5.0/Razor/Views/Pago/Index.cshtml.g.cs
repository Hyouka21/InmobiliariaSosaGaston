#pragma checksum "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5edfcc553228483bb54f00978ec0ba6627826fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pago_Index), @"mvc.1.0.view", @"/Views/Pago/Index.cshtml")]
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
#line 1 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\_ViewImports.cshtml"
using InmobiliariaSosa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\_ViewImports.cshtml"
using InmobiliariaSosa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5edfcc553228483bb54f00978ec0ba6627826fc", @"/Views/Pago/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b05941a97388eea506892ef0d2495816a41a48d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Pago_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InmobiliariaSosa.Models.Pago>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Detalles"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Eliminar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
  
    ViewData["Title"] = "Pagos";
    int numeroPago = Model.Count() + 1;
    int idContrato= ViewBag.idContratoR;
    var hoy = DateTime.Now.Date.ToString();
    var con = ViewBag.contrato;
    var saldo = ViewBag.contrato.Precio;



#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""text/javascript"" onl>

    function editar(x){

        $(""#editarModal"").modal(""show"");

        var numeroP = $('#' + x + '-Numero')[0].innerText;
        var monto = $('#' + x + '-Monto')[0].innerText;
        $(""#NumeroPago"")[0].value = numeroP;
        $(""#Id"")[0].value = x;
        $(""#Monto"")[0].value = monto;


    }
</script>
<h1>
    Pagos del contrato del inmueble con direccion en  ");
#nullable restore
#line 29 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
                                                 Write(con.Inmueble.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    del inquilino de nombre ");
#nullable restore
#line 30 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
                       Write(con.Inquilino.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
                                             Write(con.Inquilino.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</h1>

<button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#crearModal"">
    Crear Pago
</button>

<div class=""modal fade"" id=""crearModal"" tabindex=""-1"" aria-labelledby=""crearModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""crearModalLabel"">Crear Pago</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5edfcc553228483bb54f00978ec0ba6627826fc9224", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5edfcc553228483bb54f00978ec0ba6627826fc9502", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 48 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"ContratoId\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1705, "\"", 1726, 1);
#nullable restore
#line 49 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
WriteAttributeValue("", 1713, idContrato, 1713, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"NumeroPago\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1811, "\"", 1832, 1);
#nullable restore
#line 50 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
WriteAttributeValue("", 1819, numeroPago, 1819, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"FechaPago\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1916, "\"", 1930, 1);
#nullable restore
#line 51 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
WriteAttributeValue("", 1924, hoy, 1924, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <div class=\"form-group\">\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 2012, "\"", 2018, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"control-label\">Monto del contrato ");
#nullable restore
#line 53 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
                                                                          Write(saldo);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </label>
                        
                    </div>
                    <div class=""form-group"">
                        <label for=""Monto"" class=""control-label"">Precio</label>
                        <input name=""Monto"" class=""form-control"" />
                        <span for=""Monto"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <input type=""submit"" value=""Crear"" class=""btn btn-primary"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 73 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 76 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumeroPago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 79 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaPago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 82 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Monto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 89 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 93 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    \r\n                </td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 3393, "\"", 3413, 2);
#nullable restore
#line 96 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
WriteAttributeValue("", 3398, item.Id, 3398, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3406, "-Numero", 3406, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 97 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumeroPago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 100 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
                Write(item.FechaPago);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 3611, "\"", 3630, 2);
#nullable restore
#line 102 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
WriteAttributeValue("", 3616, item.Id, 3616, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3624, "-Monto", 3624, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 103 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Monto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    <div class=\"btn-group\" role=\"group\"");
            BeginWriteAttribute("aria-label", " aria-label=\"", 3799, "\"", 3812, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 3866, "\"", 3900, 3);
            WriteAttributeValue("", 3873, "javascript:editar(", 3873, 18, true);
#nullable restore
#line 108 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
WriteAttributeValue("", 3891, item.Id, 3891, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3899, ")", 3899, 1, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Editar\">\r\n\r\n                            <i class=\"fas fa-edit\"></i>\r\n                        </a>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5edfcc553228483bb54f00978ec0ba6627826fc20411", async() => {
                WriteLiteral("<i class=\"fas fa-info-circle\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5edfcc553228483bb54f00978ec0ba6627826fc22859", async() => {
                WriteLiteral("<i class=\"fas fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 113 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                       \r\n                    </div>\r\n                   \r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 119 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<div class=""modal fade"" id=""editarModal"" tabindex=""-1"" aria-labelledby=""editarModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""editarModalLabel"">Editar Pago</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5edfcc553228483bb54f00978ec0ba6627826fc26260", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" id=\"Id\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 5097, "\"", 5105, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"ContratoId\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 5190, "\"", 5211, 1);
#nullable restore
#line 134 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
WriteAttributeValue("", 5198, idContrato, 5198, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <div class=\"form-group\">\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 5293, "\"", 5299, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"control-label\">Numero de pago </label>\r\n                        <input type=\"text\" name=\"NumeroPago\" id=\"NumeroPago\" required/>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 5541, "\"", 5547, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"control-label\">Monto del contrato ");
#nullable restore
#line 140 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Pago\Index.cshtml"
                                                                          Write(saldo);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </label>

                    </div>
                    <div class=""form-group"">
                        <label for=""Monto"" class=""control-label"">Precio</label>
                        <input name=""Monto"" class=""form-control"" id=""Monto"" required/>
                        <span for=""Monto"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <input type=""submit"" value=""Editar"" class=""btn btn-primary"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InmobiliariaSosa.Models.Pago>> Html { get; private set; }
    }
}
#pragma warning restore 1591
