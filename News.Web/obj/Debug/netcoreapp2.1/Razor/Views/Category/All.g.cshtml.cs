#pragma checksum "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed9d77ca347439c70d63887569796e3a1200dd24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_All), @"mvc.1.0.view", @"/Views/Category/All.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/All.cshtml", typeof(AspNetCore.Views_Category_All))]
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
#line 1 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\_ViewImports.cshtml"
using News.Web;

#line default
#line hidden
#line 2 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\_ViewImports.cshtml"
using News.Web.Models;

#line default
#line hidden
#line 3 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\_ViewImports.cshtml"
using News.Models;

#line default
#line hidden
#line 5 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\_ViewImports.cshtml"
using News.Web.Models.ViewModels;

#line default
#line hidden
#line 6 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\_ViewImports.cshtml"
using News.Services.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed9d77ca347439c70d63887569796e3a1200dd24", @"/Views/Category/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bae7c410d1ae230faf45dd3b3f27ea4401b2deba", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<News.Models.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary hvr-grow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger hvr-grow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml"
  
    ViewData["Title"] = "All";

#line default
#line hidden
            BeginContext(106, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(190, 98, true);
            WriteLiteral("\r\n\r\n<div style=\"text-align: center\">\r\n    <div style=\"display:inline-block; margin-right:20px;\">\r\n");
            EndContext();
#line 13 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml"
         if (this.User.IsInRole("Administrator") || this.User.IsInRole("Moderator"))
        {

#line default
#line hidden
            BeginContext(385, 66, true);
            WriteLiteral("            <button type=\"submit\" class=\"btn btn-success hvr-grow\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 451, "\"", 510, 3);
            WriteAttributeValue("", 461, "location.href=\'", 461, 15, true);
#line 15 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml"
WriteAttributeValue("", 476, Url.Action("Create", "Category"), 476, 33, false);

#line default
#line hidden
            WriteAttributeValue("", 509, "\'", 509, 1, true);
            EndWriteAttribute();
            BeginContext(511, 55, true);
            WriteLiteral(" value=\"Create Category\">Create new Category</button>\r\n");
            EndContext();
#line 16 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml"
        }

#line default
#line hidden
            BeginContext(577, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 18 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml"
     if (TempData["orderLevel"].ToString() == "name_descending")
    {

#line default
#line hidden
            BeginContext(662, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(670, 519, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ce019ca09af4db1bc2ce5c4d60a885c", async() => {
                BeginContext(719, 37, true);
                WriteLiteral("\r\n            <div>\r\n                ");
                EndContext();
                BeginContext(757, 299, false);
#line 22 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml"
           Write(Html.DropDownList("ordertype", new List<SelectListItem>
                {
                new SelectListItem{ Text="Name Asc", Value = "name_ascending",},
                new SelectListItem{ Text="Name Desc", Value = "name_descending", Selected = true },
                }, new { id = "sort2" }));

#line default
#line hidden
                EndContext();
                BeginContext(1056, 126, true);
                WriteLiteral("\r\n                <button class=\"btn btn-primary hvr-grow\" type=\"submit\" /><strong>Sort</strong>\r\n            </div>\r\n        ");
                EndContext();
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
            EndContext();
            BeginContext(1189, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 30 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1215, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1223, 518, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a284325986e4844a65a9907a8e401f4", async() => {
                BeginContext(1272, 37, true);
                WriteLiteral("\r\n            <div>\r\n                ");
                EndContext();
                BeginContext(1310, 298, false);
#line 35 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml"
           Write(Html.DropDownList("ordertype", new List<SelectListItem>
                {
                new SelectListItem{ Text="Name Asc", Value = "name_ascending", Selected = true},
                new SelectListItem{ Text="Name Desc", Value = "name_descending" },
                }, new { id = "sort2" }));

#line default
#line hidden
                EndContext();
                BeginContext(1608, 126, true);
                WriteLiteral("\r\n                <button class=\"btn btn-primary hvr-grow\" type=\"submit\" /><strong>Sort</strong>\r\n            </div>\r\n        ");
                EndContext();
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
            EndContext();
            BeginContext(1741, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 43 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml"
    }

#line default
#line hidden
            BeginContext(1750, 84, true);
            WriteLiteral("    <div id=\"wrapper\">\r\n        <div style=\"text-align:center; margin:10px auto;\">\r\n");
            EndContext();
#line 46 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml"
             foreach (var category in Model)
            {

#line default
#line hidden
            BeginContext(1895, 85, true);
            WriteLiteral("            <div id=\"categoriesList\">\r\n                <span style=\"font-size:25px;\">");
            EndContext();
            BeginContext(1981, 13, false);
#line 49 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml"
                                         Write(category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1994, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 50 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml"
                 if (this.User.IsInRole("Administrator") || this.User.IsInRole("Moderator"))
                {

#line default
#line hidden
            BeginContext(2116, 72, true);
            WriteLiteral("                    <div id=\"categoryButtons\">\r\n                        ");
            EndContext();
            BeginContext(2188, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a16cbe0590d2435c8485418fc496ed5b", async() => {
                BeginContext(2296, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml"
                                                                                                          WriteLiteral(category.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2304, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2330, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e8dda4d3e214978ace75dbba4620989", async() => {
                BeginContext(2438, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml"
                                                                                                          WriteLiteral(category.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2448, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 56 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml"
                }

#line default
#line hidden
            BeginContext(2497, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 58 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml"
            }

#line default
#line hidden
            BeginContext(2532, 98, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<div style=\"text-align:center;\">\r\n    <nav>\r\n        <vc:pager");
            EndContext();
            BeginWriteAttribute("paging-list", " paging-list=\"", 2630, "\"", 2650, 1);
#line 64 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Views\Category\All.cshtml"
WriteAttributeValue("", 2644, Model, 2644, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2651, 25, true);
            WriteLiteral(" />\r\n    </nav>\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<News.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
