#pragma checksum "C:\Users\Serap\Desktop\Recipes\Views\Foods\Food.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9576315f406b01f879a6feef28f67b6d17f3f6a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Foods_Food), @"mvc.1.0.view", @"/Views/Foods/Food.cshtml")]
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
#line 1 "C:\Users\Serap\Desktop\Recipes\Views\_ViewImports.cshtml"
using Recipes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Serap\Desktop\Recipes\Views\_ViewImports.cshtml"
using Recipes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9576315f406b01f879a6feef28f67b6d17f3f6a5", @"/Views/Foods/Food.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7ac766e05ac3f3ac52c771947f696b36ef9f93e", @"/Views/_ViewImports.cshtml")]
    public class Views_Foods_Food : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Recipes.Models.Food>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "C:\Users\Serap\Desktop\Recipes\Views\Foods\Food.cshtml"
Write(Model.FoodName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1> \r\n\r\n<img");
            BeginWriteAttribute("src", " src=\"", 63, "\"", 82, 1);
#nullable restore
#line 5 "C:\Users\Serap\Desktop\Recipes\Views\Foods\Food.cshtml"
WriteAttributeValue("", 69, Model.Banner, 69, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n<p>");
#nullable restore
#line 7 "C:\Users\Serap\Desktop\Recipes\Views\Foods\Food.cshtml"
Write("Puan: " + Model.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p>");
#nullable restore
#line 9 "C:\Users\Serap\Desktop\Recipes\Views\Foods\Food.cshtml"
Write("Materyaller: " + Model.Materials);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p>");
#nullable restore
#line 11 "C:\Users\Serap\Desktop\Recipes\Views\Foods\Food.cshtml"
Write(Model.Recipe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Recipes.Models.Food> Html { get; private set; }
    }
}
#pragma warning restore 1591
