#pragma checksum "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_PartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23e8b2fbc43c768a3a68c54b5b92f743fe850f37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialView), @"mvc.1.0.view", @"/Views/Shared/_PartialView.cshtml")]
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
#line 4 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_PartialView.cshtml"
using Ehome_BackEnd.ViewModels.Furniture;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23e8b2fbc43c768a3a68c54b5b92f743fe850f37", @"/Views/Shared/_PartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"257942d56b1cce55015460aed17e5f8c098dc93f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__PartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketVM>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("      \r\n            <div class=\"basket-items\">\r\n");
#nullable restore
#line 8 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_PartialView.cshtml"
                 foreach (var item in Model)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <div class=\"d-flex\">\r\n                       <div class=\"d-flex w-100\">\r\n                    <div class=\"basket-image\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 438, "\"", 445, 0);
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "23e8b2fbc43c768a3a68c54b5b92f743fe850f375536", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 479, "~/assets/IMG/furnitures/", 479, 24, true);
#nullable restore
#line 13 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_PartialView.cshtml"
AddHtmlAttributeValue("", 503, item.Image, 503, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                    </div>\r\n                    <div class=\"basket-info mt-2 ms-2\">\r\n                        <p>");
#nullable restore
#line 16 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_PartialView.cshtml"
                      Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x ");
#nullable restore
#line 16 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_PartialView.cshtml"
                                     Write((@item.Count*@item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN</p>\r\n                        <div class=\"basket-count\">\r\n                           <a class=\"remove-basket\" data-id=\"");
#nullable restore
#line 18 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_PartialView.cshtml"
                                                        Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fa-solid fa-minus\"></i></a> <input");
            BeginWriteAttribute("value", " value=\"", 867, "\"", 886, 1);
#nullable restore
#line 18 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_PartialView.cshtml"
WriteAttributeValue("", 875, item.Count, 875, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=\"0\" max=\"99\"  style=\"width: 43px; font-size: 22px;\" type=\"number\"> <a class=\"add-basket\"  data-id=\"");
#nullable restore
#line 18 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_PartialView.cshtml"
                                                                                                                                                                                                                                                 Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i  class=\"fa-solid fa-plus\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                    </div>\r\n                 <div class=\"close-icon\">\r\n                    <a class=\"removeall-basket\" data-id=\"");
#nullable restore
#line 23 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_PartialView.cshtml"
                                                    Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"productclean\"");
            BeginWriteAttribute("href", " href=\"", 1272, "\"", 1279, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-xmark\"></i></a>\r\n                </div>\r\n                   </div>\r\n");
#nullable restore
#line 26 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_PartialView.cshtml"

               }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"basket-bottom  d-flex justify-content-between\">\r\n            <div class=\"basket-price ms-2 mt-4\">\r\n");
#nullable restore
#line 31 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_PartialView.cshtml"
                  decimal total = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_PartialView.cshtml"
                         foreach (var item in Model)
                        {
                            total += (item.Price * item.Count);
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h6>\r\n                            <p>Cəmi: ");
#nullable restore
#line 37 "C:\Users\Admin\OneDrive\Desktop\Ehome_Final_Project_\Ehome-BackEnd\Views\Shared\_PartialView.cshtml"
                                Write(total.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN</p>\r\n                        </h6>\r\n                   \r\n            </div>\r\n            <div class=\"add-basket mx-3 mt-1\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23e8b2fbc43c768a3a68c54b5b92f743fe850f3711614", async() => {
                WriteLiteral("<button>Sifariş et</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n       \r\n");
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
