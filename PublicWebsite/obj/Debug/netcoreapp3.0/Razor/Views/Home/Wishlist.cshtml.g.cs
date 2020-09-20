#pragma checksum "D:\Freelance\ServerVersion\Youth\PublicWebsite\Views\Home\Wishlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60ea03c55089f4e5ae3e777fc9693fc1f08916b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PublicWebsite.Views.Home.Views_Home_Wishlist), @"mvc.1.0.view", @"/Views/Home/Wishlist.cshtml")]
namespace PublicWebsite.Views.Home
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
#line 1 "D:\Freelance\ServerVersion\Youth\PublicWebsite\Views\_ViewImports.cshtml"
using PublicWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Freelance\ServerVersion\Youth\PublicWebsite\Views\_ViewImports.cshtml"
using PublicWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60ea03c55089f4e5ae3e777fc9693fc1f08916b0", @"/Views/Home/Wishlist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f8cebdb14d3b35425fe9f904bd818331bfcadae", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Wishlist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""hero-wrap hero-bread"" style=""background-image: url('../images/bg_1.jpg');"">
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Home</a></span> <span>Wishlist</span></p>
                <h1 class=""mb-0 bread"">My Wishlist</h1>
            </div>
        </div>
    </div>
</div>

<section class=""ftco-section ftco-cart"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12 ftco-animate"">
                <div class=""cart-list"">
                    <table class=""table"">
                        <thead class=""thead-primary"">
                            <tr class=""text-center"">
                                <th>&nbsp;</th>
                                <th>Product List</th>
                                <th>&nbsp;</th>
                      ");
            WriteLiteral(@"          <th>Price</th>
                                <th>Quantity</th>
                                <th>Total</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr class=""text-center"">
                                <td class=""product-remove""><a href=""#""><span class=""ion-ios-close""></span></a></td>

                                <td class=""image-prod""><div class=""img"" style=""background-image:url(../images/product-1.jpg);""></div></td>

                                <td class=""product-name"">
                                    <h3>Bell Pepper</h3>
                                    <p>Far far away, behind the word mountains, far from the countries</p>
                                </td>

                                <td class=""price"">$4.90</td>

                                <td class=""quantity"">
                                    <div class=""input-group mb-3"">
                             ");
            WriteLiteral(@"           <input type=""text"" name=""quantity"" class=""quantity form-control input-number"" value=""1"" min=""1"" max=""100"">
                                    </div>
                                </td>

                                <td class=""total"">$4.90</td>
                            </tr><!-- END TR-->

                            <tr class=""text-center"">
                                <td class=""product-remove""><a href=""#""><span class=""ion-ios-close""></span></a></td>

                                <td class=""image-prod""><div class=""img"" style=""background-image:url(../images/product-2.jpg);""></div></td>

                                <td class=""product-name"">
                                    <h3>Bell Pepper</h3>
                                    <p>Far far away, behind the word mountains, far from the countries</p>
                                </td>

                                <td class=""price"">$15.70</td>

                                <td class=""quantity"">
      ");
            WriteLiteral(@"                              <div class=""input-group mb-3"">
                                        <input type=""text"" name=""quantity"" class=""quantity form-control input-number"" value=""1"" min=""1"" max=""100"">
                                    </div>
                                </td>

                                <td class=""total"">$15.70</td>
                            </tr><!-- END TR-->

                            <tr class=""text-center"">
                                <td class=""product-remove""><a href=""#""><span class=""ion-ios-close""></span></a></td>

                                <td class=""image-prod""><div class=""img"" style=""background-image:url(../images/product-3.jpg);""></div></td>

                                <td class=""product-name"">
                                    <h3>Bell Pepper</h3>
                                    <p>Far far away, behind the word mountains, far from the countries</p>
                                </td>

                                <t");
            WriteLiteral(@"d class=""price"">$15.70</td>

                                <td class=""quantity"">
                                    <div class=""input-group mb-3"">
                                        <input type=""text"" name=""quantity"" class=""quantity form-control input-number"" value=""1"" min=""1"" max=""100"">
                                    </div>
                                </td>

                                <td class=""total"">$15.70</td>
                            </tr><!-- END TR-->

                            <tr class=""text-center"">
                                <td class=""product-remove""><a href=""#""><span class=""ion-ios-close""></span></a></td>

                                <td class=""image-prod""><div class=""img"" style=""background-image:url(../images/product-4.jpg);""></div></td>

                                <td class=""product-name"">
                                    <h3>Bell Pepper</h3>
                                    <p>Far far away, behind the word mountains, far from th");
            WriteLiteral(@"e countries</p>
                                </td>

                                <td class=""price"">$15.70</td>

                                <td class=""quantity"">
                                    <div class=""input-group mb-3"">
                                        <input type=""text"" name=""quantity"" class=""quantity form-control input-number"" value=""1"" min=""1"" max=""100"">
                                    </div>
                                </td>

                                <td class=""total"">$15.70</td>
                            </tr><!-- END TR-->

                            <tr class=""text-center"">
                                <td class=""product-remove""><a href=""#""><span class=""ion-ios-close""></span></a></td>

                                <td class=""image-prod""><div class=""img"" style=""background-image:url(../images/product-5.jpg);""></div></td>

                                <td class=""product-name"">
                                    <h3>Bell Pepper</h3>");
            WriteLiteral(@"
                                    <p>Far far away, behind the word mountains, far from the countries</p>
                                </td>

                                <td class=""price"">$15.70</td>

                                <td class=""quantity"">
                                    <div class=""input-group mb-3"">
                                        <input type=""text"" name=""quantity"" class=""quantity form-control input-number"" value=""1"" min=""1"" max=""100"">
                                    </div>
                                </td>

                                <td class=""total"">$15.70</td>
                            </tr><!-- END TR-->

                            <tr class=""text-center"">
                                <td class=""product-remove""><a href=""#""><span class=""ion-ios-close""></span></a></td>

                                <td class=""image-prod""><div class=""img"" style=""background-image:url(../images/product-6.jpg);""></div></td>

                        ");
            WriteLiteral(@"        <td class=""product-name"">
                                    <h3>Bell Pepper</h3>
                                    <p>Far far away, behind the word mountains, far from the countries</p>
                                </td>

                                <td class=""price"">$15.70</td>

                                <td class=""quantity"">
                                    <div class=""input-group mb-3"">
                                        <input type=""text"" name=""quantity"" class=""quantity form-control input-number"" value=""1"" min=""1"" max=""100"">
                                    </div>
                                </td>

                                <td class=""total"">$15.70</td>
                            </tr><!-- END TR-->
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""ftco-section ftco-no-pt ftco-no-pb py-5 bg-light"">
    <div class=""container py-4""");
            WriteLiteral(@">
        <div class=""row d-flex justify-content-center py-5"">
            <div class=""col-md-6"">
                <h2 style=""font-size: 22px;"" class=""mb-0"">Subcribe to our Newsletter</h2>
                <span>Get e-mail updates about our latest shops and special offers</span>
            </div>
            <div class=""col-md-6 d-flex align-items-center"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60ea03c55089f4e5ae3e777fc9693fc1f08916b013025", async() => {
                WriteLiteral(@"
                    <div class=""form-group d-flex"">
                        <input type=""text"" class=""form-control"" placeholder=""Enter email address"">
                        <input type=""submit"" value=""Subscribe"" class=""submit px-3"">
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
