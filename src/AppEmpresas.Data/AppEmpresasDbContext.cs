using Microsoft.EntityFrameworkCore;
using AppEmpresas.Domain.Entities;
using AppEmpresas.Core.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AppEmpresas.Data
{
    public class AppEmpresasDbContext : DbContext, IUnitOfWork
    {
        public AppEmpresasDbContext(DbContextOptions<AppEmpresasDbContext> options) 
            : base(options) { }

        public DbSet<Enterprise> Enterprises { get; set; }
        public DbSet<EnterpriseType> EnterpriseTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppEmpresasDbContext).Assembly);
        }

        public async Task<bool> Commit()
        {
            foreach(var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if(entry.State == EntityState.Added)
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Modified)
                    entry.Property("DataCadastro").IsModified = false;
                         
            }

            return await base.SaveChangesAsync() > 0;
        }
    }
}