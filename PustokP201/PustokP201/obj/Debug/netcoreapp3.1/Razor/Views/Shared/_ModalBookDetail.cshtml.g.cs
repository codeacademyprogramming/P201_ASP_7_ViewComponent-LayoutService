#pragma checksum "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\Shared\_ModalBookDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16618a18a3a3ec7b28d0c9ee8c1f299b4279bf79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ModalBookDetail), @"mvc.1.0.view", @"/Views/Shared/_ModalBookDetail.cshtml")]
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
#line 1 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\_ViewImports.cshtml"
using PustokP201;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\_ViewImports.cshtml"
using PustokP201.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\_ViewImports.cshtml"
using PustokP201.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16618a18a3a3ec7b28d0c9ee8c1f299b4279bf79", @"/Views/Shared/_ModalBookDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5884438bbf247ea6d9f39676e18e38800fdc98e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ModalBookDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<button type=""button"" class=""close modal-close-btn ml-auto"" data-dismiss=""modal"" aria-label=""Close"">
    <span aria-hidden=""true"">&times;</span>
</button>
<div class=""product-details-modal"">
    <div class=""row"">
        <div class=""col-lg-5"">
            <!-- Product Details Slider Big Image-->
            <div class=""single-slide"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "16618a18a3a3ec7b28d0c9ee8c1f299b4279bf794270", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 385, "~/image/products/", 385, 17, true);
#nullable restore
#line 11 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\Shared\_ModalBookDetail.cshtml"
AddHtmlAttributeValue("", 402, Model.BookImages.FirstOrDefault(x=>x.PosterStatus==true)?.Image, 402, 64, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"col-lg-7 mt--30 mt-lg--30\">\r\n            <div class=\"product-details-info pl-lg--30 \">\r\n                <p class=\"tag-block\">\r\n                    Tags:\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\Shared\_ModalBookDetail.cshtml"
                     for (int i = 0; i < Model.BookTags.Count; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"#\">");
#nullable restore
#line 21 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\Shared\_ModalBookDetail.cshtml"
                               Write(Model.BookTags[i].Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\Shared\_ModalBookDetail.cshtml"
                                                            Write(i<Model.BookTags.Count-1?",":"");

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 22 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\Shared\_ModalBookDetail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <h3 class=\"product-title\">");
#nullable restore
#line 25 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\Shared\_ModalBookDetail.cshtml"
                                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <ul class=\"list-unstyled\">\r\n                    <li>Ex Tax: <span class=\"list-value\"> £60.24</span></li>\r\n                    <li>Brands: <a href=\"#\" class=\"list-value font-weight-bold\"> ");
#nullable restore
#line 28 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\Shared\_ModalBookDetail.cshtml"
                                                                            Write(Model.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                    <li>Product Code: <span class=\"list-value\"> ");
#nullable restore
#line 29 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\Shared\_ModalBookDetail.cshtml"
                                                           Write(Model.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    <li>Availability: <span class=\"list-value\"> ");
#nullable restore
#line 30 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\Shared\_ModalBookDetail.cshtml"
                                                            Write(Model.StockStatus?"In Stock":"Out Stock");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                </ul>\r\n                <div class=\"price-block\">\r\n");
#nullable restore
#line 33 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\Shared\_ModalBookDetail.cshtml"
                     if (Model.DiscountPercent > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"price-new\">£");
#nullable restore
#line 35 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\Shared\_ModalBookDetail.cshtml"
                                         Write((Model.SalePrice*(100- Model.DiscountPercent)/100).ToString("#.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <del class=\"price-old\">£");
#nullable restore
#line 36 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\Shared\_ModalBookDetail.cshtml"
                                           Write(Model.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n");
#nullable restore
#line 37 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\Shared\_ModalBookDetail.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"price-new\">£");
#nullable restore
#line 40 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\Shared\_ModalBookDetail.cshtml"
                                            Write(Model.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 41 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\Shared\_ModalBookDetail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""rating-widget"">
                    <div class=""rating-block"">
                        <span class=""fas fa-star star_on""></span>
                        <span class=""fas fa-star star_on""></span>
                        <span class=""fas fa-star star_on""></span>
                        <span class=""fas fa-star star_on""></span>
                        <span class=""fas fa-star ""></span>
                    </div>
                    <div class=""review-widget"">
                        <a href=""#"">(1 Reviews)</a> <span>|</span>
                        <a href=""#"">Write a review</a>
                    </div>
                </div>
                <article class=""product-details-article"">
                    <h4 class=""sr-only"">Product Summery</h4>
                    <p>
                       ");
#nullable restore
#line 60 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\ASP_6_Cookie-Basket\PustokP201\PustokP201\Views\Shared\_ModalBookDetail.cshtml"
                  Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>
                </article>
                <div class=""add-to-cart-row"">
                    <div class=""count-input-block"">
                        <span class=""widget-label"">Qty</span>
                        <input type=""number"" class=""form-control text-center"" value=""1"">
                    </div>
                    <div class=""add-cart-btn"">
                        <a href=""#"" class=""btn btn-outlined--primary"">
                            <span class=""plus-icon"">+</span>Add to Cart
                        </a>
                    </div>
                </div>
                <div class=""compare-wishlist-row"">
                    <a href=""#"" class=""add-link""><i class=""fas fa-heart""></i>Add to Wish List</a>
                    <a href=""#"" class=""add-link""><i class=""fas fa-random""></i>Add to Compare</a>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""modal-footer"">
    <div class=""widget-social-share"">
        <span cl");
            WriteLiteral(@"ass=""widget-label"">Share:</span>
        <div class=""modal-social-share"">
            <a href=""#"" class=""single-icon""><i class=""fab fa-facebook-f""></i></a>
            <a href=""#"" class=""single-icon""><i class=""fab fa-twitter""></i></a>
            <a href=""#"" class=""single-icon""><i class=""fab fa-youtube""></i></a>
            <a href=""#"" class=""single-icon""><i class=""fab fa-google-plus-g""></i></a>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
