#pragma checksum "C:\Users\Amina\Source\Repos\nkadric1\ProjekatOOAD\Spotifive\Views\Song\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63f3c84ad1c9f95a5093e9ecf40ad9e3591a99a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Song_Details), @"mvc.1.0.view", @"/Views/Song/Details.cshtml")]
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
#line 1 "C:\Users\Amina\Source\Repos\nkadric1\ProjekatOOAD\Spotifive\Views\_ViewImports.cshtml"
using Spotifive;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amina\Source\Repos\nkadric1\ProjekatOOAD\Spotifive\Views\_ViewImports.cshtml"
using Spotifive.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63f3c84ad1c9f95a5093e9ecf40ad9e3591a99a4", @"/Views/Song/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15dd04377c4d99403807644ff523ddbac309b4ca", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Song_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Spotifive.Models.Song>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bodyLight.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Amina\Source\Repos\nkadric1\ProjekatOOAD\Spotifive\Views\Song\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63f3c84ad1c9f95a5093e9ecf40ad9e3591a99a44400", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "63f3c84ad1c9f95a5093e9ecf40ad9e3591a99a44662", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <style>
        #Im {
            position: fixed;
            top: 220px;
            right: 80px;
        }
    </style>


    <!--Tekst-->

    <style>
        .text-box {
            position: fixed;
            top: 60px;
            left: 150px;
            color: #0b2847;
            text-align: center;
            font-family: Montserrat;
            font-size: 40px;
        }
    </style>

    <style>
        .text-box1 {
            position: fixed;
            top: 120px;
            left: 150px;
            color: #0b2847;
            font-family: Montserrat;
            text-align: center;
            font-size: 30px;
        }
    </style>

 


    <style>
        .text-box2 {
            position: fixed;
            top: 230px;
            left: 300px;
            color: #0b2847;
            font-family: Montserrat;
            text-align: center;
            font-size: 30px;
        }

        h4 {
            position: fixed;
          ");
                WriteLiteral(@"  top: 238px;
            left: 100px;
        }
    </style>

    <style>
        .text-box3 {
            position: fixed;
            top: 270px;
            left: 300px;
            color: #0b2847;
            font-family: Montserrat;
            text-align: center;
            font-size: 30px;
        }

        h5 {
            position: fixed;
            top: 270px;
            left: 100px;
        }
    </style>



    <style>
        .text-box4 {
            position: fixed;
            top: 310px;
            left: 300px;
            color: #0b2847;
            font-family: Montserrat;
            text-align: center;
            font-size: 30px;
        }

        h6 {
            position: fixed;
            top: 318px;
            left: 100px;
        }
    </style>

    <style>
        .logo {
            position: fixed;
            bottom: 40px;
            right: 60px;
        }
    </style>

    <style>
        #Im2 {
            position:");
                WriteLiteral(@" fixed;
            bottom: 100px;
            left: 100px;
            content: url(S.png);
        }
    </style>

    <style>
        .text {
            text-align: left;
            font-size: 25px;
        }
        .posImg{
            position: fixed;
            top: 130px;
            right: 300px;
        }
        .posQR{
            position: fixed;
            bottom: 30px;
            left: 100px;
        }
    </style>

");
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
            WriteLiteral("\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63f3c84ad1c9f95a5093e9ecf40ad9e3591a99a49138", async() => {
                WriteLiteral("\r\n\r\n    \r\n\r\n    <div class=\"text-box\" asp-for=\"SongName\">");
#nullable restore
#line 145 "C:\Users\Amina\Source\Repos\nkadric1\ProjekatOOAD\Spotifive\Views\Song\Details.cshtml"
                                        Write(Model.SongName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n  \r\n <div class=\"text-box1\">");
#nullable restore
#line 148 "C:\Users\Amina\Source\Repos\nkadric1\ProjekatOOAD\Spotifive\Views\Song\Details.cshtml"
                    Write(((Artist)ViewBag.Artist)?.ArtistName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div> \r\n  <div class=\"text-box1\">");
#nullable restore
#line 149 "C:\Users\Amina\Source\Repos\nkadric1\ProjekatOOAD\Spotifive\Views\Song\Details.cshtml"
                     Write(((Artist)ViewBag.Artist)?.ArtistSurname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div> \r\n\r\n  <img");
                BeginWriteAttribute("src", " src=", 2914, "", 2953, 1);
#nullable restore
#line 151 "C:\Users\Amina\Source\Repos\nkadric1\ProjekatOOAD\Spotifive\Views\Song\Details.cshtml"
WriteAttributeValue("", 2919, ((Artist)ViewBag.Artist)?.Image, 2919, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\" height=\"120\" width=\"170\">\r\n   \r\n\r\n\r\n\r\n    <h4 class=\"text\">\r\n        Genre:\r\n    </h4>\r\n    <div class=\"text-box2\" asp-for=\"Genre\">");
#nullable restore
#line 159 "C:\Users\Amina\Source\Repos\nkadric1\ProjekatOOAD\Spotifive\Views\Song\Details.cshtml"
                                      Write(Model.Genre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n\r\n    <h6 class=\"text\">\r\n        Release date:\r\n    </h6>\r\n     <div class=\"text-box4\" asp-for=\"DateRelease\"> ");
#nullable restore
#line 165 "C:\Users\Amina\Source\Repos\nkadric1\ProjekatOOAD\Spotifive\Views\Song\Details.cshtml"
                                              Write(ViewBag.FormattedDateRelease);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n    <!--staviti artist image-->\r\n\r\n    <img src=\"");
#nullable restore
#line 169 "C:\Users\Amina\Source\Repos\nkadric1\ProjekatOOAD\Spotifive\Views\Song\Details.cshtml"
         Write(Model.Image);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" alt=\"");
#nullable restore
#line 169 "C:\Users\Amina\Source\Repos\nkadric1\ProjekatOOAD\Spotifive\Views\Song\Details.cshtml"
                            Write(Model.SongName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" width=\"500\" height=\"500\" class=\"posImg\" />\r\n\r\n    <img src=\"");
#nullable restore
#line 171 "C:\Users\Amina\Source\Repos\nkadric1\ProjekatOOAD\Spotifive\Views\Song\Details.cshtml"
         Write(Model.CodeQR);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" alt=\"");
#nullable restore
#line 171 "C:\Users\Amina\Source\Repos\nkadric1\ProjekatOOAD\Spotifive\Views\Song\Details.cshtml"
                             Write(Model.SongName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"  width=\"250\" height=\"250\" class=\"posQR\" />\r\n\r\n    <img class=\"logo\" src=\"~/assets/images/SpotiFIVELogo.png\" height=\"120\" width=\"170\">\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Spotifive.Models.Song> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
