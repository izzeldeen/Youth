#pragma checksum "D:\Freelance\15-09-2020\Youth\PublicWebsite\Views\Home\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "483ca26a3f556986d7308be060691fffce5055e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PublicWebsite.Views.Home.Views_Home_Product), @"mvc.1.0.view", @"/Views/Home/Product.cshtml")]
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
#line 1 "D:\Freelance\15-09-2020\Youth\PublicWebsite\Views\_ViewImports.cshtml"
using PublicWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Freelance\15-09-2020\Youth\PublicWebsite\Views\_ViewImports.cshtml"
using PublicWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"483ca26a3f556986d7308be060691fffce5055e9", @"/Views/Home/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f8cebdb14d3b35425fe9f904bd818331bfcadae", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PublicWebsite.ViewModels.ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""hero-wrap hero-bread"" style=""background-image: url('../images/bg_1.jpg');"">
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-center justify-content-center"">
            <div class=""col-md-9 ftco-animate text-center"">
                <p class=""breadcrumbs""><span class=""mr-2""><a href=""index.html"">Home</a></span> <span class=""mr-2""><a href=""index.html"">Product</a></span> <span>Product Single</span></p>
                <h1 class=""mb-0 bread"">Product Single</h1>
            </div>
        </div>
    </div>
</div>

<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6 mb-5 ftco-animate"">
                <a href=""../images/product-1.jpg"" class=""image-popup""><img");
            BeginWriteAttribute("src", " src=\"", 842, "\"", 868, 2);
            WriteAttributeValue("", 848, "../", 848, 3, true);
#nullable restore
#line 17 "D:\Freelance\15-09-2020\Youth\PublicWebsite\Views\Home\Product.cshtml"
WriteAttributeValue("", 851, Model.PictuerUrl, 851, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"Colorlib Template\"></a>\r\n            </div>\r\n            <div class=\"col-lg-6 product-details pl-md-5 ftco-animate\">\r\n                <h3>");
#nullable restore
#line 20 "D:\Freelance\15-09-2020\Youth\PublicWebsite\Views\Home\Product.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                <div class=""rating d-flex"">
                    <p class=""text-left mr-4"">
                        <a href=""#"" class=""mr-2"">5.0</a>
                        <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                        <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                        <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                        <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                        <a href=""#""><span class=""ion-ios-star-outline""></span></a>
                    </p>
                    <p class=""text-left mr-4"">
                        <a href=""#"" class=""mr-2"" style=""color: #000;"">100 <span style=""color: #bbb;"">Rating</span></a>
                    </p>
                    <p class=""text-left"">
                        <a href=""#"" class=""mr-2"" style=""color: #000;"">500 <span style=""color: #bbb;"">Sold</span></a>
                    </p>
                </div>
               ");
            WriteLiteral(" <p class=\"price\"><span>");
#nullable restore
#line 37 "D:\Freelance\15-09-2020\Youth\PublicWebsite\Views\Home\Product.cshtml"
                                  Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                <p>\r\n                ");
