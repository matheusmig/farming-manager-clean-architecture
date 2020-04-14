namespace WebApi.DependencyInjection
{
    using Application.Farms.UseCases.RegisterFarm;
    using Domain.Farms;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Adds Use Cases classes.
    /// </summary>
    public static class ApplicationExtensions
    {
        /// <summary>
        /// Adds Use Cases to the ServiceCollection.
        /// </summary>
        /// <param name="services">Service Collection.</param>
        /// <returns>The modified instance.</returns>
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IRegisterFarmUseCase, RegisterFarmUseCase>();
            services.AddScoped<IFarmFindAllPaginatedUseCase, FarmFindAllPaginatedUseCase>();

            services.AddScoped<IFarmService, FarmService>();

            return services;
        }
    }
}
