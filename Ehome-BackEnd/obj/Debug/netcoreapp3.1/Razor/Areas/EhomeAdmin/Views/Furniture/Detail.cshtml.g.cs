#pragma checksum "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Furniture\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "675f30afbca62e29e29e1123eb5437dee5fcfec1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_EhomeAdmin_Views_Furniture_Detail), @"mvc.1.0.view", @"/Areas/EhomeAdmin/Views/Furniture/Detail.cshtml")]
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
#line 1 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Furniture\Detail.cshtml"
using Ehome_BackEnd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"675f30afbca62e29e29e1123eb5437dee5fcfec1", @"/Areas/EhomeAdmin/Views/Furniture/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312661c40e31fe40035ce4a984bb93d79a82c528", @"/Areas/EhomeAdmin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_EhomeAdmin_Views_Furniture_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Futniture>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 180px; height:110px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Furniture\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"p-2\">\r\n    <div>\r\n        <h4>\r\n            Id\r\n        </h4>\r\n        <p>\r\n            ");
#nullable restore
#line 14 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Furniture\Detail.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n    <div>\r\n        <h4>\r\n            Name\r\n        </h4>\r\n        <p>\r\n            ");
#nullable restore
#line 22 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Furniture\Detail.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n    <div>\r\n        <h4>\r\n            SalePrice\r\n        </h4>\r\n        <p>\r\n            ");
#nullable restore
#line 30 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Furniture\Detail.cshtml"
       Write(Model.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n    <div>\r\n        <h4>\r\n            CostPrice\r\n        </h4>\r\n        <p>\r\n            ");
#nullable restore
#line 38 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Furniture\Detail.cshtml"
       Write(Model.CostPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n     <div>\r\n        <h4>\r\n            Discount\r\n        </h4>\r\n        <p>\r\n            ");
#nullable restore
#line 46 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Furniture\Detail.cshtml"
       Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n     <div>\r\n        <h4>\r\n            MainImage\r\n        </h4>\r\n        <div class=\"mt-3\">\r\n            <p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "675f30afbca62e29e29e1123eb5437dee5fcfec15859", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 917, "~/assets/IMG/furnitures/", 917, 24, true);
#nullable restore
#line 55 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Furniture\Detail.cshtml"
AddHtmlAttributeValue("", 941, Model.FurnitureImages.FirstOrDefault(p=>p.IsMain == true).Image, 941, 64, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n     <div>\r\n        <h4>\r\n            AnotherImages\r\n        </h4>\r\n        <p>\r\n            <div class=\"d-flex\">\r\n");
#nullable restore
#line 65 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Furniture\Detail.cshtml"
             foreach (var item in Model.FurnitureImages.Where(a=>a.IsMain==false))
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "675f30afbca62e29e29e1123eb5437dee5fcfec18045", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1332, "~/assets/IMG/furnitures/", 1332, 24, true);
#nullable restore
#line 67 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Furniture\Detail.cshtml"
AddHtmlAttributeValue("", 1356, item.Image, 1356, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 68 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Areas\EhomeAdmin\Views\Furniture\Detail.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("           </div>\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Futniture> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
