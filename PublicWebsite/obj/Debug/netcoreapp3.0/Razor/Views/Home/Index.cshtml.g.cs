#pragma checksum "E:\Youth\V4\Youth\PublicWebsite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e33c91e09adb6ec9df03a088ec1577085b4b4de4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PublicWebsite.Views.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\Youth\V4\Youth\PublicWebsite\Views\_ViewImports.cshtml"
using PublicWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Youth\V4\Youth\PublicWebsite\Views\_ViewImports.cshtml"
using PublicWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e33c91e09adb6ec9df03a088ec1577085b4b4de4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f8cebdb14d3b35425fe9f904bd818331bfcadae", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PublicWebsite.ViewModels.CountriesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("add-to-cart d-flex justify-content-center align-items-center text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<section id=\"home-section\" class=\"hero\">\r\n\r\n");
            WriteLiteral("    <h1>");
#nullable restore
#line 8 "E:\Youth\V4\Youth\PublicWebsite\Views\Home\Index.cshtml"
   Write(localizer["HellowWorld"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1> 

   

    <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">

        <div class=""modal-dialog modal-dialog-centered "">
            <div class=""modal-content"">
                <div class=""modal-header"">

                    <h3 class=""text-left"" id=""myModalLabel"">Choose Country</h3>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">×</button>
                </div>
                <div class=""modal-body"">
                    <select onchange=""choice1(this)"" class=""form-control"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e33c91e09adb6ec9df03a088ec1577085b4b4de46463", async() => {
                WriteLiteral("--Select Country--");
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
#line 24 "E:\Youth\V4\Youth\PublicWebsite\Views\Home\Index.cshtml"
                         foreach (var item in Model.Countries)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e33c91e09adb6ec9df03a088ec1577085b4b4de47921", async() => {
#nullable restore
#line 26 "E:\Youth\V4\Youth\PublicWebsite\Views\Home\Index.cshtml"
                                                Write(item.English);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "E:\Youth\V4\Youth\PublicWebsite\Views\Home\Index.cshtml"
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
#line 27 "E:\Youth\V4\Youth\PublicWebsite\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </select>
                </div>
                <div class=""modal-footer"">
                    <button class=""btn btn-success"" data-dismiss=""modal"" aria-hidden=""true"">Save</button>
                </div>
            </div>
        </div>
    </div>





    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""SuspendModal"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Suspension System</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <p>asd</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Okay</button>");
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            WriteLiteral(@"    <div class=""home-slider owl-carousel"">
        <div class=""slider-item"" style=""background-image: url(../images/bg_1.jpg);"">
            <div class=""overlay""></div>
            <div class=""container"">
                <div class=""row slider-text justify-content-center align-items-center"" data-scrollax-parent=""true"">

");
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n");
            WriteLiteral("    </div>\r\n</section>\r\n\r\n<section class=\"ftco-section\">\r\n    <div class=\"container\">\r\n        <div class=\"row no-gutters ftco-services\">\r\n");
            WriteLiteral(@"            <div class=""col-md-4 text-center d-flex align-self-stretch ftco-animate"">
                <div class=""media block-6 services mb-md-0 mb-4"">
                    <div class=""icon bg-color-2 d-flex justify-content-center align-items-center mb-2"">
                        <span class=""flaticon-diet""></span>
                    </div>
                    <div class=""media-body"">
                        <h3 class=""heading"">Always Fresh</h3>
                        <span>Product well package</span>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 text-center d-flex align-self-stretch ftco-animate"">
                <div class=""media block-6 services mb-md-0 mb-4"">
                    <div class=""icon bg-color-3 d-flex justify-content-center align-items-center mb-2"">
                        <span class=""flaticon-award""></span>
                    </div>
                    <div class=""media-body"">
                        <h3 class=""headin");
            WriteLiteral(@"g"">Superior Quality</h3>
                        <span>Quality Products</span>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 text-center d-flex align-self-stretch ftco-animate"">
                <div class=""media block-6 services mb-md-0 mb-4"">
                    <div class=""icon bg-color-4 d-flex justify-content-center align-items-center mb-2"">
                        <span class=""flaticon-customer-service""></span>
                    </div>
                    <div class=""media-body"">
                        <h3 class=""heading"">Support</h3>
                        <span>24/7 Support</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<section class=""ftco-section ftco-category ftco-no-pt"">
    <div class=""container"">
        <div class=""row"">
");
#nullable restore
#line 148 "E:\Youth\V4\Youth\PublicWebsite\Views\Home\Index.cshtml"
             foreach (var item in Model.Categries)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4\">\r\n                  \r\n                    <div class=\"category-wrap ftco-animate img d-flex align-items-end\"");
            BeginWriteAttribute("style", " style=\"", 6584, "\"", 6653, 4);
            WriteAttributeValue("", 6592, "background-image:", 6592, 17, true);
            WriteAttributeValue(" ", 6609, "url(../../Documents/Products/", 6610, 30, true);
#nullable restore
#line 152 "E:\Youth\V4\Youth\PublicWebsite\Views\Home\Index.cshtml"
WriteAttributeValue("", 6639, item.Banner, 6639, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6651, ");", 6651, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"text px-3 py-1\">\r\n                            <h2 class=\"mb-0\"><a href=\"#\">");
#nullable restore
#line 154 "E:\Youth\V4\Youth\PublicWebsite\Views\Home\Index.cshtml"
                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 158 "E:\Youth\V4\Youth\PublicWebsite\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
          
        </div>
    </div>
</section>

<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row justify-content-center mb-3 pb-3"">
            <div class=""col-md-12 heading-section text-center ftco-animate"">
                <span class=""subheading"">Featured Products</span>
");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 178 "E:\Youth\V4\Youth\PublicWebsite\Views\Home\Index.cshtml"
             foreach (var item in Model.products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-3 ftco-animate\">\r\n                    <div class=\"product\">\r\n                        <a href=\"#\" class=\"img-prod\">\r\n                            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 7762, "\"", 7806, 2);
            WriteAttributeValue("", 7768, "../Documents/Products/", 7768, 22, true);
#nullable restore
#line 183 "E:\Youth\V4\Youth\PublicWebsite\Views\Home\Index.cshtml"
WriteAttributeValue("", 7790, item.PictuerUrl, 7790, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Colorlib Template\">\r\n");
            WriteLiteral("                            <div class=\"overlay\"></div>\r\n                        </a>\r\n                        <div class=\"text py-3 pb-4 px-3 text-center\">\r\n                            <h3><a href=\"#\">");
#nullable restore
#line 188 "E:\Youth\V4\Youth\PublicWebsite\Views\Home\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                            <div class=\"d-flex\">\r\n                                <div class=\"pricing\">\r\n                                    <p class=\"price\"><span class=\"mr-2 price-dc\">$120.00</span><span class=\"price-sale\">$ ");
#nullable restore
#line 191 "E:\Youth\V4\Youth\PublicWebsite\Views\Home\Index.cshtml"
                                                                                                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"bottom-area d-flex px-3\">\r\n                                <div class=\"m-auto d-flex\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e33c91e09adb6ec9df03a088ec1577085b4b4de418081", async() => {
                WriteLiteral("\r\n                                        <span><i class=\"ion-ios-menu\"></i></span>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 196 "E:\Youth\V4\Youth\PublicWebsite\Views\Home\Index.cshtml"
                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 8935, "\"", 8964, 3);
            WriteAttributeValue("", 8945, "AddToCart(", 8945, 10, true);
#nullable restore
#line 199 "E:\Youth\V4\Youth\PublicWebsite\Views\Home\Index.cshtml"
WriteAttributeValue("", 8955, item.Id, 8955, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8963, ")", 8963, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""buy-now d-flex justify-content-center align-items-center mx-1"">
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
");
#nullable restore
#line 210 "E:\Youth\V4\Youth\PublicWebsite\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
          
        </div>
    </div>
</section>

<section class=""ftco-section img"" style=""background-image: url(../images/bg_3.jpg);"">
    <div class=""container"">
        <div class=""row justify-content-end"">
            <div class=""col-md-6 heading-section ftco-animate deal-of-the-day ftco-animate"">
                <span class=""subheading"">Best Price For You</span>
                <h2 class=""mb-4"">Deal of the day</h2>
                <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia</p>
                <h3><a href=""#"">Spinach</a></h3>
                <span class=""price"">$10 <a href=""#"">now $5 only</a></span>
                <div id=""timer"" class=""d-flex mt-5"">
                    <div class=""time"" id=""days""></div>
                    <div class=""time pl-3"" id=""hours""></div>
                    <div class=""time pl-3"" id=""minutes""></div>
                    <div class=""time pl-3"" id=""seconds""></div>
                </div>
            </div>
      ");
            WriteLiteral(@"  </div>
    </div>
</section>

<section class=""ftco-section testimony-section"">
    <div class=""container"">
        <div class=""row justify-content-center mb-5 pb-3"">
            <div class=""col-md-7 heading-section ftco-animate text-center"">
                <span class=""subheading"">Testimony</span>
                <h2 class=""mb-4"">Our satisfied customer says</h2>
                <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in</p>
            </div>
        </div>
        <div class=""row ftco-animate"">
            <div class=""col-md-12"">
                <div class=""carousel-testimony owl-carousel"">
                    <div class=""item"">
                        <div class=""testimony-wrap p-4 pb-5"">
                            <div class=""user-img mb-5"" style=""background-image: url(../images/person_1.jpg)"">
                                <span class=""quote d-flex align-items-center justify-content");
            WriteLiteral(@"-center"">
                                    <i class=""icon-quote-left""></i>
                                </span>
                            </div>
                            <div class=""text text-center"">
                                <p class=""mb-5 pl-4 line"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                                <p class=""name"">Garreth Smith</p>
                                <span class=""position"">Marketing Manager</span>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""testimony-wrap p-4 pb-5"">
                            <div class=""user-img mb-5"" style=""background-image: url(../images/person_2.jpg)"">
                                <span class=""quote d-flex align-items-center justify-content-center"">
                                    <i class=""icon-quote-left""></i");
            WriteLiteral(@">
                                </span>
                            </div>
                            <div class=""text text-center"">
                                <p class=""mb-5 pl-4 line"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                                <p class=""name"">Garreth Smith</p>
                                <span class=""position"">Interface Designer</span>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""testimony-wrap p-4 pb-5"">
                            <div class=""user-img mb-5"" style=""background-image: url(../images/person_3.jpg)"">
                                <span class=""quote d-flex align-items-center justify-content-center"">
                                    <i class=""icon-quote-left""></i>
                                </span>
                            </di");
            WriteLiteral(@"v>
                            <div class=""text text-center"">
                                <p class=""mb-5 pl-4 line"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                                <p class=""name"">Garreth Smith</p>
                                <span class=""position"">UI Designer</span>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""testimony-wrap p-4 pb-5"">
                            <div class=""user-img mb-5"" style=""background-image: url(../images/person_1.jpg)"">
                                <span class=""quote d-flex align-items-center justify-content-center"">
                                    <i class=""icon-quote-left""></i>
                                </span>
                            </div>
                            <div class=""text text-center"">
                   ");
            WriteLiteral(@"             <p class=""mb-5 pl-4 line"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts.</p>
                                <p class=""name"">Garreth Smith</p>
                                <span class=""position"">Web Developer</span>
                            </div>
                        </div>
                    </div>
                    <div class=""item"">
                        <div class=""testimony-wrap p-4 pb-5"">
                            <div class=""user-img mb-5"" style=""background-image: url(../images/person_1.jpg)"">
                                <span class=""quote d-flex align-items-center justify-content-center"">
                                    <i class=""icon-quote-left""></i>
                                </span>
                            </div>
                            <div class=""text text-center"">
                                <p class=""mb-5 pl-4 line"">Far far away, behind the word mountains, f");
            WriteLiteral(@"ar from the countries Vokalia and Consonantia, there live the blind texts.</p>
                                <p class=""name"">Garreth Smith</p>
                                <span class=""position"">System Analyst</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

<hr>

<section class=""ftco-section ftco-partner"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm ftco-animate"">
                <a href=""#"" class=""partner""><img src=""../images/partner-1.png"" class=""img-fluid"" alt=""Colorlib Template""></a>
            </div>
            <div class=""col-sm ftco-animate"">
                <a href=""#"" class=""partner""><img src=""../images/partner-2.png"" class=""img-fluid"" alt=""Colorlib Template""></a>
            </div>
            <div class=""col-sm ftco-animate"">
                <a href=""#"" class=""partner""><img src=""../images/partner-3");
            WriteLiteral(@".png"" class=""img-fluid"" alt=""Colorlib Template""></a>
            </div>
            <div class=""col-sm ftco-animate"">
                <a href=""#"" class=""partner""><img src=""../images/partner-4.png"" class=""img-fluid"" alt=""Colorlib Template""></a>
            </div>
            <div class=""col-sm ftco-animate"">
                <a href=""#"" class=""partner""><img src=""../images/partner-5.png"" class=""img-fluid"" alt=""Colorlib Template""></a>
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
            <div class=""col-md-6 d-flex align-items-center"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e33c91e09adb6ec9df03a088ec1577085b4b4de430591", async() => {
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</section>
<script src=""//ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js""></script>

<script>
    console.log(document.cookie);
    if (getCookie('Contry') === """") {
        $(document).ready(function () {
            $('#myModal').modal('show');
        });
    }
    else {
        console.log(""cookies is not null"");
    }
    function getCookie(cname) {
        var name = cname + ""="";
        var decodedCookie = decodeURIComponent(document.cookie);
        var ca = decodedCookie.split(';');
        for (var i = 0; i < ca.length; i++) {
            var c = ca[i];
            while (c.charAt(0) == ' ') {
                c = c.substring(1);
            }
            if (c.indexOf(name) == 0) {

                return c.substring(name.length, c.length);
            }
        }

        return """";
    }
    function choice1(select) {
         var date = new Date();
          date.setTime(date.getTime()+(30*24*60*60*1000)");
            WriteLiteral(");\r\n        document.cookie = \'Contry=\' + select.options[select.selectedIndex].value + \"; expires=\" + date.toGMTString();\r\n        console.log(document.cookie);\r\n    };\r\n</script>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PublicWebsite.ViewModels.CountriesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
