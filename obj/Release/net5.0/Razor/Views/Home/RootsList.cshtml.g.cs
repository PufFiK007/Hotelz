#pragma checksum "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "892c5dca4f12a726e60bd5ac47c39ba56ff357a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RootsList), @"mvc.1.0.view", @"/Views/Home/RootsList.cshtml")]
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
#line 1 "D:\A\Programming\qwe\Hotelz\Views\_ViewImports.cshtml"
using Hotelz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\A\Programming\qwe\Hotelz\Views\_ViewImports.cshtml"
using Hotelz.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"892c5dca4f12a726e60bd5ac47c39ba56ff357a9", @"/Views/Home/RootsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39d9b2df6604e198feb46a75d54ba17ee099ca60", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RootsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Sort"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/CompileRoot"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
  
    ViewData["Title"] = "Roots";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>

    h3 {
        font-size: 35px;
        text-transform: uppercase;
        text-align: center;
        padding: 5%;
    }

    h5 {
        font-size: 20px;
        text-align: center;
        padding-left: 15%;
        padding-right: 15%;
        padding-top: 10px;
    }

    th {
        font-size: 17px;
        text-decoration: underline;
    }

    .dropbtn {
        color: azure;
        font-size: 16px;
        background: #161818;
        border: 1px;
        cursor: pointer;
        -webkit-border-radius: 5px;
        border-radius: 5px;
        width: 100px;
        height: 26px;
    }

    /* The container <div> - needed to position the dropdown content */
    .dropdown {
        position: relative;
        display: inline-block;
    }

    /* Dropdown Content (Hidden by Default) */
    .dropdown-content {
        display: none;
        position: absolute;
        background-color: #f1f1f1;
        min-width: 120px;
        min-height: 30px;
");
            WriteLiteral(@"        box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
        z-index: 1;
    }

    /* Show the dropdown menu on hover */
    .dropdown:hover .dropdown-content {
        display: block;
    }

    /* Change the background color of the dropdown button when the dropdown content is shown */
    .dropdown:hover .dropbtn {
        background-color: #35353A;
    }

    .sortField {
        border: 0px;
        min-height: 27px;
        min-width: 120px;
        text-align: left;
    }

        .sortField:hover {
            background-color: #525258;
        }

    input[type=checkbox] {
        padding: 8px;
        height: 25px;
        width: 25px;
        background-color: #eee;
    }

    .confirm {
        border: 4px;
        min-height: 50px;
        min-width: 180px;
        font-size: 20px;
        text-align: left;
        position: fixed;
        right: 150px;
        bottom: 200px;
        border-radius: 10px;
        background-color: #35353A;
        text-t");
            WriteLiteral(@"ransform: uppercase;
        text-align: center;
        color: azure;
    }

        .confirm:hover {
            background-color: #525258;
        }

    /* On mouse-over, add a grey background color */
    .input[type=checkbox]:hover {
        background-color: #ccc;
    }

    /* When the checkbox is checked, add a blue background */
    .input[type=checkbox]:checked {
        background-color: #2196F3;
    }

    .t_text {
        border: 2px;
        min-height: 30px;
        min-width: 100px;
        font-size: 15px;
        position: fixed;
        right: 150px;
        bottom: 270px;
        border-radius: 5px;
        background-color: azure;
        text-transform: uppercase;
        text-align: center;
        color: #35353A;
    }

    .i_text {
        border: 1px solid black;
        min-height: 20px;
        width: 90px;
        font-size: 16px;
        position: fixed;
        right: 150px;
        bottom: 260px;
        border-radius: 5px;
        ");
            WriteLiteral(@"background-color: azure;
        text-transform: uppercase;
        text-align: center;
        color: #35353A;
    }

    .c_border {
        position: fixed;
        right: 130px;
        bottom: 190px;
        border-radius: 10px;
        border: 2.5px solid black;
        height: 135px;
        width: 275px;
    }

    a {
        color: #35353A;
    }

        a:hover {
            color: #35353A;
            font-size: 17px;
        }

    .Hot {
        font-size: 10px;
        margin-left: 5px;
        vertical-align: 10px;
    }

    .EmpltyFields {
        font-size: 30px;
        text-align: center;
        width: 700px;
        height: 100px;
        border: 1.5px solid;
        border-color: #AB4725;
        background-color: #ECA396;
        color: #C01717;
        margin-left: 20%;
    }
</style>

<script>
    function onlyOneFirst(checkbox) {

        var checkboxes = document.getElementsByName('t_id')
        checkboxes.forEach((item) => {
    ");
            WriteLiteral(@"        if (item !== checkbox) item.checked = false
        })
    }

    function onlyOneSecond(checkbox) {

        var checkboxes = document.getElementsByName('a_id')
        checkboxes.forEach((item) => {
            if (item !== checkbox) item.checked = false
        })
    }

    function showhide(hot) {
        var showme = document.getElementById('hide');
        var checkboxes = document.getElementsByName('a_id')
        var isTrue = 0;
        checkboxes.forEach((item) => {
            if (item.checked == true) isTrue = 1;
        })
        if (showme.style.display !== 'none' && isTrue == 0 || hot == 0) {
            showme.style.display = 'none';
        }
        else {
            showme.style.display = 'block';
        }
    }


</script>
");
#nullable restore
#line 215 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
 if (@ViewBag.Error != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"EmpltyFields\">\r\n        ");
#nullable restore
#line 218 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
   Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 220 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Availible roots:</h3>\r\n<div class=\"dropdown\">\r\n    <button class=\"dropbtn\">Sort</button>\r\n    <div class=\"dropdown-content\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "892c5dca4f12a726e60bd5ac47c39ba56ff357a910120", async() => {
                WriteLiteral(@"
            <input type=""submit"" class=""sortField"" name=""type"" value=""Economic"" />
            <input type=""submit"" class=""sortField"" name=""type"" value=""Luxury"" />
            <input type=""submit"" class=""sortField"" name=""type"" value=""Hot Tours"" />
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div>\r\n    <h5 style=\"float: left\">Tickets</h5>\r\n    <h5 style=\"float: right\">Accomodation</h5>\r\n</div>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "892c5dca4f12a726e60bd5ac47c39ba56ff357a912068", async() => {
                WriteLiteral("\r\n    <div>\r\n        <table width=300px border=\"0\" style=\"float: left\">\r\n            <tr>\r\n                <th>Root</th>\r\n                <th>Cost</th>\r\n            </tr>\r\n");
#nullable restore
#line 244 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
             foreach (var item in Model.Tickets)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td><input type=\"checkbox\" name=\"t_id\" onclick=\"onlyOneFirst(this)\"");
                BeginWriteAttribute("value", " value=", 6008, "", 6023, 1);
#nullable restore
#line 247 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
WriteAttributeValue("", 6015, item.Id, 6015, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> ");
#nullable restore
#line 247 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
                                                                                                   Write(item.Departure);

#line default
#line hidden
#nullable disable
                WriteLiteral(" -> ");
#nullable restore
#line 247 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
                                                                                                                      Write(item.Destination);

#line default
#line hidden
#nullable disable
                WriteLiteral(" -> ");
#nullable restore
#line 247 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
                                                                                                                                           Write(item.Departure);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 248 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
                   Write(item.Cost);

#line default
#line hidden
#nullable disable
                WriteLiteral("$</td>\r\n                </tr>\r\n                <tr>\r\n                    <td style=\"padding-bottom:8px\">");
#nullable restore
#line 251 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
                                              Write(item.Transport);

#line default
#line hidden
#nullable disable
                WriteLiteral(" -  ");
#nullable restore
#line 251 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
                                                                 Write(item.TripLength);

#line default
#line hidden
#nullable disable
                WriteLiteral(" hrs <p> Departure: ");
#nullable restore
#line 251 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
                                                                                                     Write(ViewBag.date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p></td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 254 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n\r\n        <table width=300px border=\"0\" style=\"float: right\">\r\n            <tr>\r\n                <th>Hotel</th>\r\n                <th>Cost</th>\r\n            </tr>\r\n");
#nullable restore
#line 262 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
             foreach (var item in Model.Accomodation)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n");
#nullable restore
#line 266 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
                         if (@item.Term > 1)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <input type=\"checkbox\" name=\"a_id\" onclick=\"onlyOneSecond(this); showhide(0);\"");
                BeginWriteAttribute("value", " value=", 6822, "", 6837, 1);
#nullable restore
#line 268 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
WriteAttributeValue("", 6829, item.Id, 6829, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 6870, "\"", 6941, 5);
                WriteAttributeValue("", 6877, "https://www.google.com/search?q=", 6877, 32, true);
#nullable restore
#line 269 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
WriteAttributeValue("", 6909, item.Hotel, 6909, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6920, "+", 6920, 1, true);
#nullable restore
#line 269 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
WriteAttributeValue("", 6921, item.Location, 6921, 14, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6935, "+hotel", 6935, 6, true);
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\" style=\"display: inline-block\">");
#nullable restore
#line 269 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
                                                                                                                                                Write(item.Hotel);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a><p style=\"display: inline-block\">-");
#nullable restore
#line 269 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
                                                                                                                                                                                                 Write(item.Term);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p><p style=\"display: inline-block\"> days </p><p class=\"Hot\" style=\"display: inline-block\"> hot<span>&#128293</span></p>\r\n");
#nullable restore
#line 270 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 271 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
                         if (@item.Term == 1)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <input type=\"checkbox\" name=\"a_id\" onclick=\"onlyOneSecond(this); showhide(1);\"");
                BeginWriteAttribute("value", " value=", 7378, "", 7393, 1);
