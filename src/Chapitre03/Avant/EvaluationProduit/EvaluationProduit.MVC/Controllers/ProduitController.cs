using System;
using System.Collections.Generic;
using EvaluationProduit.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using EvaluationProduit.MVC.Services;

namespace EvaluationProduit.MVC.Controllers
{
    public class ProduitController : Controller
    {
        private readonly IProduitService _produitService;

        public ProduitController(IProduitService produitService)
        {
            _produitService = produitService;
        }

        public IActionResult Index()
        {
            //return View(ListDesProduits());
            return View(_produitService.ProduitModels);
        }

        public IActionResult Ajouter()
        {
            return View();
        }

        public IActionResult Modifier()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Supprimer()
        {
            return View();
        }

        private IList<ProduitModel> ListDesProduits()
        {
            var produitModels = new List<ProduitModel>();
            var rnd = new Random();
            for (int i = 0; i < 40; i++)
            {
                var produitModel = new ProduitModel
                {
                    Id = i,
                    DateCreation = DateTime.Now,
                    Description = $"C'est la description du produit numéro:{i}",
                    MoyenneEvaluation = 0,
                    Nom = $"Produit-:{i}",
                    Prix = rnd.Next(),
                    CategorieModel = new CategorieModel
                    {
                        CategorieId = i,
                        NomCategorie = $"Catégorie:{i}"
                    }
                };
                produitModels.Add(produitModel);
            }
            return produitModels;
        }
    }
}
