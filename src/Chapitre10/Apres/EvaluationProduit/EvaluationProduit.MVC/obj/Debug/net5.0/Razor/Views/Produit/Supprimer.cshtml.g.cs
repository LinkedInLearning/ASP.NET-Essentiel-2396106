#pragma checksum "C:\Users\didou\Documents\LinkedinLearning\CodeSource\Chapitre10\Apres\EvaluationProduit\EvaluationProduit.MVC\Views\Produit\Supprimer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93b15a97d8d8520a257b8b159b035db267761410"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produit_Supprimer), @"mvc.1.0.view", @"/Views/Produit/Supprimer.cshtml")]
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
#line 1 "C:\Users\didou\Documents\LinkedinLearning\CodeSource\Chapitre10\Apres\EvaluationProduit\EvaluationProduit.MVC\Views\_ViewImports.cshtml"
using EvaluationProduit.MVC;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93b15a97d8d8520a257b8b159b035db267761410", @"/Views/Produit/Supprimer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"623896c93a39f2be62175ea6eb9cda1ceebb5e02", @"/Views/_ViewImports.cshtml")]
    public class Views_Produit_Supprimer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EvaluationProduit.Domaines.Models.ProduitModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\didou\Documents\LinkedinLearning\CodeSource\Chapitre10\Apres\EvaluationProduit\EvaluationProduit.MVC\Views\Produit\Supprimer.cshtml"
  
    ViewData["Title"] = "Supprimer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Supprimer</h1>\r\n\r\n<h3>Êtes-vous sûr de vouloir supprimer ceci</h3>\r\n<div>\r\n    <h4>ProduitModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\didou\Documents\LinkedinLearning\CodeSource\Chapitre10\Apres\EvaluationProduit\EvaluationProduit.MVC\Views\Produit\Supprimer.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\didou\Documents\LinkedinLearning\CodeSource\Chapitre10\Apres\EvaluationProduit\EvaluationProduit.MVC\Views\Produit\Supprimer.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\didou\Documents\LinkedinLearning\CodeSource\Chapitre10\Apres\EvaluationProduit\EvaluationProduit.MVC\Views\Produit\Supprimer.cshtml"
       Write(Html.DisplayNameFor(model => model.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\didou\Documents\LinkedinLearning\CodeSource\Chapitre10\Apres\EvaluationProduit\EvaluationProduit.MVC\Views\Produit\Supprimer.cshtml"
       Write(Html.DisplayFor(model => model.Nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\didou\Documents\LinkedinLearning\CodeSource\Chapitre10\Apres\EvaluationProduit\EvaluationProduit.MVC\Views\Produit\Supprimer.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\didou\Documents\LinkedinLearning\CodeSource\Chapitre10\Apres\EvaluationProduit\EvaluationProduit.MVC\Views\Produit\Supprimer.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\didou\Documents\LinkedinLearning\CodeSource\Chapitre10\Apres\EvaluationProduit\EvaluationProduit.MVC\Views\Produit\Supprimer.cshtml"
       Write(Html.DisplayNameFor(model => model.DateCreation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\didou\Documents\LinkedinLearning\CodeSource\Chapitre10\Apres\EvaluationProduit\EvaluationProduit.MVC\Views\Produit\Supprimer.cshtml"
       Write(Html.DisplayFor(model => model.DateCreation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\didou\Documents\LinkedinLearning\CodeSource\Chapitre10\Apres\EvaluationProduit\EvaluationProduit.MVC\Views\Produit\Supprimer.cshtml"
       Write(Html.DisplayNameFor(model => model.MoyenneEvaluation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\didou\Documents\LinkedinLearning\CodeSource\Chapitre10\Apres\EvaluationProduit\EvaluationProduit.MVC\Views\Produit\Supprimer.cshtml"
       Write(Html.DisplayFor(model => model.MoyenneEvaluation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\didou\Documents\LinkedinLearning\CodeSource\Chapitre10\Apres\EvaluationProduit\EvaluationProduit.MVC\Views\Produit\Supprimer.cshtml"
       Write(Html.DisplayNameFor(model => model.Prix));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\didou\Documents\LinkedinLearning\CodeSource\Chapitre10\Apres\EvaluationProduit\EvaluationProduit.MVC\Views\Produit\Supprimer.cshtml"
       Write(Html.DisplayFor(model => model.Prix));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    ");
#nullable restore
#line 51 "C:\Users\didou\Documents\LinkedinLearning\CodeSource\Chapitre10\Apres\EvaluationProduit\EvaluationProduit.MVC\Views\Produit\Supprimer.cshtml"
Write(Html.ActionLink("Supprimer", "SupprimerProduit", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 52 "C:\Users\didou\Documents\LinkedinLearning\CodeSource\Chapitre10\Apres\EvaluationProduit\EvaluationProduit.MVC\Views\Produit\Supprimer.cshtml"
Write(Html.ActionLink("Retour", "RedirectionVersIndex"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EvaluationProduit.Domaines.Models.ProduitModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