#nullable restore
#line 273 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
WriteAttributeValue("", 7385, item.Id, 7385, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 7426, "\"", 7497, 5);
                WriteAttributeValue("", 7433, "https://www.google.com/search?q=", 7433, 32, true);
#nullable restore
#line 274 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
WriteAttributeValue("", 7465, item.Hotel, 7465, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 7476, "+", 7476, 1, true);
#nullable restore
#line 274 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
WriteAttributeValue("", 7477, item.Location, 7477, 14, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 7491, "+hotel", 7491, 6, true);
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\" style=\"display: inline-block\">");
#nullable restore
#line 274 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
                                                                                                                                                Write(item.Hotel);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a><p style=\"display: inline-block\">-");
#nullable restore
#line 274 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
                                                                                                                                                                                                 Write(item.Term);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p><p style=\"display: inline-block\"> day </p>\r\n");
#nullable restore
#line 275 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </td>\r\n\r\n                    <td>");
#nullable restore
#line 278 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
                   Write(item.Cost);

#line default
#line hidden
#nullable disable
                WriteLiteral("$</td>\r\n                </tr>\r\n");
#nullable restore
#line 280 "D:\A\Programming\qwe\Hotelz\Views\Home\RootsList.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </table>
    </div>
    <div class=""c_border"" id=""hide"" style=""display:none;"">
        <p class=""t_text"">Please, enter your trip length:</p>
        <input type=""number"" name=""t_length"" class=""i_text"" />
    </div>
    <input type=""submit"" class=""confirm"" value=""Confirm"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
