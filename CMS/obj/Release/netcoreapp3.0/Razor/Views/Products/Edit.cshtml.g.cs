#pragma checksum "D:\Freelance\ServerVersion\Youth\CMS\Views\Products\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfddf7466e73f1fe4293cabe3a7dcf6c5ab2d3a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Edit), @"mvc.1.0.view", @"/Views/Products/Edit.cshtml")]
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
#line 1 "D:\Freelance\ServerVersion\Youth\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Freelance\ServerVersion\Youth\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfddf7466e73f1fe4293cabe3a7dcf6c5ab2d3a1", @"/Views/Products/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fda46ac6a24f19109ebb784fda558b061b2e80b", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CMS.Models.ProductModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditAction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!-- Begin Page Content -->
<div class=""container-fluid"">

    <!-- Page Heading -->
    <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
        <h1 class=""h3 mb-0 text-gray-800"">Products</h1>
    </div>

    <div class=""row"">

        <div class=""col-lg-12"">
            <!-- Basic Card Example -->
            <div class=""card shadow mb-4"">
                <div class=""card-header py-3"">
                    <h6 class=""m-0 font-weight-bold text-primary"">Edit ");
#nullable restore
#line 16 "D:\Freelance\ServerVersion\Youth\CMS\Views\Products\Edit.cshtml"
                                                                  Write(Model.NameEn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfddf7466e73f1fe4293cabe3a7dcf6c5ab2d3a15669", async() => {
                WriteLiteral("\r\n                        <div class=\"col-md-6\">\r\n                            <label>\r\n                                Product Name(En)\r\n                            </label>\r\n                            <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 974, "\"", 995, 1);
#nullable restore
#line 24 "D:\Freelance\ServerVersion\Youth\CMS\Views\Products\Edit.cshtml"
WriteAttributeValue("", 982, Model.NameEn, 982, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""NameEn"" class=""form-control"" required />
                        </div>
                        <div class=""col-md-6"">
                            <label>
                                Product Name(Ar)
                            </label>
                            <input type=""text""");
                BeginWriteAttribute("value", " value=\"", 1296, "\"", 1317, 1);
#nullable restore
#line 30 "D:\Freelance\ServerVersion\Youth\CMS\Views\Products\Edit.cshtml"
WriteAttributeValue("", 1304, Model.NameAr, 1304, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""NameAr"" class=""form-control"" required />
                        </div>
                        <div class=""col-md-6 mt-3"">
                            <label>
                                Product Descreption(En)
                            </label>
                            <textarea rows=""5"" name=""DescreptionEn""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1651, "\"", 1685, 1);
#nullable restore
#line 36 "D:\Freelance\ServerVersion\Youth\CMS\Views\Products\Edit.cshtml"
WriteAttributeValue("", 1665, Model.DescreptionEn, 1665, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1686, "\"", 1714, 1);
#nullable restore
#line 36 "D:\Freelance\ServerVersion\Youth\CMS\Views\Products\Edit.cshtml"
WriteAttributeValue("", 1694, Model.DescreptionEn, 1694, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" required></textarea>
                        </div>
                        <div class=""col-md-6 mt-3"">
                            <label>
                                Product Descreption(Ar)
                            </label>
                            <textarea rows=""5"" name=""DescreptionAr""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2043, "\"", 2077, 1);
#nullable restore
#line 42 "D:\Freelance\ServerVersion\Youth\CMS\Views\Products\Edit.cshtml"
WriteAttributeValue("", 2057, Model.DescreptionAr, 2057, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 2099, "\"", 2127, 1);
#nullable restore
#line 42 "D:\Freelance\ServerVersion\Youth\CMS\Views\Products\Edit.cshtml"
WriteAttributeValue("", 2107, Model.DescreptionAr, 2107, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required></textarea>\r\n                        </div>\r\n");
                WriteLiteral("                        <div class=\"col-md-12 text-center mt-5\">\r\n                            <input type=\"submit\" value=\"Submit\" class=\"btn btn-outline-primary\" />\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n<!-- /.container-fluid -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CMS.Models.ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
