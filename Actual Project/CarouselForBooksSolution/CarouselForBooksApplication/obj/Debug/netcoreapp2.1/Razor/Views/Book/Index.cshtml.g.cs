#pragma checksum "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c811c9171369f5724215035aa969c288e91891e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Index), @"mvc.1.0.view", @"/Views/Book/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Index.cshtml", typeof(AspNetCore.Views_Book_Index))]
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
#line 1 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\_ViewImports.cshtml"
using CarouselForBooksApplication;

#line default
#line hidden
#line 2 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\_ViewImports.cshtml"
using CarouselForBooksApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c811c9171369f5724215035aa969c288e91891e0", @"/Views/Book/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c772bb79fb854bfc635dd734c147515a76973e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarouselForBooksApplication.Models.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 188, true);
            WriteLiteral("<style>\r\n    #divCard {\r\n        position: relative;\r\n        float: left;\r\n        margin: 10px;\r\n    }\r\n</style>\r\n<h1>Book Listings</h1>\r\n<div class=\"row row-cols-1 row-cols-md-3 g-4\">\r\n");
            EndContext();
#line 11 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(290, 174, true);
            WriteLiteral("        <div class=\"col\">\r\n            <div id=\"divCard\" class=\"card\" style=\"border:double 3px; padding: 3px; border-radius: 2px;\">\r\n                <img class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 464, "\"", 496, 1);
#line 15 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Index.cshtml"
WriteAttributeValue("", 470, Url.Content(item.Picture), 470, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(497, 133, true);
            WriteLiteral(" alt=\"Card image cap\" height=\"350\" width=\"250\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
            EndContext();
            BeginContext(631, 10, false);
#line 17 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Index.cshtml"
                                      Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(641, 48, true);
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
            EndContext();
            BeginContext(690, 16, false);
#line 18 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Index.cshtml"
                                    Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(706, 26, true);
            WriteLiteral("</p>\r\n                    ");
            EndContext();
            BeginContext(732, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f4fd438e99c4900a754d4b9080b1fda", async() => {
                BeginContext(801, 11, true);
                WriteLiteral("Add To Cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Index.cshtml"
                                                                   WriteLiteral(item.Id);

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
            BeginContext(816, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(840, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfc0fc11e37549b4a75cf1af972ca1a7", async() => {
                BeginContext(912, 12, true);
                WriteLiteral("View Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Index.cshtml"
                                                                      WriteLiteral(item.Id);

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
            BeginContext(928, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1036, 60, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 25 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1103, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarouselForBooksApplication.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
