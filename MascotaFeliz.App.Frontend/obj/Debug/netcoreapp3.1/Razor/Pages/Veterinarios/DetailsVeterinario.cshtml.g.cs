#pragma checksum "C:\Veterinaria1\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetailsVeterinario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8753829a7b3c4b3ee314e311ca219bc4074a2562"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Veterinarios.Pages_Veterinarios_DetailsVeterinario), @"mvc.1.0.razor-page", @"/Pages/Veterinarios/DetailsVeterinario.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Veterinarios
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
#line 1 "C:\Veterinaria1\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8753829a7b3c4b3ee314e311ca219bc4074a2562", @"/Pages/Veterinarios/DetailsVeterinario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Veterinarios_DetailsVeterinario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListVeterinario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-image: url(/img/fondopaticas.jpg);background-position: center center;background-repeat: no-repeat;background-size: cover;background-attachment: fixed;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8753829a7b3c4b3ee314e311ca219bc4074a25624372", async() => {
                WriteLiteral("\r\n    <div class=\"row d-flex justify-content-center \">\r\n        <div");
                BeginWriteAttribute("class", " class=\"", 329, "\"", 337, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <div class=\"border shadow rounded p-4 bg-light\" style=\"min-width: 700px;\">\r\n                <div class=\"row d-flex justify-content-center\">\r\n                    <div class=\"col-10\">\r\n                        ");
#nullable restore
#line 13 "C:\Veterinaria1\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetailsVeterinario.cshtml"
                   Write(Html.Raw(@ViewData["Respuesta"]));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col m-3\">\r\n                        <h2>");
#nullable restore
#line 18 "C:\Veterinaria1\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetailsVeterinario.cshtml"
                       Write(Model.Veterinarios.Nombres);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                        <div>\r\n                            Id: ");
#nullable restore
#line 20 "C:\Veterinaria1\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetailsVeterinario.cshtml"
                           Write(Model.Veterinarios.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div>\r\n                            Identificaci??n: ");
#nullable restore
#line 23 "C:\Veterinaria1\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetailsVeterinario.cshtml"
                                       Write(Model.Veterinarios.Identificacion);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div>\r\n                            Nombre: ");
#nullable restore
#line 26 "C:\Veterinaria1\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetailsVeterinario.cshtml"
                               Write(Model.Veterinarios.Nombres);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div>\r\n                            Apellido: ");
#nullable restore
#line 29 "C:\Veterinaria1\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetailsVeterinario.cshtml"
                                 Write(Model.Veterinarios.Apellidos);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div>\r\n                            Telefono: ");
#nullable restore
#line 32 "C:\Veterinaria1\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetailsVeterinario.cshtml"
                                 Write(Model.Veterinarios.Telefono);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div>\r\n                            Direcci??n: ");
#nullable restore
#line 35 "C:\Veterinaria1\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetailsVeterinario.cshtml"
                                  Write(Model.Veterinarios.Direccion);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        <div>\r\n                            Tarjeta Profesional ");
#nullable restore
#line 38 "C:\Veterinaria1\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Veterinarios\DetailsVeterinario.cshtml"
                                           Write(Model.Veterinarios.TarjetaProfesional);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </div>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8753829a7b3c4b3ee314e311ca219bc4074a25628679", async() => {
                    WriteLiteral("Volver");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>            \r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("                          ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.DetailsVeterinarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetailsVeterinarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetailsVeterinarioModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.DetailsVeterinarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
