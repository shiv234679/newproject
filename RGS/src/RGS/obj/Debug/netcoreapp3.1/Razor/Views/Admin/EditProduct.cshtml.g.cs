#pragma checksum "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Admin\EditProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76859ec2f73abb4222fbba35077715c47b8b911c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditProduct), @"mvc.1.0.view", @"/Views/Admin/EditProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76859ec2f73abb4222fbba35077715c47b8b911c", @"/Views/Admin/EditProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eb57e7093d7449df7dc9f0dc766db732a6238f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModels.Models.ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger loaderClick btn-font"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Admin\EditProduct.cshtml"
  
    ViewData["Title"] = "EditProduct";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"m-content\">\r\n    <div class=\"m-portlet m-portlet--mobile\">\r\n        <div class=\"m-portlet__body\" style=\"box-shadow: 0 4px 8px 0 rgba(0,0,0,0.5);\">\r\n            <h4 class=\"text-center pt-3\">Update Product</h4>\r\n");
#nullable restore
#line 9 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Admin\EditProduct.cshtml"
             using (Html.BeginForm("EditProduct", "Admin", FormMethod.Post, new { enctype = "multipart/form-data" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"hidden\" name=\"ProductId\"");
            BeginWriteAttribute("value", " value=\"", 499, "\"", 523, 1);
#nullable restore
#line 11 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Admin\EditProduct.cshtml"
WriteAttributeValue("", 507, Model.ProductId, 507, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                <div class=""row col-12 my-4"">
                    <div class=""col-12"">
                        <div class=""row col-12 py-2"">
                            <label for=""example-text-input"" class=""col-2 offset-1 col-form-label"">
                                <strong class=""required"">Name :</strong>
                            </label>
                            <div class=""col-9"">
                                <input type=""text"" class=""form-control"" placeholder=""Product Name"" name=""ProductName""");
            BeginWriteAttribute("value", " value=\"", 1051, "\"", 1077, 1);
#nullable restore
#line 19 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Admin\EditProduct.cshtml"
WriteAttributeValue("", 1059, Model.ProductName, 1059, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""50"" title=""Only alphabet alllowed."" pattern=""^[a-zA-Z\s]{1,}[a-zA-Z]{1,}$"" required />
                            </div>
                        </div>
                        <div class=""row col-12 py-2"">
                            <label for=""example-text-input"" class=""col-2 offset-1 col-form-label"">
                                <strong class=""required"">Description :</strong>
                            </label>
                            <div class=""col-9"">
                                <input type=""text"" class=""form-control"" placeholder=""Product Description"" name=""ProductDescription""");
            BeginWriteAttribute("value", " value=\"", 1700, "\"", 1733, 1);
#nullable restore
#line 27 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Admin\EditProduct.cshtml"
WriteAttributeValue("", 1708, Model.ProductDescription, 1708, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" maxlength=""150"" title=""Only alphabet alllowed."" pattern=""^[a-zA-Z\s]{1,}[a-zA-Z]{1,}$"" required />
                            </div>
                        </div>
                        <div class=""row col-12 py-2"">
                            <label for=""example-text-input"" class=""col-2 offset-1 col-form-label"">
                                <strong class=""required"">Price :</strong>
                            </label>
                            <div class=""col-9"">
                                <input type=""number"" class=""form-control"" placeholder=""Product Price"" name=""ProductPrice""");
            BeginWriteAttribute("value", " value=\"", 2341, "\"", 2368, 1);
#nullable restore
#line 35 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Admin\EditProduct.cshtml"
WriteAttributeValue("", 2349, Model.ProductPrice, 2349, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" step=""0.01"" min=""0.50"" max=""1000000"" required />
                            </div>
                        </div>
                        <div class=""row col-12 py-2"">
                            <label for=""example-text-input"" class=""col-2 offset-1 col-form-label"">
                                <strong class=""required"">Category:</strong>
                            </label>
                            <div class=""col-9"">
                                <select class=""form-control"" title=""Product Category"" name=""CategoryId"" required>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76859ec2f73abb4222fbba35077715c47b8b911c8937", async() => {
                WriteLiteral("Select Product Category");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Admin\EditProduct.cshtml"
                                     foreach (var item in Model.productCatViewModels)
                                    {
                                        if (Model.CategoryId == item.Id)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76859ec2f73abb4222fbba35077715c47b8b911c10583", async() => {
#nullable restore
#line 49 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Admin\EditProduct.cshtml"
                                                                         Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Admin\EditProduct.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Admin\EditProduct.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76859ec2f73abb4222fbba35077715c47b8b911c13088", async() => {
#nullable restore
#line 53 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Admin\EditProduct.cshtml"
                                                                Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Admin\EditProduct.cshtml"
                                               WriteLiteral(item.Id);

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
#line 54 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Admin\EditProduct.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </select>
                            </div>
                        </div>
                        <div class=""row col-12 py-2"">
                            <label for=""example-text-input"" class=""col-2 offset-1 col-form-label"">
                                <strong class=""required"">Choose Image :</strong>
                            </label>
                            <div class=""col-9"">
                                <input type=""file"" id=""uploadfile"" name=""Image"" accept="".jpg,.jpeg,.png"" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""text-center pb-3"">
                    <button type=""submit"" class=""btn btn-success btn-font"">Update</button>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76859ec2f73abb4222fbba35077715c47b8b911c16028", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 73 "C:\Users\shiva\source\repos\RGS\src\RGS\Views\Admin\EditProduct.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModels.Models.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
