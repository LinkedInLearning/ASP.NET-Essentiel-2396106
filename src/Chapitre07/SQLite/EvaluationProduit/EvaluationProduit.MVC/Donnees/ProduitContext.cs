using System;
using Microsoft.EntityFrameworkCore;

namespace EvaluationProduit.MVC.Donnees
{
    public class ProduitContext : DbContext
    {
        public ProduitContext(DbContextOptions<ProduitContext> options):base(options)
        {
            
        }
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Photo> Photos { get; set; }

    }
}
