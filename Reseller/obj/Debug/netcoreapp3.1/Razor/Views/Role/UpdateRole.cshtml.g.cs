#pragma checksum "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Role\UpdateRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beb3b3cfeabb2ded3c15ad93f8e6ef59fe8f4d71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Reseller.Pages.Role.Views_Role_UpdateRole), @"mvc.1.0.view", @"/Views/Role/UpdateRole.cshtml")]
namespace Reseller.Pages.Role
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
#line 6 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Role\UpdateRole.cshtml"
using Reseller.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beb3b3cfeabb2ded3c15ad93f8e6ef59fe8f4d71", @"/Views/Role/UpdateRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc3741aed53c68424714f18016c734543007dae0", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_UpdateRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Reseller.Models.RoleUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Role\UpdateRole.cshtml"
   ViewData["Title"] = "Rol Güncelleme";
    Layout = "_AdminLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            WriteLiteral("\n\n");
#nullable restore
#line 9 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Role\UpdateRole.cshtml"
 using (Html.BeginForm())
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\n    <h3 class=\"text-center mt-5\">Rol Güncelleme Sayfası</h3>\n    <br />\n    ");
#nullable restore
#line 15 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Role\UpdateRole.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"form-group\">\n        <label class=\"control-label col-md-2\">Rol İsmi</label>\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 19 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Role\UpdateRole.cshtml"
       Write(Html.EditorFor(model => model.RoleName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 20 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Role\UpdateRole.cshtml"
       Write(Html.ValidationMessageFor(model => model.RoleName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        <div class=\"col-md-offset-2 col-md-10\">\n            <input type=\"submit\" value=\"Ekle\" class=\"btn btn-success\" style=\"float: right;\" />\n        </div>\n    </div>\n</div>");
#nullable restore
#line 28 "C:\Users\ozgur\source\repos\Reseller\Reseller\Views\Role\UpdateRole.cshtml"
      }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Reseller.Models.RoleUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
