using Microsoft.EntityFrameworkCore;
using PizzaFacil.Domain.Entities;
using PizzaFacil.Domain.Models;

namespace PizzaFacil.Infra.Data.Context
{
    public class PizzaFacilDbContext : DbContext
    {
        public PizzaFacilDbContext(DbContextOptions<PizzaFacilDbContext> options) : base(options){ }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cardapio> Cardapio { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                property.SetMaxLength(100);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PizzaFacilDbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
