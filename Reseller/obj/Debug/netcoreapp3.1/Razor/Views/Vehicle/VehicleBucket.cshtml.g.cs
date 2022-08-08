#pragma checksum "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Vehicle\VehicleBucket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe973e97e3c238e5fa7ca91f0f04bfc13cd40eec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Reseller.Pages.Vehicle.Views_Vehicle_VehicleBucket), @"mvc.1.0.view", @"/Views/Vehicle/VehicleBucket.cshtml")]
namespace Reseller.Pages.Vehicle
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
#line 1 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\_ViewImports.cshtml"
using Reseller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Vehicle\VehicleBucket.cshtml"
using Reseller.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe973e97e3c238e5fa7ca91f0f04bfc13cd40eec", @"/Views/Vehicle/VehicleBucket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc3741aed53c68424714f18016c734543007dae0", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicle_VehicleBucket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Reseller.Models.Vehicle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vehicle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuyVehicle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Vehicle\VehicleBucket.cshtml"
   ViewData["Title"] = "Araç Satın Al";
    Layout = "_AdminLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"

<h3 class=""text-center mt-5"">Araç Listesi</h3>
<br />
<table class="" table table-sm table-bordered"">
    <thead class=""bg-success text-white"">
        <tr>
            <th>Fotoğraf</th>
            <th>Kategori</th>
            <th>Araç Adı</th>
            <th>Araba Modeli</th>
            <th>Üretim Yılı</th>
            <th>Model Adı</th>
            <th>Şehir</th>
");
            WriteLiteral("            <th>Aracın Durumu</th>\n            <th>Yakıt</th>\n            <th>Fiyat</th>\n            <th>Durum</th>\n        </tr>\n    </thead>\n\n    <tbody>\n");
#nullable restore
#line 29 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Vehicle\VehicleBucket.cshtml"
         foreach (var vehicle in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 32 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Vehicle\VehicleBucket.cshtml"
   Write(vehicle.VehiclePicture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 33 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Vehicle\VehicleBucket.cshtml"
   Write(vehicle.VehicleCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 34 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Vehicle\VehicleBucket.cshtml"
   Write(vehicle.VehicleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 35 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Vehicle\VehicleBucket.cshtml"
   Write(vehicle.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 36 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Vehicle\VehicleBucket.cshtml"
   Write(vehicle.VehicleYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 37 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Vehicle\VehicleBucket.cshtml"
   Write(vehicle.VehicleModelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 38 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Vehicle\VehicleBucket.cshtml"
   Write(vehicle.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("    <td>");
#nullable restore
#line 40 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Vehicle\VehicleBucket.cshtml"
   Write(vehicle.VehicleSituation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 41 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Vehicle\VehicleBucket.cshtml"
   Write(vehicle.FuelType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 42 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Vehicle\VehicleBucket.cshtml"
   Write(vehicle.VehiclePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 43 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Vehicle\VehicleBucket.cshtml"
   Write(vehicle.StatusInfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n    <td>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe973e97e3c238e5fa7ca91f0f04bfc13cd40eec7913", async() => {
                WriteLiteral("\n            Satın Al\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Vehicle\VehicleBucket.cshtml"
                                                                                          WriteLiteral(vehicle.VehicleId);

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
            WriteLiteral("\n    </td>\n\n</tr>\n");
#nullable restore
#line 52 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Vehicle\VehicleBucket.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n\n\n\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Reseller.Models.Vehicle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
