#pragma checksum "D:\A\Programming\Hotelz\Views\Roles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccb4f8d93fbaf61735d6de9889c792018b67cdc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Edit), @"mvc.1.0.view", @"/Views/Roles/Edit.cshtml")]
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
#line 1 "D:\A\Programming\Hotelz\Views\_ViewImports.cshtml"
using Hotelz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\A\Programming\Hotelz\Views\_ViewImports.cshtml"
using Hotelz.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\A\Programming\Hotelz\Views\Roles\Edit.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccb4f8d93fbaf61735d6de9889c792018b67cdc5", @"/Views/Roles/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39d9b2df6604e198feb46a75d54ba17ee099ca60", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hotelz.ViewModels.ChangeRoleViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h2>Изменение ролей для пользователя ");
#nullable restore
#line 4 "D:\A\Programming\Hotelz\Views\Roles\Edit.cshtml"
                                Write(Model.UserEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccb4f8d93fbaf61735d6de9889c792018b67cdc54169", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"userId\"");
                BeginWriteAttribute("value", " value=\"", 226, "\"", 247, 1);
#nullable restore
#line 7 "D:\A\Programming\Hotelz\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 234, Model.UserId, 234, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <div class=\"form-group\">\r\n");
#nullable restore
#line 9 "D:\A\Programming\Hotelz\Views\Roles\Edit.cshtml"
         foreach (IdentityRole role in Model.AllRoles)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"checkbox\" name=\"roles\"");
                BeginWriteAttribute("value", " value=\"", 397, "\"", 415, 1);
#nullable restore
#line 11 "D:\A\Programming\Hotelz\Views\Roles\Edit.cshtml"
WriteAttributeValue("", 405, role.Name, 405, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                   ");
#nullable restore
#line 12 "D:\A\Programming\Hotelz\Views\Roles\Edit.cshtml"
               Write(Model.UserRoles.Contains(role.Name) ? "checked=\"checked\"" : "");

#line default
#line hidden
#nullable disable
                WriteLiteral(" />");
#nullable restore
#line 12 "D:\A\Programming\Hotelz\Views\Roles\Edit.cshtml"
                                                                                    Write(role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\r\n");
#nullable restore
#line 13 "D:\A\Programming\Hotelz\Views\Roles\Edit.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Сохранить</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hotelz.ViewModels.ChangeRoleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
