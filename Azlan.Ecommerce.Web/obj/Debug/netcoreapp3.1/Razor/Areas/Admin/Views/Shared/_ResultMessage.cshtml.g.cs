#pragma checksum "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Shared\_ResultMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfa4cce29cbe712f8730532fd91c1f8faaa46a62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__ResultMessage), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_ResultMessage.cshtml")]
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
#line 2 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Azlan.Ecommerce.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Azlan.Ecommerce.Web.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfa4cce29cbe712f8730532fd91c1f8faaa46a62", @"/Areas/Admin/Views/Shared/_ResultMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94e7a4447e183a4e855cd6359eb1199191df03c3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__ResultMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultMessageModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 33, "\"", 96, 7);
            WriteAttributeValue("", 41, "alert", 41, 5, true);
            WriteAttributeValue(" ", 46, "alert-", 47, 7, true);
#nullable restore
#line 3 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Shared\_ResultMessage.cshtml"
WriteAttributeValue("", 53, Model.Css, 53, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 63, "alert-dismissible", 64, 18, true);
            WriteAttributeValue(" ", 81, "fade", 82, 5, true);
            WriteAttributeValue(" ", 86, "show", 87, 5, true);
            WriteAttributeValue(" ", 91, "mb-3", 92, 5, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n    <strong>");
#nullable restore
#line 4 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Shared\_ResultMessage.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</strong> ");
#nullable restore
#line 4 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Shared\_ResultMessage.cshtml"
                              Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n        <span aria-hidden=\"true\">&times;</span>\r\n    </button>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultMessageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591