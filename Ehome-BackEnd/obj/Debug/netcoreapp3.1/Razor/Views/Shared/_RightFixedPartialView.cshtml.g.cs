#pragma checksum "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_RightFixedPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e6f6af524b8279d959edfa6749eb40b0ede651f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__RightFixedPartialView), @"mvc.1.0.view", @"/Views/Shared/_RightFixedPartialView.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\_ViewImports.cshtml"
using Ehome_BackEnd.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_RightFixedPartialView.cshtml"
using Ehome_BackEnd.ViewModels.Furniture;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e6f6af524b8279d959edfa6749eb40b0ede651f", @"/Views/Shared/_RightFixedPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"257942d56b1cce55015460aed17e5f8c098dc93f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__RightFixedPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketVM>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_RightFixedPartialView.cshtml"
    for (var i = 0; i < Model.Count; i++)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <sub>");
#nullable restore
#line 8 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_RightFixedPartialView.cshtml"
      Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</sub>\r\n");
#nullable restore
#line 9 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_RightFixedPartialView.cshtml"
  }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LayoutService layoutservice { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketVM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591