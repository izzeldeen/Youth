#pragma checksum "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bcf367ead6d8360fc4d532103cd7575f5d2e11d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PublicWebsite.Views.Order.Views_Order_Cart), @"mvc.1.0.view", @"/Views/Order/Cart.cshtml")]
namespace PublicWebsite.Views.Order
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
#line 1 "E:\Youth\V5\Youth\PublicWebsite\Views\_ViewImports.cshtml"
using PublicWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Youth\V5\Youth\PublicWebsite\Views\_ViewImports.cshtml"
using PublicWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bcf367ead6d8360fc4d532103cd7575f5d2e11d", @"/Views/Order/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f8cebdb14d3b35425fe9f904bd818331bfcadae", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ShoppingCart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary py-3 px-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section class=\"ftco-section ftco-cart\">\r\n    <div class=\"container\">\r\n\r\n");
#nullable restore
#line 7 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
         if (Model.ShoppingCartItems != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bcf367ead6d8360fc4d532103cd7575f5d2e11d4912", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-12 ftco-animate fadeInUp ftco-animated"">
                    <div class=""cart-list"">
                        <table class=""table"">
                            <thead class=""thead-primary"">
                                <tr class=""text-center"">
                                    <th>&nbsp;</th>
                                    <th>&nbsp;</th>
                                    <th>");
#nullable restore
#line 18 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
                                   Write(localizer["Product name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
#line 19 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
                                   Write(localizer["Price"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
#line 20 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
                                   Write(localizer["Quantity"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                    <th>");
#nullable restore
#line 21 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
                                   Write(localizer["Total"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n                               \r\n\r\n                               \r\n");
#nullable restore
#line 28 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
                                 foreach (var item in Model.ShoppingCartItems)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr class=\"text-center\">\r\n                                        <td class=\"product-remove\"><a");
                BeginWriteAttribute("onclick", " onclick=\"", 1396, "\"", 1433, 3);
                WriteAttributeValue("", 1406, "RemoveItem(", 1406, 11, true);
#nullable restore
#line 31 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
WriteAttributeValue("", 1417, item.ProductId, 1417, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1432, ")", 1432, 1, true);
                EndWriteAttribute();
                WriteLiteral("><span class=\"ion-ios-close\"></span></a></td>\r\n\r\n                                        <td class=\"image-prod\"><img");
                BeginWriteAttribute("src", " src=\"", 1550, "\"", 1572, 1);
#nullable restore
#line 33 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
WriteAttributeValue("", 1556, item.PictuerUrl, 1556, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"image-fluid\"></td>\r\n\r\n                                        <td class=\"product-name\">\r\n                                            <h3>");
#nullable restore
#line 36 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                            <p>");
#nullable restore
#line 37 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
                                          Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                        </td>\r\n\r\n                                        <td class=\"price\">");
#nullable restore
#line 40 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
                                                     Write(item.ProductSpecification.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                        <td class=""quantity"">
                                            <div class=""input-group mb-3"">
                                               
                                                 <input type=""text"" name=""quantity"" class=""quantity form-control input-number""");
                BeginWriteAttribute("id", " id=\"", 2265, "\"", 2298, 2);
                WriteAttributeValue("", 2270, "input-number-", 2270, 13, true);
#nullable restore
#line 44 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
WriteAttributeValue("", 2283, item.ProductId, 2283, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2299, "\"", 2320, 1);
#nullable restore
#line 44 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
WriteAttributeValue("", 2307, item.Quntity, 2307, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onchange", " onchange=\"", 2321, "\"", 2361, 3);
                WriteAttributeValue("", 2332, "labelCounter(", 2332, 13, true);
#nullable restore
#line 44 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
WriteAttributeValue("", 2345, item.ProductId, 2345, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2360, ")", 2360, 1, true);
                EndWriteAttribute();
                WriteLiteral(" name=\"Quntity\" min=\"1\" max=\"100\"> \r\n                                            </div>\r\n                                        </td>\r\n\r\n");
#nullable restore
#line 48 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
                                           var TotalAmout = item.Quntity * item.ProductSpecification.Price;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td class=\"total\">");
#nullable restore
#line 49 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
                                                     Write(TotalAmout);

#line default
#line hidden
#nullable disable
                WriteLiteral(" JOD</td>\r\n                                    </tr><!-- END TR-->\r\n");
#nullable restore
#line 51 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"

                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <div class=""row justify-content-end"">
                <div class=""col-lg-4 mt-5 cart-wrap ftco-animate fadeInUp ftco-animated"">
                    <div class=""cart-total mb-3"">
                        <h3>");
#nullable restore
#line 63 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
                       Write(localizer["Cart Totals"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                       \r\n                        <hr>\r\n                        <p class=\"d-flex total-price\">\r\n                            <span>");
#nullable restore
#line 67 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
                             Write(localizer["Total"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            <span>");
#nullable restore
#line 68 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
                             Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        </p>\r\n                    </div>\r\n                    <p>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bcf367ead6d8360fc4d532103cd7575f5d2e11d13360", async() => {
#nullable restore
#line 71 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
                                                                                                                                      Write(localizer["Proceed to Checkout"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-TotalPrice", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
                                                                              WriteLiteral(Model.Price);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TotalPrice"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-TotalPrice", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TotalPrice"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 75 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
        }
        else {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 77 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
Write(localizer["Cart is Empty"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 78 "E:\Youth\V5\Youth\PublicWebsite\Views\Order\Cart.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       \r\n\r\n    </div>          \r\n</section>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ShoppingCart> Html { get; private set; }
    }
}
#pragma warning restore 1591
