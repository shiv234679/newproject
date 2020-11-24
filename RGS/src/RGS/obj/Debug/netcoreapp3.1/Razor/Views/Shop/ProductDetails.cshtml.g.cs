#pragma checksum "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Shop\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c03cdb21b98195c81c1b9a857a40d56188cbd05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_ProductDetails), @"mvc.1.0.view", @"/Views/Shop/ProductDetails.cshtml")]
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
#line 1 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\_ViewImports.cshtml"
using RGS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\_ViewImports.cshtml"
using RGS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c03cdb21b98195c81c1b9a857a40d56188cbd05", @"/Views/Shop/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eb57e7093d7449df7dc9f0dc766db732a6238f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels.Models.ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Shop\ProductDetails.cshtml"
  
    ViewData["Title"] = "ProductDetails";
    Layout = "~/Views/Shared/_MasterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""featured spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title"">
                    <h2>Products</h2>
                </div>
            </div>
        </div>
        <div class=""row featured__filter"">
");
#nullable restore
#line 16 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Shop\ProductDetails.cshtml"
              
                var modelData = Model.productViewModels.OrderByDescending(x => x.ProductId);
                foreach (var item in modelData)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-md-4 col-sm-6\">\r\n                        <div class=\"product__item\">\r\n                            <div class=\"product__item__pic set-bg\" data-setbg=\"");
#nullable restore
#line 22 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Shop\ProductDetails.cshtml"
                                                                          Write(item.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("onclick", "onclick=\'", 851, "\'", 943, 7);
            WriteAttributeValue("", 860, "window.location.href", 860, 20, true);
            WriteAttributeValue(" ", 880, "=", 881, 2, true);
            WriteAttributeValue(" ", 882, "\"/Shop/ShopDetails?Id=", 883, 23, true);
#nullable restore
#line 22 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Shop\ProductDetails.cshtml"
WriteAttributeValue("", 905, item.ProductId, 905, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 920, "&Cid=", 920, 5, true);
#nullable restore
#line 22 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Shop\ProductDetails.cshtml"
WriteAttributeValue("", 925, item.CategoryId, 925, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 941, "\";", 941, 2, true);
            EndWriteAttribute();
            WriteLiteral(@"style=""cursor:pointer;"">
                                <ul class=""product__item__pic__hover"">
                                    <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                                    <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                                </ul>
                            </div>
                            <div class=""product__item__text"">
                                <h6><a href=""#"">");
#nullable restore
#line 30 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Shop\ProductDetails.cshtml"
                                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                <h5>₹");
#nullable restore
#line 31 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Shop\ProductDetails.cshtml"
                                Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 35 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Shop\ProductDetails.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModels.Models.ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591