#pragma checksum "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b5c22bfc9360ece4c21ecc0378eff17a68ac79e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\MeusProjetos\emphasys\Views\_ViewImports.cshtml"
using emphasys;

#line default
#line hidden
#line 2 "C:\MeusProjetos\emphasys\Views\_ViewImports.cshtml"
using emphasys.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b5c22bfc9360ece4c21ecc0378eff17a68ac79e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c67d2f29147c622b5314c81abda6d743ba17973", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/topo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Minuto Seguro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("carousel-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(69, 291, true);
            WriteLiteral(@"
<!-- carousel -->
<div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">

  <ol class=""carousel-indicators"">
    <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
  </ol>

  <div class=""carousel-inner"">
    <div class=""item active carousel-1"">
      ");
            EndContext();
            BeginContext(360, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7b5c22bfc9360ece4c21ecc0378eff17a68ac79e4706", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(427, 52, true);
            WriteLiteral("\r\n      <div class=\"carousel-caption\">\r\n        <h2>");
            EndContext();
            BeginContext(480, 11, false);
#line 18 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
       Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(491, 18, true);
            WriteLiteral("</h2>\r\n        <p>");
            EndContext();
            BeginContext(510, 17, false);
#line 19 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
      Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(527, 544, true);
            WriteLiteral(@"</p>
      </div>
    </div>
  </div>

  <!-- Controles -->
  <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"">
    <span class=""glyphicon glyphicon-chevron-left""></span>
    <span class=""sr-only"">voltar</span>
  </a>
  <a class=""right carousel-control"" href=""#myCarousel"" data-slide=""next"">
    <span class=""glyphicon glyphicon-chevron-right""></span>
    <span class=""sr-only"">próximo</span>
  </a>
</div>

<!-- blog -->
<section class=""details-card"">
  <div class=""container"">
      <div class=""row"">
");
            EndContext();
#line 39 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
         foreach (var item in Model.BlogItens)
        {

#line default
#line hidden
            BeginContext(1130, 144, true);
            WriteLiteral("          <div class=\"col-md-4\">\r\n              <div class=\"card-content\">\r\n                  <div class=\"card-img\">\r\n                      <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1274, "\"", 1291, 1);
#line 44 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
WriteAttributeValue("", 1280, item.Image, 1280, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1292, "\"", 1309, 1);
#line 44 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
WriteAttributeValue("", 1298, item.Title, 1298, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1310, 35, true);
            WriteLiteral(">\r\n                      <span><h4>");
            EndContext();
            BeginContext(1346, 35, false);
#line 45 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
                           Write(item.PubDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1381, 109, true);
            WriteLiteral("</h4></span>\r\n                  </div>\r\n                  <div class=\"card-desc\">\r\n                      <h3>");
            EndContext();
            BeginContext(1491, 10, false);
#line 48 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
                     Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1501, 54, true);
            WriteLiteral("</h3>\r\n                      <div class=\"description\">");
            EndContext();
            BeginContext(1556, 26, false);
#line 49 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
                                          Write(Html.Raw(item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1582, 99, true);
            WriteLiteral("</div>\r\n                      <p class=\"bold\">Palavras mais usadas</p>\r\n                      <p>\r\n");
            EndContext();
#line 52 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
                         foreach (var bestWord in item.BestWords.OrderByDescending(x=>x.Quantity).Take(10))
                        {

#line default
#line hidden
            BeginContext(1817, 34, true);
            WriteLiteral("                            <span>");
            EndContext();
            BeginContext(1852, 13, false);
#line 54 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
                             Write(bestWord.Word);

#line default
#line hidden
            EndContext();
            BeginContext(1865, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(1868, 17, false);
#line 54 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
                                             Write(bestWord.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1885, 12, true);
            WriteLiteral("), </span>\r\n");
            EndContext();
#line 55 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1924, 52, true);
            WriteLiteral("                      </p>\r\n                      <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1976, "\"", 1993, 1);
#line 57 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
WriteAttributeValue("", 1983, item.Link, 1983, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1994, 98, true);
            WriteLiteral(" class=\"btn-card\">ler mais</a>\r\n                  </div>\r\n              </div>\r\n          </div>\r\n");
            EndContext();
#line 61 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2103, 166, true);
            WriteLiteral("      </div>\r\n\r\n      <!-- Palavras mais usadas em todos -->\r\n      <div class=\"alert alert-success\" role=\"alert\">\r\n        Palavras mais usadas em todas matérias: \r\n");
            EndContext();
#line 67 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
          
          string separator = "";
          foreach (var bestWord in Model.BestWords.OrderByDescending(x=>x.Quantity).Take(10))
          {

#line default
#line hidden
            BeginContext(2423, 18, true);
            WriteLiteral("            <span>");
            EndContext();
            BeginContext(2442, 9, false);
#line 71 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
             Write(separator);

#line default
#line hidden
            EndContext();
            BeginContext(2451, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2453, 13, false);
#line 71 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
                        Write(bestWord.Word);

#line default
#line hidden
            EndContext();
            BeginContext(2466, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(2469, 17, false);
#line 71 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
                                        Write(bestWord.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(2486, 10, true);
            WriteLiteral(")</span>\r\n");
            EndContext();
#line 72 "C:\MeusProjetos\emphasys\Views\Home\Index.cshtml"
            separator = ",";
          }
        

#line default
#line hidden
            BeginContext(2550, 38, true);
            WriteLiteral("      </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
