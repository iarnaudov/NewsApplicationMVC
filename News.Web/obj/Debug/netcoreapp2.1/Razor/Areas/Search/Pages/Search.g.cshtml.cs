#pragma checksum "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Areas\Search\Pages\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91a1c88d7a96e83da58345222262deb9d91d954e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Search_Pages_Search), @"mvc.1.0.razor-page", @"/Areas/Search/Pages/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Search/Pages/Search.cshtml", typeof(AspNetCore.Areas_Search_Pages_Search), null)]
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
#line 3 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Areas\Search\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Areas\Search\Pages\_ViewImports.cshtml"
using News.Web.Areas.Identity.Pages;

#line default
#line hidden
#line 4 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Areas\Search\Pages\_ViewImports.cshtml"
using News.Web.Areas.Account.Pages;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91a1c88d7a96e83da58345222262deb9d91d954e", @"/Areas/Search/Pages/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfb73e308571d6a187519849005ffb445dca670d", @"/Areas/Search/Pages/_ViewImports.cshtml")]
    public class Areas_Search_Pages_Search : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Areas\Search\Pages\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
            BeginContext(98, 26, true);
            WriteLiteral("\r\n<h2>Search results for: ");
            EndContext();
            BeginContext(125, 16, false);
#line 7 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Areas\Search\Pages\Search.cshtml"
                   Write(Model.SearchTerm);

#line default
#line hidden
            EndContext();
            BeginContext(141, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
#line 9 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Areas\Search\Pages\Search.cshtml"
     foreach (var article in Model.Results)
    {

#line default
#line hidden
            BeginContext(202, 66, true);
            WriteLiteral("        <h3 id=\"articleHeading\" class=\"hvr-float\"><span>* </span> ");
            EndContext();
            BeginContext(269, 84, false);
#line 11 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Areas\Search\Pages\Search.cshtml"
                                                             Write(Html.ActionLink(article.Value, "Details", "Article", new { id = article.Key }, null));

#line default
#line hidden
            EndContext();
            BeginContext(353, 24, true);
            WriteLiteral(" </h3>\r\n        <br />\r\n");
            EndContext();
#line 13 "D:\Програмиране\SoftUni Homeworks\SoftUni - GitHub\NewsApplicationMVC\News.Web\Areas\Search\Pages\Search.cshtml"
    }

#line default
#line hidden
            BeginContext(384, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<News.Web.Areas.Account.Pages.SearchModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<News.Web.Areas.Account.Pages.SearchModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<News.Web.Areas.Account.Pages.SearchModel>)PageContext?.ViewData;
        public News.Web.Areas.Account.Pages.SearchModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
