#pragma checksum "C:\Users\Afiq\Documents\GitHub\New folder 111\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\User\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "452023a650f30e8f41cdc5db497bae499fe66c11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ChangePassword), @"mvc.1.0.view", @"/Views/User/ChangePassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/ChangePassword.cshtml", typeof(AspNetCore.Views_User_ChangePassword))]
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
#line 1 "C:\Users\Afiq\Documents\GitHub\New folder 111\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\_ViewImports.cshtml"
using CarouselForBooksApplication;

#line default
#line hidden
#line 2 "C:\Users\Afiq\Documents\GitHub\New folder 111\Dot-Net-Team-1-Project\Actual Project\CarouselForBooksSolution\CarouselForBooksApplication\Views\_ViewImports.cshtml"
using CarouselForBooksApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"452023a650f30e8f41cdc5db497bae499fe66c11", @"/Views/User/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c772bb79fb854bfc635dd734c147515a76973e4", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 441, true);
            WriteLiteral(@"<section>
    <div class=""container py-5 h-100"">
        <div class=""row justify-content-center align-items-center h-100"">
            <div class=""col-12 col-lg-9 col-xl-7"">
                <div class=""card shadow-2-strong card-registration"" style=""border-radius: 15px;"">
                    <div class=""card-body p-4 p-md-5"">
                        <h3 class=""mb-4 pb-2 pb-md-0 mb-md-5"">Change Password</h3>
                        ");
            EndContext();
            BeginContext(441, 2019, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b96f11539974941b06d09c1caedac4e", async() => {
                BeginContext(447, 2006, true);
                WriteLiteral(@"

                            <div class=""row"">
                                <div class=""col-md-6 mb-4 pb-2"">

                                    <div class=""form-outline"">
                                        <input type=""currentpassword"" id=""currentpassword"" class=""form-control form-control-lg"" placeholder=""Current Password"" pattern=""[A-Za-z][A-Za-z]*[0-9]*"" />
                                        <label class=""form-label"" for=""currentpassword""></label>
                                    </div>

                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-6 mb-4 pb-2"">

                                    <div class=""form-outline"">
                                        <input type=""newpassword"" id=""newpassword"" class=""form-control form-control-lg"" placeholder=""New Password"" pattern=""[A-Za-z][A-Za-z]*[0-9]*"" />
                                        <label class=""form-l");
                WriteLiteral(@"abel"" for=""newpassword""></label>
                                    </div>

                                </div>
                            </div>

                            <div class=""row"">
                                <div class=""col-md-6 mb-4 pb-2"">

                                    <div class=""form-outline"">
                                        <input type=""confirmpassword"" id=""confirmpassword"" class=""form-control form-control-lg"" placeholder=""Confirm Password"" pattern=""[A-Za-z][A-Za-z]*[0-9]*"" />
                                        <label class=""form-label"" for=""confirmpassword""></label>
                                    </div>

                                </div>
                            </div>


                            <div class=""mt-4 pt-2"">
                                <input class=""btn btn-primary btn-lg"" type=""submit"" value=""Save Changes"" />
                            </div>

                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2460, 112, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
