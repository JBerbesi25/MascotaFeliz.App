#pragma checksum "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascota\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a4fc76eff9859314adb3e02f006257ecdb15781"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Mascota.Pages_Mascota_List), @"mvc.1.0.razor-page", @"/Pages/Mascota/List.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Mascota
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
#line 1 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a4fc76eff9859314adb3e02f006257ecdb15781", @"/Pages/Mascota/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Mascota_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Mascotas Afiliadas</h1>\r\n<table class=\"table\">\r\n");
#nullable restore
#line 7 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascota\List.cshtml"
     foreach (var mascota in Model.Mascotas)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 11 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascota\List.cshtml"
           Write(mascota.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n             <td>\r\n                ");
#nullable restore
#line 14 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascota\List.cshtml"
           Write(mascota.Propietario);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n             <td>\r\n                ");
#nullable restore
#line 17 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascota\List.cshtml"
           Write(mascota.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 20 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascota\List.cshtml"
           Write(mascota.Raza);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 23 "C:\Veterinaria\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascota\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.ListModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591