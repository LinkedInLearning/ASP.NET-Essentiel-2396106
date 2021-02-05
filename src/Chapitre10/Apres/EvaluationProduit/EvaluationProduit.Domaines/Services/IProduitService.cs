using System.Collections.Generic;
using EvaluationProduit.Domaines.Models;

namespace EvaluationProduit.Domaines.Services
{
    public interface IProduitService
    {
        IList<ProduitModel> ProduitModels { get; set; }
    }
}
