#pragma checksum "E:\Youth\V5\Youth\PublicWebsite\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58cac9749adeb9a1eb618785663d7b20e66aa33f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PublicWebsite.Views.User.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
namespace PublicWebsite.Views.User
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58cac9749adeb9a1eb618785663d7b20e66aa33f", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f8cebdb14d3b35425fe9f904bd818331bfcadae", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DAL.Dto.EditProfileDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-white p-5 contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<section class=\"ftco-section contact-section bg-light\">\r\n    <div class=\"container\">\r\n        <div class=\"row block-9\">\r\n            <div class=\"col-md-6 order-md-last d-flex mx-auto\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58cac9749adeb9a1eb618785663d7b20e66aa33f4741", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                   <img");
                BeginWriteAttribute("src", " src=\"", 717, "\"", 739, 2);
                WriteAttributeValue("", 723, "../", 723, 3, true);
#nullable restore
#line 17 "E:\Youth\V5\Youth\PublicWebsite\Views\User\Index.cshtml"
WriteAttributeValue("", 726, Model.Avatar, 726, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"personal-img\"  />\r\n                    <div class=\"form-group\">\r\n                        <input type=\"hidden\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 878, "\"", 895, 1);
#nullable restore
#line 19 "E:\Youth\V5\Youth\PublicWebsite\Views\User\Index.cshtml"
WriteAttributeValue("", 886, Model.Id, 886, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  placeholder=\"Firstname\" name=\"Id\">\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", "  value=\"", 1071, "\"", 1096, 1);
#nullable restore
#line 22 "E:\Youth\V5\Youth\PublicWebsite\Views\User\Index.cshtml"
WriteAttributeValue("", 1080, Model.Firstname, 1080, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1097, "\"", 1134, 1);
#nullable restore
#line 22 "E:\Youth\V5\Youth\PublicWebsite\Views\User\Index.cshtml"
WriteAttributeValue("", 1111, localizer["Firstname"], 1111, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Firstname\">\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", "  value=\"", 1292, "\"", 1316, 1);
#nullable restore
#line 25 "E:\Youth\V5\Youth\PublicWebsite\Views\User\Index.cshtml"
WriteAttributeValue("", 1301, Model.Lastname, 1301, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1317, "\"", 1353, 1);
#nullable restore
#line 25 "E:\Youth\V5\Youth\PublicWebsite\Views\User\Index.cshtml"
WriteAttributeValue("", 1331, localizer["Lastname"], 1331, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Lastname\">\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", "  value=\"", 1510, "\"", 1537, 1);
#nullable restore
#line 28 "E:\Youth\V5\Youth\PublicWebsite\Views\User\Index.cshtml"
WriteAttributeValue("", 1519, Model.Phonenumber, 1519, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1538, "\"", 1577, 1);
#nullable restore
#line 28 "E:\Youth\V5\Youth\PublicWebsite\Views\User\Index.cshtml"
WriteAttributeValue("", 1552, localizer["Phonenumber"], 1552, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Phonenumber"">
                    </div>
                    <div class=""form-group"">
                        <input type=""file"" class=""form-control-file""  name=""Avatar"">
                    </div>
                    <div class=""form-group"">
                        <input type=""submit""");
                BeginWriteAttribute("value", " value=\"", 1878, "\"", 1906, 1);
#nullable restore
#line 34 "E:\Youth\V5\Youth\PublicWebsite\Views\User\Index.cshtml"
WriteAttributeValue("", 1886, localizer["Update"], 1886, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary py-3 px-5  float-right\">\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DAL.Dto.EditProfileDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