#nullable restore
#line 39 "D:\Freelance\15-09-2020\Youth\PublicWebsite\Views\Home\Product.cshtml"
           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                <div class=""row mt-4"">
                    <div class=""col-md-6"">
                        <div class=""form-group d-flex"">
                            <div class=""select-wrap"">
                                <div class=""icon""><span class=""ion-ios-arrow-down""></span></div>
                                <select");
            BeginWriteAttribute("name", " name=\"", 2543, "\"", 2550, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2551, "\"", 2556, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "483ca26a3f556986d7308be060691fffce5055e98343", async() => {
                WriteLiteral("Small");
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
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "483ca26a3f556986d7308be060691fffce5055e99537", async() => {
                WriteLiteral("Medium");
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
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "483ca26a3f556986d7308be060691fffce5055e910732", async() => {
                WriteLiteral("Large");
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
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "483ca26a3f556986d7308be060691fffce5055e911927", async() => {
                WriteLiteral("Extra Large");
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
            WriteLiteral(@"
                                </select>
                            </div>
                        </div>
                    </div>
                    <div class=""w-100""></div>
                    <div class=""input-group col-md-6 d-flex mb-3"">
                        <span class=""input-group-btn mr-2"">
                            <button type=""button"" class=""quantity-left-minus btn"" data-type=""minus"" data-field="""">
                                <i class=""ion-ios-remove""></i>
                            </button>
                        </span>
                        <input type=""text"" id=""quantity"" name=""quantity"" class=""form-control input-number"" value=""1"" min=""1"" max=""100"">
                        <span class=""input-group-btn ml-2"">
                            <button type=""button"" class=""quantity-right-plus btn"" data-type=""plus"" data-field="""">
                                <i class=""ion-ios-add""></i>
                            </button>
                        </span>
         ");
            WriteLiteral(@"           </div>
                    <div class=""w-100""></div>
                    <div class=""col-md-12"">
                        <p style=""color: #000;"">600 kg available</p>
                    </div>
                </div>
                <p><a href=""cart.html"" class=""btn btn-black py-3 px-5"">Add to Cart</a></p>
            </div>
        </div>
    </div>
</section>

<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row justify-content-center mb-3 pb-3"">
            <div class=""col-md-12 heading-section text-center ftco-animate"">
                <span class=""subheading"">Products</span>
                <h2 class=""mb-4"">Related Products</h2>
                <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia</p>
            </div>
        </div>
    </div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-lg-3 ftco-animate"">
                <div class=""product"">
           ");
            WriteLiteral(@"         <a href=""#"" class=""img-prod"">
                        <img class=""img-fluid"" src=""../images/product-1.jpg"" alt=""Colorlib Template"">
                        <span class=""status"">30%</span>
                        <div class=""overlay""></div>
                    </a>
                    <div class=""text py-3 pb-4 px-3 text-center"">
                        <h3><a href=""#"">Bell Pepper</a></h3>
                        <div class=""d-flex"">
                            <div class=""pricing"">
                                <p class=""price""><span class=""mr-2 price-dc"">$120.00</span><span class=""price-sale"">$80.00</span></p>
                            </div>
                        </div>
                        <div class=""bottom-area d-flex px-3"">
                            <div class=""m-auto d-flex"">
                                <a href=""#"" class=""add-to-cart d-flex justify-content-center align-items-center text-center"">
                                    <span><i class=""ion-ios-menu""></i");
            WriteLiteral(@"></span>
                                </a>
                                <a href=""#"" class=""buy-now d-flex justify-content-center align-items-center mx-1"">
                                    <span><i class=""ion-ios-cart""></i></span>
                                </a>
                                <a href=""#"" class=""heart d-flex justify-content-center align-items-center "">
                                    <span><i class=""ion-ios-heart""></i></span>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-3 ftco-animate"">
                <div class=""product"">
                    <a href=""#"" class=""img-prod"">
                        <img class=""img-fluid"" src=""../images/product-2.jpg"" alt=""Colorlib Template"">
                        <div class=""overlay""></div>
                    </a>
                    <div class=""text py-3 pb-");
            WriteLiteral(@"4 px-3 text-center"">
                        <h3><a href=""#"">Strawberry</a></h3>
                        <div class=""d-flex"">
                            <div class=""pricing"">
                                <p class=""price""><span>$120.00</span></p>
                            </div>
                        </div>
                        <div class=""bottom-area d-flex px-3"">
                            <div class=""m-auto d-flex"">
                                <a href=""#"" class=""add-to-cart d-flex justify-content-center align-items-center text-center"">
                                    <span><i class=""ion-ios-menu""></i></span>
                                </a>
                                <a href=""#"" class=""buy-now d-flex justify-content-center align-items-center mx-1"">
                                    <span><i class=""ion-ios-cart""></i></span>
                                </a>
                                <a href=""#"" class=""heart d-flex justify-content-center align-items-cente");
            WriteLiteral(@"r "">
                                    <span><i class=""ion-ios-heart""></i></span>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-3 ftco-animate"">
                <div class=""product"">
                    <a href=""#"" class=""img-prod"">
                        <img class=""img-fluid"" src=""../images/product-3.jpg"" alt=""Colorlib Template"">
                        <div class=""overlay""></div>
                    </a>
                    <div class=""text py-3 pb-4 px-3 text-center"">
                        <h3><a href=""#"">Green Beans</a></h3>
                        <div class=""d-flex"">
                            <div class=""pricing"">
                                <p class=""price""><span>$120.00</span></p>
                            </div>
                        </div>
                        <div class=""bottom-area d-flex px-3"">");
            WriteLiteral(@"
                            <div class=""m-auto d-flex"">
                                <a href=""#"" class=""add-to-cart d-flex justify-content-center align-items-center text-center"">
                                    <span><i class=""ion-ios-menu""></i></span>
                                </a>
                                <a href=""#"" class=""buy-now d-flex justify-content-center align-items-center mx-1"">
                                    <span><i class=""ion-ios-cart""></i></span>
                                </a>
                                <a href=""#"" class=""heart d-flex justify-content-center align-items-center "">
                                    <span><i class=""ion-ios-heart""></i></span>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-3 ftco-animate"">
                <div class=""product"">
                    <a ");
            WriteLiteral(@"href=""#"" class=""img-prod"">
                        <img class=""img-fluid"" src=""../images/product-4.jpg"" alt=""Colorlib Template"">
                        <div class=""overlay""></div>
                    </a>
                    <div class=""text py-3 pb-4 px-3 text-center"">
                        <h3><a href=""#"">Purple Cabbage</a></h3>
                        <div class=""d-flex"">
                            <div class=""pricing"">
                                <p class=""price""><span>$120.00</span></p>
                            </div>
                        </div>
                        <div class=""bottom-area d-flex px-3"">
                            <div class=""m-auto d-flex"">
                                <a href=""#"" class=""add-to-cart d-flex justify-content-center align-items-center text-center"">
                                    <span><i class=""ion-ios-menu""></i></span>
                                </a>
                                <a href=""#"" class=""buy-now d-flex justify-cont");
            WriteLiteral(@"ent-center align-items-center mx-1"">
                                    <span><i class=""ion-ios-cart""></i></span>
                                </a>
                                <a href=""#"" class=""heart d-flex justify-content-center align-items-center "">
                                    <span><i class=""ion-ios-heart""></i></span>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""ftco-section ftco-no-pt ftco-no-pb py-5 bg-light"">
    <div class=""container py-4"">
        <div class=""row d-flex justify-content-center py-5"">
            <div class=""col-md-6"">
                <h2 style=""font-size: 22px;"" class=""mb-0"">Subcribe to our Newsletter</h2>
                <span>Get e-mail updates about our latest shops and special offers</span>
            </div>
            <div class=""col-md-6 d-flex align-items-cente");
            WriteLiteral("r\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "483ca26a3f556986d7308be060691fffce5055e922895", async() => {
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PublicWebsite.ViewModels.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
