using Microsoft.Extensions.DependencyInjection;
using PizzaFacil.Application.Interfaces.Repositories;
using PizzaFacil.Application.Interfaces.Services;
using PizzaFacil.Application.Services;
using PizzaFacil.Infra.Data.Context;
using PizzaFacil.Infra.Data.Repositories;

namespace PizzaFacil.Infra.Ioc
{
    public static class DependencyInjection
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<PizzaFacilDbContext>();

            services.AddScoped<ICategoriaRepository, CategoriaRepository>();

            services.AddScoped<ICategoriaService, CategoriaService>();

            services.AddScoped<INotificador, Notificador>();

            return services;
        }
    }
}
