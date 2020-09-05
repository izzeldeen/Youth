#pragma checksum "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "920d9cd40c685b36e127f2d667bc4e8a9a4d33cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "D:\Freelance\YoghurtAlawaneh\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Freelance\YoghurtAlawaneh\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"920d9cd40c685b36e127f2d667bc4e8a9a4d33cd", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fda46ac6a24f19109ebb784fda558b061b2e80b", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CMS.ViewModels.UsersViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Block", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UnBlock", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
   
    string admin = "Admin";
    string user = "User";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Begin Page Content -->\r\n<div class=\"container-fluid\">\r\n\r\n    <!-- Page Heading -->\r\n    <h1 class=\"h3 mb-2 text-gray-800\">Users</h1>\r\n\r\n    <!-- DataTales Example -->\r\n    <div class=\"card shadow mb-4\">\r\n");
            WriteLiteral(@"        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Fullname</th>
                            <th>Phonenumber</th>
");
            WriteLiteral(@"                            <th>Blocked</th>
                            <th>Role</th>
                            <th>Created At</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 33 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                         foreach (var elem in Model.Users)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 36 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                               Write(elem.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                               Write(elem.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 37 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                                               Write(elem.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                               Write(elem.Phonenumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                <td>");
#nullable restore
#line 40 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                               Write(elem.IsBlocked);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 42 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                                     if (elem.RoleId == 1)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                                   Write(admin);

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                                              
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                                   Write(user);

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                                             
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>");
#nullable restore
#line 51 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                               Write(elem.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 53 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                                     if (elem.IsBlocked == true)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a href=\"#\" data-target=\"#unblockModal_");
#nullable restore
#line 55 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                                                                          Write(elem.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" class=\"fas fa-unlock-alt\">  Unblock</a>\r\n");
#nullable restore
#line 56 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a href=\"#\" data-target=\"#blockModal_");
#nullable restore
#line 60 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                                                                        Write(elem.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" class=\"fas fa-user-lock\">  Block</a>\r\n");
#nullable restore
#line 61 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                            </tr>\r\n");
            WriteLiteral("                            <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2800, "\"", 2824, 2);
            WriteAttributeValue("", 2805, "blockModal_", 2805, 11, true);
#nullable restore
#line 66 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
WriteAttributeValue("", 2816, elem.Id, 2816, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                <div class=""modal-dialog modal-dialog-centered"">
                                    <div class=""modal-content"">
                                        <div class=""modal-header"">
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                <span aria-hidden=""true"">&times;</span>
                                            </button>
                                        </div>
                                        <div class=""modal-body"">
                                            Are You Sure You Want To Block This User ?
                                        </div>
                                        <div class=""modal-footer"">
                                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                        ");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "920d9cd40c685b36e127f2d667bc4e8a9a4d33cd12344", async() => {
                WriteLiteral("Block");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                                                                                                                  WriteLiteral(elem.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 4191, "\"", 4217, 2);
            WriteAttributeValue("", 4196, "unblockModal_", 4196, 13, true);
#nullable restore
#line 84 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
WriteAttributeValue("", 4209, elem.Id, 4209, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                                <div class=""modal-dialog modal-dialog-centered"">
                                    <div class=""modal-content"">
                                        <div class=""modal-header"">
                                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                                <span aria-hidden=""true"">&times;</span>
                                            </button>
                                        </div>
                                        <div class=""modal-body"">
                                            Are You Sure You Want To UnBlock This User ?
                                        </div>
                                        <div class=""modal-footer"">
                                            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                      ");
            WriteLiteral("                      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "920d9cd40c685b36e127f2d667bc4e8a9a4d33cd16583", async() => {
                WriteLiteral("Confirm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                                                                                                                     WriteLiteral(elem.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 102 "D:\Freelance\YoghurtAlawaneh\CMS\Views\Users\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n<!-- /.container-fluid -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CMS.ViewModels.UsersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
