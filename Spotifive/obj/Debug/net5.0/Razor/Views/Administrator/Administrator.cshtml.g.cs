#pragma checksum "C:\Users\x\Source\Repos\ProjekatOOADv8.0\Spotifive\Views\Administrator\Administrator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acf215c79a62c3d5f702ba98324d8fef3bc6ed78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrator_Administrator), @"mvc.1.0.view", @"/Views/Administrator/Administrator.cshtml")]
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
#line 1 "C:\Users\x\Source\Repos\ProjekatOOADv8.0\Spotifive\Views\_ViewImports.cshtml"
using Spotifive;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\x\Source\Repos\ProjekatOOADv8.0\Spotifive\Views\_ViewImports.cshtml"
using Spotifive.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acf215c79a62c3d5f702ba98324d8fef3bc6ed78", @"/Views/Administrator/Administrator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15dd04377c4d99403807644ff523ddbac309b4ca", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Administrator_Administrator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Spotifive.Models.Administrator>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/body.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\x\Source\Repos\ProjekatOOADv8.0\Spotifive\Views\Administrator\Administrator.cshtml"
  
    ViewData["Title"] = "Edit Account";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf215c79a62c3d5f702ba98324d8fef3bc6ed785087", async() => {
                WriteLiteral("\r\n    <link href=\'https://fonts.googleapis.com/css?family=Montserrat\' rel=\'stylesheet\'>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "acf215c79a62c3d5f702ba98324d8fef3bc6ed785442", async() => {
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
        .image1 {
            position: fixed;
            top: 100px;
            left: 200px;
            border-radius: 50%;
            height: 150px;
            width: 150px;
        }
    </style>
    <style>
        .background {
            position: fixed;
            top: 150px;
            left: 260px;
            width: 1000px;
            height: 500px;
            background-color: #a8b6f0;
        }
    </style>

    <style>
        .signOut {
            font-family: 'Montserrat', sans-serif; /*sans-serif is in case there is no montserrat on the user's system*/
            font-size: 22px;
            font-weight: bold;
            background-color: #a8b6f0;
            text-align: center;
            color: #0b2847;
        }

        .delete {
            font-family: 'Montserrat', sans-serif; /*sans-serif is in case there is no montserrat on the user's system*/
            font-size: 22px;
            font-weight: bold;
            backgro");
                WriteLiteral(@"und-color: whitesmoke;
            text-align: center;
            color: #0b2847;
            border-color: #0b2847;
            height: 100px;
            width: 100px;
        }

        .update {
            font-family: 'Montserrat', sans-serif; /*sans-serif is in case there is no montserrat on the user's system*/
            font-size: 22px;
            font-weight: bold;
            background-color: whitesmoke;
            text-align: center;
            color: #0b2847;
            border-color: #0b2847;
            height: 100px;
            width: 100px;
        }

        .background1 {
            position: fixed;
            top: 520px;
            left: 1100px;
            width: 100px;
            height: 20px;
            background-color: #a8b6f0;
        }
    </style>


    <style>
        h1 {
            position: fixed;
            top: 180px;
            left: 430px;
            font-size: 24px;
            font-weight: bold;
        }
    </style>");
                WriteLiteral(@"

    <style>
        h2 {
            position: fixed;
            top: 240px;
            left: 280px;
            font-size: 20px;
            font-weight: bold;
        }
    </style>

    <style>
        h3 {
            position: fixed;
            top: 280px;
            left: 280px;
            font-size: 20px;
            font-weight: bold;
        }
    </style>

    <style>
        h4 {
            position: fixed;
            top: 320px;
            left: 280px;
            font-size: 20px;
            font-weight: bold;
        }
    </style>

    <style>
        h5 {
            position: fixed;
            top: 360px;
            left: 280px;
            font-size: 20px;
            font-weight: bold;
        }
    </style>

    <style>
        h6 {
            position: fixed;
            top: 400px;
            left: 280px;
            font-size: 20px;
            font-weight: bold;
        }
    </style>

    <style>
        .text-box {
 ");
                WriteLiteral(@"           border: 1px solid white;
            padding: 1px;
            width: 300px;
            height: 30px;
            position: fixed;
            top: 240px;
            left: 460px;
            font-family: Montserrat;
            color: #0b2847;
        }
    </style>

    <style>
        .text-box1 {
            border: 1px solid white;
            padding: 1px;
            width: 300px;
            height: 30px;
            position: fixed;
            top: 280px;
            left: 460px;
            font-family: Montserrat;
            color: #0b2847;
        }
    </style>

    <style>
        .text-box2 {
            border: 1px solid white;
            padding: 1px;
            width: 300px;
            height: 30px;
            position: fixed;
            top: 320px;
            left: 460px;
            font-family: Montserrat;
            color: #0b2847;
        }
    </style>

    <style>
        .text-box3 {
            border: 1px solid white;
");
                WriteLiteral(@"            padding: 1px;
            width: 300px;
            height: 30px;
            position: fixed;
            top: 360px;
            left: 460px;
            font-family: Montserrat;
            color: #0b2847;
        }
    </style>

    <style>
        .text-box4 {
            border: 1px solid white;
            padding: 1px;
            width: 300px;
            height: 30px;
            position: fixed;
            top: 400px;
            left: 460px;
            font-family: Montserrat;
            background-color: #a8b6f0;
        }
    </style>

    <style>
        posSignOut {
            position: fixed;
            top: 50px;
            right: 200px;
        }

        posDelete {
            position: fixed;
            top: 500px;
            right: 459px;
        }

        posUpdate {
            position: fixed;
            top: 500px;
            right: 360px;
        }

    </style>

    <style>
        .checkboxUser {
            p");
                WriteLiteral(@"osition: fixed;
            top: 480px;
            left: 480px;
            font-size: 20px;
            font-weight: bold;
        }

    </style>

    <style>
        .checkboxCritic {
            position: fixed;
            top: 520px;
            left: 480px;
            font-size: 20px;
            font-weight: bold;
        }

        .search-container {
        }

        .search-box {
            font-family: 'Montserrat', sans-serif; /*sans-serif is in case there is no montserrat on the user's system*/
            font-size: 22px;
            color: #0b2847;
            margin: 0 10px;
            padding: 10px;
            border-radius: 30px;
            border: 1px solid gray;
            width: 300px;
        }

        .search-button {
            font-family: 'Montserrat', sans-serif; /*sans-serif is in case there is no montserrat on the user's system*/
            font-size: 22px;
            font-weight: bold;
            text-align: center;
            ");
                WriteLiteral(@"color: #0b2847;
            background-color: #a8b6f0;
            width: 100px;
            height: 50px;
            padding: 10px;
            border-radius: 30px;
            border: none;
            cursor: pointer;
        }

        posSearch {
            position: absolute;
            top: 45px;
            left: 250px;
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf215c79a62c3d5f702ba98324d8fef3bc6ed7814058", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf215c79a62c3d5f702ba98324d8fef3bc6ed7814321", async() => {
                    WriteLiteral("\r\n        <posSearch>\r\n            <input type=\"text\" class=\"search-box\" placeholder=\"Type here\">\r\n            <button type=\"submit\" class=\"search-button\">Search</button>\r\n        </posSearch>\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <div class=""text-box"">
        <div class=""background""></div>
    </div>


    <div>
        <posSignOut>
            <button class=""signOut"">Sign out</button>
        </posSignOut>
    </div>


    <h1>
        User
    </h1>


    <h2>
        Name:
    </h2>



    <h3>
        Last name:
    </h3>



    <h4>
        Date of birth:
    </h4>


    <h5>
        Address:
    </h5>

    <h6>
        Email:
    </h6>


    <div class=""text-box"">
    </div>

    <div class=""text-box1"">
    </div>


    <div class=""text-box2"">
    </div>

    <div class=""text-box3"">
    </div>

    <div class=""text-box4"">
    </div>

    <div class=""checkboxUser"">
        <label for=""userCheckbox"">User</label>
        <input type=""checkbox"" id=""userCheckbox"" name=""User"">
    </div>

    <div class=""checkboxCritic"">
        <label for=""criticCheckbox"">Critic</label>
        <input type=""checkbox"" id=""criticCheckbox"" name=""Critic"">
    </div>

    <div>
                WriteLiteral(@"
        <posDelete>
            <button class=""delete"">Delete</button>
        </posDelete>
    </div>

    <div>
        <posUpdate>
            <button class=""update"">Update</button>
        </posUpdate>
    </div>
    <!--JEDAN CHECKBOX JE DISABLED KADA JE DRUGI KLIKNUT, TO DODATI!!!
        DODATI SVUGDJE ZA MONTSERRAT  + STILOVE POPRAVITI!
    -->

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Spotifive.Models.Administrator> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591