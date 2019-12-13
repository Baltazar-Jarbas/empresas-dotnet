using AppEmpresas.Data;
using AppEmpresas.Data.Repository;
using AppEmpresas.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AppEmpresas.WebAPI.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IEnterpriseRepository, EnterpriseRepository>();
            services.AddScoped<AppEmpresasDbContext>();
        }
    }
}