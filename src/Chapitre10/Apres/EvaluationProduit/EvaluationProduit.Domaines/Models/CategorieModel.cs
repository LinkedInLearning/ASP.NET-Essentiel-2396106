using System;

namespace EvaluationProduit.Domaines.Models
{
    public record CategorieModel
    {
        public int Id { get; init; }
        public string Nom { get; init; }
        public string Description { get; init; }
        public DateTime DateCreation { get; init; }
    }
}
