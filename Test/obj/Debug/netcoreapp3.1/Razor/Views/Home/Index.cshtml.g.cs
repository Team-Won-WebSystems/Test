#pragma checksum "/Users/andreasink/Projects/Test/Test/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d88ef6fcd6141861c685cb5939704a7bfbaec3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/andreasink/Projects/Test/Test/Views/_ViewImports.cshtml"
using Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/andreasink/Projects/Test/Test/Views/_ViewImports.cshtml"
using Test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d88ef6fcd6141861c685cb5939704a7bfbaec3c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce628290e7931cc4701d19d423f4cc50633f124a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Test.Models.DroneDataModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("background", new global::Microsoft.AspNetCore.Html.HtmlString("./back.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/andreasink/Projects/Test/Test/Views/Home/Index.cshtml"
  
    var gridPath = "";
    var imagePath = "";
    var backPath = "";
    var bestPath = "";
    var inpsirePath = "";
    ViewData["Title"] = "Home Page";
    imagePath = @"./build.svg";
    gridPath = @"./grid.png";
    backPath = @"./back.png";
    bestPath = @"./BestPower.png";
    inpsirePath = @"./Inspire.png";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d88ef6fcd6141861c685cb5939704a7bfbaec3c3777", async() => {
                WriteLiteral("\n    <div class=\"container\" style=\"margin: auto; align-content: center\">\n");
                WriteLiteral(@"        <div id=""onTop"" class=""text-center"" style=""margin-top: 20%; z-index: 2;"">
            <h1 class=""display-3""><strong>Build An Amazing Site</strong></h1>
            <p class=""display-5"" style=""padding-bottom: 5%"">Built for flexibility and power, Construction.Site improves your web presence</p>
            <button type=""button"" class=""btn btn-primary"" style=""border-color: #74B9FF; background-color: #74B9FF"">START BUILDING</button>
");
                WriteLiteral(@"
            <div id=""largeFeatureCard"" class=""row-fluid"" style=""margin-top: 10%"">
                <div class=""span3"" style=""padding-left: 10%"">
                    <div class=""leftText"">
                        <h2 style=""text-align: left; margin-bottom: 5%"">Powerful Website Builder</h2>
                        <p style=""text-align: left"">Build amazing websites DIY or with professional support and have access to intutive frameworks and tools</p>
                        <h4 style=""text-align: left"">Learn More</h4>
                    </div>
                </div>
                <div class=""span2"" style=""padding-right: 10%"">
                    <img class=""rightImg""");
                BeginWriteAttribute("src", " src=", 1743, "", 1758, 1);
#nullable restore
#line 35 "/Users/andreasink/Projects/Test/Test/Views/Home/Index.cshtml"
WriteAttributeValue("", 1748, imagePath, 1748, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n\n                </div>\n                <img class=\"back\"");
                BeginWriteAttribute("src", " src=", 1819, "", 1833, 1);
#nullable restore
#line 38 "/Users/andreasink/Projects/Test/Test/Views/Home/Index.cshtml"
WriteAttributeValue("", 1824, gridPath, 1824, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"max-width:80%\" />\n            </div>\n\n");
                WriteLiteral("            <img class=\"display-3\"");
                BeginWriteAttribute("src", " src=", 2715, "", 2729, 1);
#nullable restore
#line 55 "/Users/andreasink/Projects/Test/Test/Views/Home/Index.cshtml"
WriteAttributeValue("", 2720, bestPath, 2720, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""max-width:80%; margin-top: 5%"" />

            <div id=""onTop"" class=""text-center"" style=""margin-top: 20%; z-index: 2;"">


                <h1 class=""display-3""><strong>Be Inspired</strong></h1>
                <p class=""display-5"" style=""padding-bottom: 5%"">See what we can construct at Construction.Site</p>
                <a href=""https://andreasink.web.app"">
                   
                    <img id=""largeFeatureCard"" class=""display-3""");
                BeginWriteAttribute("src", " src=", 3185, "", 3202, 1);
#nullable restore
#line 64 "/Users/andreasink/Projects/Test/Test/Views/Home/Index.cshtml"
WriteAttributeValue("", 3190, inpsirePath, 3190, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"max-width: 110%;\" />\n                </a>\n\n            </div>\n        </div>\n\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test.Models.DroneDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
