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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseCosmos("https://produitcosmosdb.documents.azure.com:443/",
                "CosmBzaawWAL9mhmcZRkEGlFQeP8sbMUk6x3kD7eetaGz9UdW5HOcCCPVMGbtKycWOrKNdPyjFGGKbRN50S0MeAkZA==osKey",
                "ProduitBD");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Photo>().ToTable("Photo");
            modelBuilder.Entity<Categorie>().ToContainer("produitcontainer");

            //modelBuilder.Entity<Produit>().ToTable("Produit");
        }
    }
}
