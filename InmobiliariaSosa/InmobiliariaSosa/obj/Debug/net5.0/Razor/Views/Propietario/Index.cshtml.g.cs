#pragma checksum "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aca6ee676e55315353f58093c910cfbb2d47e6da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Propietario_Index), @"mvc.1.0.view", @"/Views/Propietario/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aca6ee676e55315353f58093c910cfbb2d47e6da", @"/Views/Propietario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b05941a97388eea506892ef0d2495816a41a48d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Propietario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InmobiliariaSosa.Models.Propietario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
  
    ViewData["Title"] = "Propietario";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>

<button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#crearModal"">
    Crear Propietario
</button>

<div class=""modal fade"" id=""crearModal"" tabindex=""-1"" aria-labelledby=""crearModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""crearModalLabel"">Crear Propietario</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aca6ee676e55315353f58093c910cfbb2d47e6da5065", async() => {
                WriteLiteral(@"
                    <div class=""text-danger""></div>
                    <div class=""form-group"">
                        <label for=""nombre"" class=""control-label"">Nombre</label>
                        <input type=""text"" name=""nombre"" class=""form-control"" />

                    </div>
                    <div class=""form-group"">
                        <label for=""apellido"" class=""control-label"">apellido</label>
                        <input type=""text"" name=""apellido"" class=""form-control"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""dni"" class=""control-label"">dni</label>
                        <input type=""text"" name=""dni"" class=""form-control"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""telefono"" class=""control-label"">telefono</label>
                        <input type=""tel"" name=""telefono"" class=""form-control"" />
                    </div>
             ");
                WriteLiteral(@"       <div class=""form-group"">
                        <label for=""email"" class=""control-label"">email</label>
                        <input type=""email"" name=""email"" class=""form-control"" />
                    </div>
                    <div class=""form-group"">
                        <label for=""clave"" class=""control-label"">clave</label>
                        <input type=""password"" name=""clave"" class=""form-control"" />
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.idPropietario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 65 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 68 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 71 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.dni));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 74 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 77 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 80 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.clave));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 86 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 90 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.idPropietario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 93 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 96 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 99 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.dni));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 102 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 105 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 108 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.clave));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a href=\"#\" data-toggle=\"modal\" data-target=\"#editarModal-");
#nullable restore
#line 111 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
                                                                         Write(item.idPropietario);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        Editar\r\n                    </a> |\r\n                    ");
#nullable restore
#line 114 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.idPropietario }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 115 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.idPropietario }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 4624, "\"", 4660, 2);
            WriteAttributeValue("", 4629, "editarModal-", 4629, 12, true);
#nullable restore
#line 116 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
WriteAttributeValue("", 4641, item.idPropietario, 4641, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 4675, "\"", 4729, 2);
            WriteAttributeValue("", 4693, "editarModalLabel.", 4693, 17, true);
#nullable restore
#line 116 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
WriteAttributeValue("", 4710, item.idPropietario, 4710, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"true\">\r\n                        <div class=\"modal-dialog\">\r\n                            <div class=\"modal-content\">\r\n                                <div class=\"modal-header\">\r\n                                    <h5 class=\"modal-title\"");
            BeginWriteAttribute("id", " id=\"", 4980, "\"", 5021, 2);
            WriteAttributeValue("", 4985, "editarModalLabel.", 4985, 17, true);
#nullable restore
#line 120 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
WriteAttributeValue("", 5002, item.idPropietario, 5002, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Crear Propietario</h5>
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                <div class=""modal-body"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aca6ee676e55315353f58093c910cfbb2d47e6da17507", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"idPropietario\"");
                BeginWriteAttribute("value", " value=\"", 5530, "\"", 5557, 1);
#nullable restore
#line 127 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
WriteAttributeValue("", 5538, item.idPropietario, 5538, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                        <div class=""text-danger""></div>
                                        <div class=""form-group"">
                                            <label for=""nombre"" class=""control-label"">Nombre</label>
                                            <input type=""text"" name=""nombre"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 5901, "\"", 5921, 1);
#nullable restore
#line 131 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
WriteAttributeValue("", 5909, item.nombre, 5909, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

                                        </div>
                                        <div class=""form-group"">
                                            <label for=""apellido"" class=""control-label"">apellido</label>
                                            <input type=""text"" name=""apellido"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 6248, "\"", 6270, 1);
#nullable restore
#line 136 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
WriteAttributeValue("", 6256, item.apellido, 6256, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""dni"" class=""control-label"">dni</label>
                                            <input type=""text"" name=""dni"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 6580, "\"", 6597, 1);
#nullable restore
#line 140 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
WriteAttributeValue("", 6588, item.dni, 6588, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""telefono"" class=""control-label"">telefono</label>
                                            <input type=""tel"" name=""telefono"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 6921, "\"", 6943, 1);
#nullable restore
#line 144 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
WriteAttributeValue("", 6929, item.telefono, 6929, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""email"" class=""control-label"">email</label>
                                            <input type=""email"" name=""email"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 7260, "\"", 7279, 1);
#nullable restore
#line 148 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
WriteAttributeValue("", 7268, item.email, 7268, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""clave"" class=""control-label"">clave</label>
                                            <input type=""text"" name=""clave"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 7595, "\"", 7614, 1);
#nullable restore
#line 152 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
WriteAttributeValue("", 7603, item.clave, 7603, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

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
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 165 "C:\Users\Gonza\Desktop\.NET\Inmobiliaria\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Propietario\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InmobiliariaSosa.Models.Propietario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
