using PizzaFacil.Infra.Data.Context;

namespace PizzaFacil.API.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<PizzaFacilDbContext>();

            return services;
        }
    }
}
