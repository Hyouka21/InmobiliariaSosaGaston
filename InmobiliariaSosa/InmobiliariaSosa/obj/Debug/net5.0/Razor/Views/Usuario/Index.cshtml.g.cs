#pragma checksum "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd1b2ad58ed887f3d50a70d8b47424bf8e420525"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
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
#line 1 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\_ViewImports.cshtml"
using InmobiliariaSosa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\_ViewImports.cshtml"
using InmobiliariaSosa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd1b2ad58ed887f3d50a70d8b47424bf8e420525", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b05941a97388eea506892ef0d2495816a41a48d9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InmobiliariaSosa.Models.Usuario>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Detalles"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Eliminar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
  
    ViewData["Title"] = "Usuarios";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script type=""text/javascript"" onl>
    function editar(x){

        $(""#editarModal"").modal(""show"");

        var nombre = $('#' + x + '-nombre')[0].innerText;
        var apellido = $('#' + x + '-apellido')[0].innerText;
        var email = $('#' + x + '-email')[0].innerText;
        var rol = $('#rol')[0].value;
        $(""#Id"")[0].value = x;
        $(""#Nombre"")[0].value = nombre;
        $(""#Apellido"")[0].value = apellido;

        $(""#Email"")[0].value = email;

        $(""#Select option:selected"").removeAttr(""selected"");
        $(`#Select option[value=""${rol}""]`).attr(""selected"", true);

    }
</script>

<h1>Usuarios</h1>

<button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#crearModal"">
    Crear Usuario
</button>

<div class=""modal fade"" id=""crearModal"" tabindex=""-1"" aria-labelledby=""crearModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5");
            WriteLiteral(@" class=""modal-title"" id=""crearModalLabel"">Crear Usuario</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1b2ad58ed887f3d50a70d8b47424bf8e4205258877", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1b2ad58ed887f3d50a70d8b47424bf8e4205259155", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 44 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
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
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""Nombre"" class=""control-label"">Nombre</label>
                        <input name=""Nombre"" class=""form-control"" />
                        <span for=""Nombre"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label for=""Apellido"" class=""control-label"">Apellido</label>
                        <input name=""Apellido"" class=""form-control"" />
                        <span for=""Apellido"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label for=""Email"" class=""control-label"">Email</label>
                        <input name=""Email"" type=""email"" class=""form-control"" />
                        <span for=""Email"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label for=""Clave"" class=""control-label"">");
                WriteLiteral(@"Contraseña</label>
                        <input name=""Clave"" type=""password"" class=""form-control"" />
                        <span for=""Clave"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label for=""AvatarFile"" class=""control-label"">Foto de perfil</label>
                        <input type=""file"" name=""AvatarFile"" />
                        <span for=""AvatarFile"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label"">Rol</label>
                        <select class=""form-control"" name=""Rol"">
");
#nullable restore
#line 73 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
                             foreach (var kvp in (IDictionary<int, string>)ViewBag.Roles)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1b2ad58ed887f3d50a70d8b47424bf8e42052513078", async() => {
#nullable restore
#line 75 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
                                                    Write(kvp.Value);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
                                   WriteLiteral(kvp.Key);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 76 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </select>
                        <span for=""Rol"" class=""text-danger""></span>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<table class=\"table\" id=\"tabla\" >\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 92 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 95 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 98 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 101 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 105 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Avatar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 109 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RolNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 115 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 119 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 4787, "\"", 4807, 2);
#nullable restore
#line 121 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 4792, item.Id, 4792, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4800, "-nombre", 4800, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 122 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 4917, "\"", 4939, 2);
#nullable restore
#line 124 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 4922, item.Id, 4922, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4930, "-apellido", 4930, 9, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 125 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td");
            BeginWriteAttribute("id", " id=\"", 5051, "\"", 5070, 2);
#nullable restore
#line 127 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 5056, item.Id, 5056, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5064, "-email", 5064, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 128 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    <img width=\"32\"");
            BeginWriteAttribute("src", " src=\"", 5219, "\"", 5237, 1);
#nullable restore
#line 132 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 5225, item.Avatar, 5225, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </td>\r\n\r\n                <td >\r\n                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 5331, "\"", 5348, 1);
#nullable restore
#line 136 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 5339, item.Rol, 5339, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"rol\"/>\r\n                    ");
#nullable restore
#line 137 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RolNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <div class=\"btn-group\" role=\"group\"");
            BeginWriteAttribute("aria-label", " aria-label=\"", 5529, "\"", 5542, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 5596, "\"", 5630, 3);
            WriteAttributeValue("", 5603, "javascript:editar(", 5603, 18, true);
#nullable restore
#line 141 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 5621, item.Id, 5621, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5629, ")", 5629, 1, true);
            EndWriteAttribute();
            WriteLiteral(" title=\"Editar\">\r\n\r\n                            <i class=\"fas fa-edit\"></i>\r\n                        </a>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1b2ad58ed887f3d50a70d8b47424bf8e42052524672", async() => {
                WriteLiteral("<i class=\"fas fa-info-circle\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 145 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1b2ad58ed887f3d50a70d8b47424bf8e42052527116", async() => {
                WriteLiteral("<i class=\"fas fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 146 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        \r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 151 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
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
                <h5 class=""modal-title"" id=""editarModalLabel"">Editar Usuario</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1b2ad58ed887f3d50a70d8b47424bf8e42052530490", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" id=\"Id\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 6841, "\"", 6849, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    <div class=""form-group"">
                        <label for=""Nombre"" class=""control-label"">Nombre</label>
                        <input name=""Nombre"" class=""form-control"" id=""Nombre"" required />
                        <span for=""Nombre"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label for=""Apellido"" class=""control-label"">Apellido</label>
                        <input name=""Apellido"" class=""form-control"" id=""Apellido""  required />
                        <span for=""Apellido"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label for=""Email"" class=""control-label"">Email</label>
                        <input name=""Email"" type=""email"" class=""form-control"" id=""Email"" required />
                        <span for=""Email"" class=""text-danger""></span>
                    </div>
                    
                    <");
                WriteLiteral(@"div class=""form-group"">
                        <label for=""Clave"" class=""control-label"">Nueva Contraseña</label>
                        <input name=""Clave"" type=""password"" class=""form-control"" />
                        <span for=""Clave"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label for=""AvatarFile"" class=""control-label"">Foto de perfil</label>
                        <input type=""file"" name=""AvatarFile"" />
                        <span for=""AvatarFile"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label"">Rol</label>
                        <select class=""form-control"" name=""Rol"" id=""Select"" required>
");
#nullable restore
#line 195 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
                             foreach (var kvp in (IDictionary<int, string>)ViewBag.Roles)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd1b2ad58ed887f3d50a70d8b47424bf8e42052533315", async() => {
#nullable restore
#line 197 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
                                                    Write(kvp.Value);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 197 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
                                   WriteLiteral(kvp.Key);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 198 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Usuario\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </select>
                        <span for=""Rol"" class=""text-danger""></span>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InmobiliariaSosa.Models.Usuario>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
