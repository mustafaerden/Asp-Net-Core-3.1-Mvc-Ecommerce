#pragma checksum "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b51866a109cfbda2f555b5ec5a8f8bf62119175d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b51866a109cfbda2f555b5ec5a8f8bf62119175d", @"/Areas/Admin/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94e7a4447e183a4e855cd6359eb1199191df03c3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/uploads/products/no-image.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Product\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    int indexOfImage = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("MainTitle", async() => {
                WriteLiteral("\r\n    <div class=\"w-sm-100 mr-auto\"><h4 class=\"mb-0\">Product Detail</h4></div>\r\n\r\n    <ol class=\"breadcrumb bg-transparent align-self-center m-0 p-0\">\r\n        <li class=\"breadcrumb-item\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b51866a109cfbda2f555b5ec5a8f8bf62119175d6299", async() => {
                    WriteLiteral("Dashboard");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </li>\r\n        <li class=\"breadcrumb-item\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b51866a109cfbda2f555b5ec5a8f8bf62119175d7596", async() => {
                    WriteLiteral("Products");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </li>\r\n        <li class=\"breadcrumb-item\">Product Detail</li>\r\n    </ol>\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12 col-lg-6\">\r\n");
#nullable restore
#line 26 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Product\Detail.cshtml"
                 if (Model.ProductImages.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                        <ol class=""carousel-indicators"">
                            <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                            <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""");
            BeginWriteAttribute("class", " class=\"", 1200, "\"", 1208, 0);
            EndWriteAttribute();
            WriteLiteral("></li>\r\n                            <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"2\"");
            BeginWriteAttribute("class", " class=\"", 1307, "\"", 1315, 0);
            EndWriteAttribute();
            WriteLiteral("></li>\r\n                        </ol>\r\n                        <div class=\"carousel-inner\">\r\n\r\n");
#nullable restore
#line 36 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Product\Detail.cshtml"
                             foreach (var image in Model.ProductImages)
                            {
                                indexOfImage++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div");
            BeginWriteAttribute("class", " class=\"", 1600, "\"", 1658, 2);
            WriteAttributeValue("", 1608, "carousel-item", 1608, 13, true);
#nullable restore
#line 39 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Product\Detail.cshtml"
WriteAttributeValue(" ", 1621, indexOfImage == 1 ? "active" : "", 1622, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b51866a109cfbda2f555b5ec5a8f8bf62119175d11360", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1730, "~/uploads/products/", 1730, 19, true);
#nullable restore
#line 40 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 1749, image, 1749, 6, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 42 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Product\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                            <span class=""sr-only"">Previous</span>
                        </a>
                        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                            <span class=""sr-only"">Next</span>
                        </a>
                    </div>
");
#nullable restore
#line 54 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Product\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b51866a109cfbda2f555b5ec5a8f8bf62119175d14286", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Product\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-md-12 col-lg-6\">\r\n                <div class=\"card-body border brd-gray border-top-0 border-right-0 border-left-0\">\r\n                    <h3 class=\"mb-0 f-weight-500 text-primary\">\r\n                        ");
#nullable restore
#line 63 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Product\Detail.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Product\Detail.cshtml"
                         if (Model.Featured)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span style=\"font-size: 13px;\" class=\"text-danger\"> (Featured Product)</span>\r\n");
#nullable restore
#line 67 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Product\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </h3>
                </div>
                <div class=""card-body border brd-gray border-top-0 border-right-0 border-left-0"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <div class=""float-left ml-2"">
                                <h4 class=""lato-font mb-0 text-danger"">₱");
#nullable restore
#line 74 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Product\Detail.cshtml"
                                                                   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                            </div>
                        </div>

                    </div>
                </div>
                <div class=""card-body border brd-gray border-top-0 border-right-0 border-left-0"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <div class=""float-left ml-2"">
                                <h4 class=""lato-font mb-0"">'");
#nullable restore
#line 84 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Product\Detail.cshtml"
                                                       Write(Model.StockCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' In Stock</h4>
                            </div>
                        </div>

                    </div>
                </div>
                <div class=""card-body border brd-gray border-top-0 border-right-0 border-left-0"">
                    <p class=""mb-0"" lang=""ca"">");
#nullable restore
#line 91 "C:\MyProjects\ECommerce\Azlan.Ecommerce.Web\Areas\Admin\Views\Product\Detail.cshtml"
                                         Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591