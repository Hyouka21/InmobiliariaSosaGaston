#pragma checksum "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Contrato\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ac67f7ac8eb5cd8048a584f66b19bb3cf8a9502"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contrato_Details), @"mvc.1.0.view", @"/Views/Contrato/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac67f7ac8eb5cd8048a584f66b19bb3cf8a9502", @"/Views/Contrato/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b05941a97388eea506892ef0d2495816a41a48d9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contrato_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InmobiliariaSosa.Models.Contrato>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Contrato\Details.cshtml"
  
    ViewData["Title"] = "Detalle";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalle</h1>\r\n\r\n<div>\r\n    <h4>Contrato</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Contrato\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Contrato\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Contrato\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdInquilino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Contrato\Details.cshtml"
       Write(Model.Inquilino.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Contrato\Details.cshtml"
                               Write(Model.Inquilino.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Contrato\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdInmueble));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Contrato\Details.cshtml"
       Write(Model.Inmueble.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Contrato\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaDesde));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Contrato\Details.cshtml"
       Write(Model.FechaDesde.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Contrato\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaHasta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Contrato\Details.cshtml"
       Write(Model.FechaHasta.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Contrato\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdGarante));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            \r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Contrato\Details.cshtml"
       Write(Model.Garante.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 49 "C:\Users\gaston.sosa\Source\Repos\InmobiliariaSosaGaston\InmobiliariaSosa\InmobiliariaSosa\Views\Contrato\Details.cshtml"
       Write(Model.Garante.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n   \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ac67f7ac8eb5cd8048a584f66b19bb3cf8a95029256", async() => {
                WriteLiteral("<i class=\"fas fa-backward\"></i> Volver a contratos");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InmobiliariaSosa.Models.Contrato> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
