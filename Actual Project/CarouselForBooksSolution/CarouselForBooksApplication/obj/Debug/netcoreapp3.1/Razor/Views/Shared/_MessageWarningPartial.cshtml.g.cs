#pragma checksum "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Shared\_MessageWarningPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed378950409ba8a4862504c53c339c6ef91ca105"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MessageWarningPartial), @"mvc.1.0.view", @"/Views/Shared/_MessageWarningPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_MessageWarningPartial.cshtml", typeof(AspNetCore.Views_Shared__MessageWarningPartial))]
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
#line 1 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Shared\_MessageWarningPartial.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed378950409ba8a4862504c53c339c6ef91ca105", @"/Views/Shared/_MessageWarningPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c772bb79fb854bfc635dd734c147515a76973e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MessageWarningPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(85, 1120, true);
            WriteLiteral(@"<svg xmlns=""http://www.w3.org/2000/svg"" style=""display: none;"">
    <symbol id=""check-circle-fill"" fill=""currentColor"" viewBox=""0 0 16 16"">
        <path d=""M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-3.97-3.03a.75.75 0 0 0-1.08.022L7.477 9.417 5.384 7.323a.75.75 0 0 0-1.06 1.06L6.97 11.03a.75.75 0 0 0 1.079-.02l3.992-4.99a.75.75 0 0 0-.01-1.05z"" />
    </symbol>
    <symbol id=""info-fill"" fill=""currentColor"" viewBox=""0 0 16 16"">
        <path d=""M8 16A8 8 0 1 0 8 0a8 8 0 0 0 0 16zm.93-9.412-1 4.705c-.07.34.029.533.304.533.194 0 .487-.07.686-.246l-.088.416c-.287.346-.92.598-1.465.598-.703 0-1.002-.422-.808-1.319l.738-3.468c.064-.293.006-.399-.287-.47l-.451-.081.082-.381 2.29-.287zM8 5.5a1 1 0 1 1 0-2 1 1 0 0 1 0 2z"" />
    </symbol>
    <symbol id=""exclamation-triangle-fill"" fill=""currentColor"" viewBox=""0 0 16 16"">
        <path d=""M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 ");
            WriteLiteral("0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z\" />\r\n    </symbol>\r\n</svg>\r\n");
            EndContext();
#line 14 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Shared\_MessageWarningPartial.cshtml"
 if (@HttpContextAccessor.HttpContext.Session.GetString("message") != null)
{
    if (@HttpContextAccessor.HttpContext.Session.GetString("message") != "")
    {

#line default
#line hidden
            BeginContext(1370, 16, true);
            WriteLiteral("        <br />\r\n");
            EndContext();
#line 19 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Shared\_MessageWarningPartial.cshtml"
        string message = @HttpContextAccessor.HttpContext.Session.GetString("message");
        

#line default
#line hidden
            BeginContext(1483, 215, true);
            WriteLiteral("<div class=\"alert alert-danger alert-dismissible\" role=\"alert\">\r\n            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n            ");
            EndContext();
            BeginContext(1699, 7, false);
#line 22 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Shared\_MessageWarningPartial.cshtml"
       Write(message);

#line default
#line hidden
            EndContext();
            BeginContext(1706, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 24 "C:\Users\Afiq\Documents\GitHub\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\Shared\_MessageWarningPartial.cshtml"
        HttpContextAccessor.HttpContext.Session.SetString("message", "");
    }
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
