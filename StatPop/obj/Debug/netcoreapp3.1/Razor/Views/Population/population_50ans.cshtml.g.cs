#pragma checksum "D:\ProjetWebApplication - Copie\StatPop\Views\Population\population_50ans.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce9f390d6c48846977548ae73371cd4f9aa5a2f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Population_population_50ans), @"mvc.1.0.view", @"/Views/Population/population_50ans.cshtml")]
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
#line 1 "D:\ProjetWebApplication - Copie\StatPop\Views\_ViewImports.cshtml"
using StatPop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ProjetWebApplication - Copie\StatPop\Views\_ViewImports.cshtml"
using StatPop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce9f390d6c48846977548ae73371cd4f9aa5a2f4", @"/Views/Population/population_50ans.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6211f958706233951a761a8cc514da4940a4c845", @"/Views/_ViewImports.cshtml")]
    public class Views_Population_population_50ans : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\ProjetWebApplication - Copie\StatPop\Views\Population\population_50ans.cshtml"
  
    ViewData["Title"] = "population sur 5 ans";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class="" contenair-fluid section1 text-center "">
    <h1>Graphe variation croissance</h1>
</div>
<div class="" row container-fluid section1 text-center"">
    <div class=""col-md-12 text-center mb-3"">
        <h2>caract??ristique du graphe</h2>
        <p>Variation de la croissance de la population suivant toutes les ann??es </p>
    </div>
</div>
<div class=""row container-fluid section1 text-center"">
    <div class=""col-md-2"">

    </div>
    <div class=""col-md-8 mb-3"">
        <script src=""https://cdn.jsdelivr.net/npm/chart.js""></script>
        <canvas id=""myChart"" width=""500"" height=""500""></canvas>
    </div>
    <div class=""col-md-2"">

    </div>
</div>
<script>
    var ctx = document.getElementById('myChart').getContext('2d');
    var v = ");
#nullable restore
#line 29 "D:\ProjetWebApplication - Copie\StatPop\Views\Population\population_50ans.cshtml"
       Write(Html.Raw(@ViewBag.liste_years));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var ctx = document.getElementById(\'myChart\').getContext(\'2d\');\r\n    var chart = new Chart(ctx, {\r\n        // The type of chart we want to create\r\n        type: \'line\',\r\n\r\n        // The data for our dataset\r\n        data: {\r\n            labels: ");
#nullable restore
#line 37 "D:\ProjetWebApplication - Copie\StatPop\Views\Population\population_50ans.cshtml"
               Write(ViewBag.liste_anne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,\r\n            datasets: [{\r\n                label: \'Population croissance per year\',\r\n                backgroundColor: \'rgb(255, 99, 132)\',\r\n                borderColor: \'rgb(255, 99, 132)\',\r\n                data: ");
#nullable restore
#line 42 "D:\ProjetWebApplication - Copie\StatPop\Views\Population\population_50ans.cshtml"
                 Write(ViewBag.liste_years);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            }]\r\n        },\r\n\r\n        // Configuration options go here\r\n        options: {}\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
