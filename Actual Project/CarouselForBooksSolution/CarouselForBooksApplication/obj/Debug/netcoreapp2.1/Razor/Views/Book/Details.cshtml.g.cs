#pragma checksum "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c479c2ef69e7e062278028d664df0042c072aa6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Details), @"mvc.1.0.view", @"/Views/Book/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Details.cshtml", typeof(AspNetCore.Views_Book_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c479c2ef69e7e062278028d664df0042c072aa6", @"/Views/Book/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c772bb79fb854bfc635dd734c147515a76973e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarouselForBooksApplication.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(93, 118, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Book</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(212, 41, false);
#line 14 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(253, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(297, 37, false);
#line 17 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(334, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(378, 47, false);
#line 20 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(425, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(469, 43, false);
#line 23 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(512, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(556, 44, false);
#line 26 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Language));

#line default
#line hidden
            EndContext();
            BeginContext(600, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(644, 40, false);
#line 29 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
       Write(Html.DisplayFor(model => model.Language));

#line default
#line hidden
            EndContext();
            BeginContext(684, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(728, 40, false);
#line 32 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(768, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(812, 36, false);
#line 35 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cost));

#line default
#line hidden
            EndContext();
            BeginContext(848, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(892, 43, false);
#line 38 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Picture));

#line default
#line hidden
            EndContext();
            BeginContext(935, 47, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 982, "\"", 1015, 1);
#line 41 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
WriteAttributeValue("", 988, Url.Content(Model.Picture), 988, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1016, 90, true);
            WriteLiteral(" alt=\"Card image cap\" height=\"400\" width=\"300\">\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1107, 42, false);
#line 44 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsSold));

#line default
#line hidden
            EndContext();
            BeginContext(1149, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1193, 38, false);
#line 47 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsSold));

#line default
#line hidden
            EndContext();
            BeginContext(1231, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1275, 46, false);
#line 50 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DatePosted));

#line default
#line hidden
            EndContext();
            BeginContext(1321, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1365, 42, false);
#line 53 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
       Write(Html.DisplayFor(model => model.DatePosted));

#line default
#line hidden
            EndContext();
            BeginContext(1407, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1451, 40, false);
#line 56 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
            EndContext();
            BeginContext(1491, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1535, 39, false);
#line 59 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1574, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1621, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24ad1b24a2e8489fabac9675ddcbedb6", async() => {
                BeginContext(1667, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Book\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            BeginContext(1675, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1683, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d9f5228389846d3b2939db7a11b9069", async() => {
                BeginContext(1705, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1721, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarouselForBooksApplication.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
