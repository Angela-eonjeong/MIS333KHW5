#pragma checksum "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cac261aa0d45401d9e1c43d9d6477d8060ee9e89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Kim_Angela_Eonjeong_HW5.Views.RoleAdmin.Views_RoleAdmin_Edit), @"mvc.1.0.view", @"/Views/RoleAdmin/Edit.cshtml")]
namespace Kim_Angela_Eonjeong_HW5.Views.RoleAdmin
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
#line 2 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/_ViewImports.cshtml"
using Kim_Angela_Eonjeong_HW5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cac261aa0d45401d9e1c43d9d6477d8060ee9e89", @"/Views/RoleAdmin/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"482763cd5f9f3bfbddbfc2eb768c040efef73e5e", @"/Views/_ViewImports.cshtml")]
    public class Views_RoleAdmin_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleEditModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
  
    ViewBag.Title = "Edit Role";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Edit Role: ");
#nullable restore
#line 6 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
          Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n");
#nullable restore
#line 8 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 10 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"hidden\" name=\"roleName\"");
            BeginWriteAttribute("value", " value=\"", 193, "\"", 217, 1);
#nullable restore
#line 12 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
WriteAttributeValue("", 201, Model.Role.Name, 201, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n    <div class=\"panel panel-primary\">\n        <div class=\"panel-heading\">Add To ");
#nullable restore
#line 14 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
                                     Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <table class=\"table table-striped\">\n");
#nullable restore
#line 16 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
             if (Model.RoleNonMembers.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td colspan=\"3\">All Users Are Members</td>\n                </tr>\n");
#nullable restore
#line 21 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <th>User Name</th>\n                    <th>Email</th>\n                    <th>Add to Role</th>\n                </tr>\n");
#nullable restore
#line 29 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
                foreach (AppUser user in Model.RoleNonMembers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 32 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
                       Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 33 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
                       Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            <input type=\"checkbox\" name=\"IdsToAdd\"");
            BeginWriteAttribute("value", " value=\"", 1042, "\"", 1058, 1);
#nullable restore
#line 35 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
WriteAttributeValue("", 1050, user.Id, 1050, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                        </td>\n                    </tr>\n");
#nullable restore
#line 38 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\n    </div>\n");
            WriteLiteral("    <div class=\"panel panel-primary\">\n        <div class=\"panel-heading\">Remove from ");
#nullable restore
#line 44 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
                                          Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n        <table class=\"table table-striped\">\n");
#nullable restore
#line 46 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
             if (Model.RoleMembers.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td colspan=\"3\">No Users Are Members</td>\n                </tr>\n");
#nullable restore
#line 51 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <th>User Name</th>\n                    <th>Email</th>\n                    <th>Remove From Role</th>\n                </tr>\n");
#nullable restore
#line 59 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
                foreach (AppUser user in Model.RoleMembers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 62 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
                       Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 63 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
                       Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            <input type=\"checkbox\" name=\"IdsToDelete\"");
            BeginWriteAttribute("value", " value=\"", 2006, "\"", 2022, 1);
#nullable restore
#line 65 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
WriteAttributeValue("", 2014, user.Id, 2014, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                        </td>\n                    </tr>\n");
#nullable restore
#line 68 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\n    </div>\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-danger\">Save</button>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cac261aa0d45401d9e1c43d9d6477d8060ee9e8913013", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 75 "/Users/eonjeongkim/Library/Mobile Documents/com~apple~CloudDocs/Exchange Student/Class Material/web programming/HW5/Kim_Angela_Eonjeong_HW5/Kim_Angela_Eonjeong_HW5/Views/RoleAdmin/Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleEditModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
