#pragma checksum "C:\Users\wstroup\source\repos\USDASearchApplication\USDASearchApp\Views\Food\ViewNutrient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e4551c29cb711909eae7e7bc0ccb866c40f6ed8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_ViewNutrient), @"mvc.1.0.view", @"/Views/Food/ViewNutrient.cshtml")]
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
#line 1 "C:\Users\wstroup\source\repos\USDASearchApplication\USDASearchApp\Views\_ViewImports.cshtml"
using USDASearchApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wstroup\source\repos\USDASearchApplication\USDASearchApp\Views\_ViewImports.cshtml"
using USDASearchApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e4551c29cb711909eae7e7bc0ccb866c40f6ed8", @"/Views/Food/ViewNutrient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"400b956a20094bff048bfcaa976638b76b22d91d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Food_ViewNutrient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Food>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3 class=\"text-white\">");
#nullable restore
#line 3 "C:\Users\wstroup\source\repos\USDASearchApplication\USDASearchApp\Views\Food\ViewNutrient.cshtml"
                  Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n\r\n<table class=\"table-dark\">\r\n    <tr>\r\n        <th>Sugar</th>\r\n        <th>Carbohydrates</th>\r\n        <th>fat</th>\r\n        <th>Protein</th>\r\n        <th>On Sale</th>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 14 "C:\Users\wstroup\source\repos\USDASearchApplication\USDASearchApp\Views\Food\ViewNutrient.cshtml"
       Write(Model.labelNutrients.sugars.value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 15 "C:\Users\wstroup\source\repos\USDASearchApplication\USDASearchApp\Views\Food\ViewNutrient.cshtml"
       Write(Model.labelNutrients.carbohydrates.value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 16 "C:\Users\wstroup\source\repos\USDASearchApplication\USDASearchApp\Views\Food\ViewNutrient.cshtml"
       Write(Model.labelNutrients.fat.value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\wstroup\source\repos\USDASearchApplication\USDASearchApp\Views\Food\ViewNutrient.cshtml"
       Write(Model.labelNutrients.protein.value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 18 "C:\Users\wstroup\source\repos\USDASearchApplication\USDASearchApp\Views\Food\ViewNutrient.cshtml"
       Write(Model.labelNutrients.calories.value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n</table>\r\n\r\n<div style=\"display: block\">\r\n    <a class=\"text-white\"");
            BeginWriteAttribute("href", " href=\"", 607, "\"", 649, 2);
            WriteAttributeValue("", 614, "/Product/UpdateProduct/", 614, 23, true);
#nullable restore
#line 24 "C:\Users\wstroup\source\repos\USDASearchApplication\USDASearchApp\Views\Food\ViewNutrient.cshtml"
WriteAttributeValue("", 637, Model.fdcId, 637, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add To Cart</a>\r\n</div>\r\n\r\n<div style=\"display: block\">");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Food> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
