using Application.Base;
using Domain.Farms;
using Infrastructure.InMemoryDataAccess;
using Infrastructure.InMemoryDataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.DependencyInjection
{
    public static class InMemoryInfrastructureExtensions
    {
        public static IServiceCollection AddInMemoryPersistence(this IServiceCollection services)
        {
            services.AddScoped<IFarmFactory, EntityFactory>();

            services.AddSingleton<CleanArchContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IFarmRepository, FarmRepository>();

            return services;
        }
    }
}
