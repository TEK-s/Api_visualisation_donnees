#pragma checksum "D:\ProjetWebApplication - Copie\StatPop\Views\testController1\Graphe_Region.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cabbb87c37471189b90162b3180c6a05a007ab7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_testController1_Graphe_Region), @"mvc.1.0.view", @"/Views/testController1/Graphe_Region.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cabbb87c37471189b90162b3180c6a05a007ab7f", @"/Views/testController1/Graphe_Region.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6211f958706233951a761a8cc514da4940a4c845", @"/Views/_ViewImports.cshtml")]
    public class Views_testController1_Graphe_Region : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\ProjetWebApplication - Copie\StatPop\Views\testController1\Graphe_Region.cshtml"
  
    ViewData["Title"] = "Graphe_Region";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-12 mb-3"">
    <div class="" row container-fluid section1 text-center"">

    </div>
</div>
<div class="" contenair-fluid section1 text-center "">
    <h1>Graphe de variation croissance</h1>
</div>
<div class="" row container-fluid section1 text-center"">
    <div class=""col-md-12 text-center mb-3"">
        <h2>caract??ristique du graphe</h2>
        <p>
            Graphe du nombre de pays par region simul?? suivant le fichier
            <a href=""C:\Users\arthu\Downloads\projet architecture\Metadata_Country_API_SP.POP.GROW_DS2_fr_csv_v2_1940847.csv""><strong>Metadata_Country</strong></a>
        </p>
    </div>
</div>
<div class=""row container-fluid section1 text-center"">
    
    <div class=""col-md-10 text-center mb-3"">
        <script src=""https://cdn.jsdelivr.net/npm/chart.js""></script>
        <canvas id=""myChart"" width=""800"" height=""500""></canvas>
    </div>
</div>
<script>
    var ctx = document.getElementById('myChart').getContext('2d');
    var v = ");
#nullable restore
#line 32 "D:\ProjetWebApplication - Copie\StatPop\Views\testController1\Graphe_Region.cshtml"
       Write(Html.Raw(@ViewBag.region));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\nvar myChart = new Chart(ctx, {\r\n    type: \'bar\',\r\n    data: {\r\n        labels:v,\r\n        datasets: [{\r\n            label: \'number country per region\',\r\n            data: ");
#nullable restore
#line 39 "D:\ProjetWebApplication - Copie\StatPop\Views\testController1\Graphe_Region.cshtml"
             Write(ViewBag.count_Country);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            backgroundColor: [
                'rgba(255, 99, 132, 0.2)',
                'rgba(54, 162, 235, 0.2)',
                'rgba(255, 206, 86, 0.2)',
                'rgba(75, 192, 192, 0.2)',
                'rgba(153, 102, 255, 0.2)',
                'rgba(255, 159, 64, 0.2)'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 1
        }]
    },
    options: {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: true
                }
            }]
        }
    }
});
</script>


");
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
