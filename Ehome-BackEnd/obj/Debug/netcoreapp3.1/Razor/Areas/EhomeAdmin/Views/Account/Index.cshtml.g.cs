#pragma checksum "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "371ffc72517f338748fd9dad9ce19681dd4aa729"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_EhomeAdmin_Views_Account_Index), @"mvc.1.0.view", @"/Areas/EhomeAdmin/Views/Account/Index.cshtml")]
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
#line 1 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Account\Index.cshtml"
using Ehome_BackEnd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"371ffc72517f338748fd9dad9ce19681dd4aa729", @"/Areas/EhomeAdmin/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312661c40e31fe40035ce4a984bb93d79a82c528", @"/Areas/EhomeAdmin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_EhomeAdmin_Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""table-responsive"">
    <table class=""table table-light"">
  <thead>
    <tr>
      <th scope=""col"">Username <i style=""font-size:14px"" class=""fa-solid fa-arrow-down""></i></th>
      <th scope=""col"">Surname <i style=""font-size:14px"" class=""fa-solid fa-arrow-down""></i></th>
      <th scope=""col"">Email <i style=""font-size:14px"" class=""fa-solid fa-arrow-down""></i></th>
      <th scope=""col"">Phone <i style=""font-size:14px"" class=""fa-solid fa-arrow-down""></i></th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 18 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Account\Index.cshtml"
    foreach (AppUser user in Model.Where(m=>m.IsAdmin==false))
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n          <td>");
#nullable restore
#line 21 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Account\Index.cshtml"
         Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 22 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Account\Index.cshtml"
         Write(user.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 23 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Account\Index.cshtml"
         Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 24 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Account\Index.cshtml"
         Write(user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      </tr>\r\n");
#nullable restore
#line 26 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Account\Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591