#pragma checksum "C:\Users\phoeb\Desktop\New folder (2)\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6605b4753ab7252326c9d88167b32f0b5c9b745c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
#line 1 "C:\Users\phoeb\Desktop\New folder (2)\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\_ViewImports.cshtml"
using CarouselForBooksApplication;

#line default
#line hidden
#line 2 "C:\Users\phoeb\Desktop\New folder (2)\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\_ViewImports.cshtml"
using CarouselForBooksApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6605b4753ab7252326c9d88167b32f0b5c9b745c", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c772bb79fb854bfc635dd734c147515a76973e4", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarouselForBooksApplication.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 66, true);
            WriteLiteral("\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n");
            EndContext();
            BeginContext(188, 345, true);
            WriteLiteral(@"            <th>
                Name
            </th>
            <th>
                Username
            </th>
            <th>
                Email
            </th>
            <th>
                Password
            </th>
            <th>
                Dob
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 27 "C:\Users\phoeb\Desktop\New folder (2)\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\User\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(582, 14, true);
            WriteLiteral("        <tr>\r\n");
            EndContext();
            BeginContext(663, 34, true);
            WriteLiteral("            <td>\r\n                ");
            EndContext();
            BeginContext(698, 9, false);
#line 34 "C:\Users\phoeb\Desktop\New folder (2)\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\User\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(707, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(763, 13, false);
#line 37 "C:\Users\phoeb\Desktop\New folder (2)\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\User\Index.cshtml"
           Write(item.Username);

#line default
#line hidden
            EndContext();
            BeginContext(776, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(832, 10, false);
#line 40 "C:\Users\phoeb\Desktop\New folder (2)\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\User\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(842, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(898, 13, false);
#line 43 "C:\Users\phoeb\Desktop\New folder (2)\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\User\Index.cshtml"
           Write(item.Password);

#line default
#line hidden
            EndContext();
            BeginContext(911, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(967, 8, false);
#line 46 "C:\Users\phoeb\Desktop\New folder (2)\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\User\Index.cshtml"
           Write(item.Dob);

#line default
#line hidden
            EndContext();
            BeginContext(975, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 49 "C:\Users\phoeb\Desktop\New folder (2)\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\User\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1022, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarouselForBooksApplication.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
