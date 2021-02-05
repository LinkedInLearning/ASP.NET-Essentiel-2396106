using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EvaluationProduit.MVC.CoreDI;
using EvaluationProduit.MVC.Donnees;
using EvaluationProduit.MVC.Filtres;
using EvaluationProduit.MVC.Mappeurs;
using EvaluationProduit.MVC.Models;
using EvaluationProduit.MVC.Validation;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;

namespace EvaluationProduit.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ProduitContext>(options => options.UseSqlite("DataSource = produitBD.db"));
            //services.AddSingleton<ICategorieService, CategorieService>();
            //services.AddSingleton<IProduitService, ProduitService>();
            services.AddScoped<ProduitActionFilter>();
            services.AddTransient<IValidator<ProduitModel>, ProduitValidator>();
            services.AddSingleton<IProduitMapper, ProduitMapper>();
            services.AjouterProduitServices();
            //services.AddScoped<IProduitService, ProduitService>();
            //services.AddTransient<IProduitService, ProduitService>();

            

            services.AddControllersWithViews().AddFluentValidation();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ProduitContext ctx)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
