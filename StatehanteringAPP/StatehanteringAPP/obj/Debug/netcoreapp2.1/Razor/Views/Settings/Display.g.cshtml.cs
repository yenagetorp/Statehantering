#pragma checksum "C:\Users\Yen Agetorp\source\repos\MVC&SQL\StateHantering\StatehanteringAPP\StatehanteringAPP\Views\Settings\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3a6a3f59d1137e2ce25e89ae8da65ab463df136"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Settings_Display), @"mvc.1.0.view", @"/Views/Settings/Display.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Settings/Display.cshtml", typeof(AspNetCore.Views_Settings_Display))]
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
#line 2 "C:\Users\Yen Agetorp\source\repos\MVC&SQL\StateHantering\StatehanteringAPP\StatehanteringAPP\Views\Settings\Display.cshtml"
using StatehanteringAPP.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3a6a3f59d1137e2ce25e89ae8da65ab463df136", @"/Views/Settings/Display.cshtml")]
    public class Views_Settings_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SettingsDisplayVM>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(126, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(155, 190, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f103f85abe5843d788fba3b5857dd150", async() => {
                BeginContext(161, 177, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <link rel=\"stylesheet\" href=\"https://bootswatch.com/4/flatly/bootstrap.min.css\" />\r\n    <title>Display</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(345, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(347, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d957c258fa5b4a6da9a48fb04bf24c99", async() => {
                BeginContext(353, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(399, 9, true);
                WriteLiteral("\r\n    <p>");
                EndContext();
                BeginContext(409, 17, false);
#line 17 "C:\Users\Yen Agetorp\source\repos\MVC&SQL\StateHantering\StatehanteringAPP\StatehanteringAPP\Views\Settings\Display.cshtml"
  Write(Model.SaveMessage);

#line default
#line hidden
                EndContext();
                BeginContext(426, 27, true);
                WriteLiteral("</p>\r\n    <p>Company name: ");
                EndContext();
                BeginContext(454, 17, false);
#line 18 "C:\Users\Yen Agetorp\source\repos\MVC&SQL\StateHantering\StatehanteringAPP\StatehanteringAPP\Views\Settings\Display.cshtml"
                Write(Model.CompanyName);

#line default
#line hidden
                EndContext();
                BeginContext(471, 28, true);
                WriteLiteral("</p>\r\n    <p>Support Email: ");
                EndContext();
                BeginContext(500, 11, false);
#line 19 "C:\Users\Yen Agetorp\source\repos\MVC&SQL\StateHantering\StatehanteringAPP\StatehanteringAPP\Views\Settings\Display.cshtml"
                 Write(Model.Email);

#line default
#line hidden
                EndContext();
                BeginContext(511, 17, true);
                WriteLiteral("</p>\r\n    <p>Dt: ");
                EndContext();
                BeginContext(529, 8, false);
#line 20 "C:\Users\Yen Agetorp\source\repos\MVC&SQL\StateHantering\StatehanteringAPP\StatehanteringAPP\Views\Settings\Display.cshtml"
      Write(Model.Dt);

#line default
#line hidden
                EndContext();
                BeginContext(537, 8, true);
                WriteLiteral("</p>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(552, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SettingsDisplayVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
