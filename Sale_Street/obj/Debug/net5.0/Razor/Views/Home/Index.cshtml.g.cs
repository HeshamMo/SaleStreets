#pragma checksum "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49dd7edb49277fdca617bb4275638e1176e027e5"
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
#line 1 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\_ViewImports.cshtml"
using Sale_Street;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\_ViewImports.cshtml"
using Sale_Street.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49dd7edb49277fdca617bb4275638e1176e027e5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b26cb43aeb727edcac49866833ad375125c8c38", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sale_Street.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n\r\n    <div class=\"row\">\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\Home\Index.cshtml"
         foreach(var item in Model)
        {




#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-sm-12 col-md-4 col-4 \">\r\n                <div class=\"card\">\r\n                    <div class=\"card-header d-flex justify-content-center \">\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\Home\Index.cshtml"
                         if(item.Images != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49dd7edb49277fdca617bb4275638e1176e027e55080", async() => {
                WriteLiteral("\r\n\r\n\r\n                                <img style=\"height: 200px\"");
                BeginWriteAttribute("src", " src=\"", 647, "\"", 694, 1);
#nullable restore
#line 24 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\Home\Index.cshtml"
WriteAttributeValue("", 653, item.Images.FirstOrDefault().ActualImage, 653, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Card image cap\">\r\n\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\Home\Index.cshtml"
                                                                                        WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"card-body\">\r\n\r\n\r\n                        <h4 class=\"card-title\" style=\"overflow: hidden; height: 120px;\">");
#nullable restore
#line 32 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\Home\Index.cshtml"
                                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p class=\"card-text\" style=\"color: #796f6f; overflow: hidden; height: 120px;\">");
#nullable restore
#line 33 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\Home\Index.cshtml"
                                                                                                 Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\Home\Index.cshtml"
                         if(item.price == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"card-text\" style=\"color: #796f6f;\">Confidential Price</p>\r\n");
#nullable restore
#line 38 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\Home\Index.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"card-text\" style=\"color: #796f6f;\">");
#nullable restore
#line 42 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\Home\Index.cshtml"
                                                                    Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" EGP</p>\r\n");
#nullable restore
#line 43 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\Home\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"color: #796f6f;\">");
#nullable restore
#line 45 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\Home\Index.cshtml"
                                              Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p style=\"color: #796f6f;\">\r\n");
#nullable restore
#line 47 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\Home\Index.cshtml"
                              
                                DateTime date = @item.publishedAt;
                                var days = DateTime.Now.Subtract(date).Days;
                                //{date.Day}/{date.Month}/{date.Year}
                                string DaysAgo = "0";
                                if(days == 0)
                                {
                                    DaysAgo = "Today";
                                }
                                else
                                {
                                    DaysAgo = $"{days} days ago";
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            Published :");
#nullable restore
#line 61 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\Home\Index.cshtml"
                                  Write(DaysAgo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 66 "C:\Users\Hesham\source\repos\Sale_Street\Sale_Street\Views\Home\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Sale_Street.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
