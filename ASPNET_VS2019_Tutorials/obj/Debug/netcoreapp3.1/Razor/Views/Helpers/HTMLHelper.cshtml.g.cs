#pragma checksum "C:\Users\pedro\source\repos\ASPNET_VS2019_Tutorials\ASPNET_VS2019_Tutorials\Views\Helpers\HTMLHelper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1a84397a06f4ea131f361fea8c1a3eda5cdb809"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Helpers_HTMLHelper), @"mvc.1.0.view", @"/Views/Helpers/HTMLHelper.cshtml")]
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
#line 1 "C:\Users\pedro\source\repos\ASPNET_VS2019_Tutorials\ASPNET_VS2019_Tutorials\Views\_ViewImports.cshtml"
using ASPNET_VS2019_Tutorials;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pedro\source\repos\ASPNET_VS2019_Tutorials\ASPNET_VS2019_Tutorials\Views\_ViewImports.cshtml"
using ASPNET_VS2019_Tutorials.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1a84397a06f4ea131f361fea8c1a3eda5cdb809", @"/Views/Helpers/HTMLHelper.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a3bd5b6c1dfa00de7dbc11261b3dd0f028dd692", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Helpers_HTMLHelper : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>HTML Helper</h1>\r\n\r\n");
#nullable restore
#line 3 "C:\Users\pedro\source\repos\ASPNET_VS2019_Tutorials\ASPNET_VS2019_Tutorials\Views\Helpers\HTMLHelper.cshtml"
Write(Html.ActionLink("Return to Home Page", "Index", "Helpers"));

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
