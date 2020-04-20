namespace WebApi.DependencyInjection
{
    using Application.Farms.UseCases.RegisterFarm.Boundaries;
    using Microsoft.Extensions.DependencyInjection;
    using WebApi.UseCases.V1.Farms.RegisterFarm;

    public static class UserInterfaceV1Extensions
    {
        public static IServiceCollection AddPresentersV1(this IServiceCollection services)
        {
            services.AddScoped<RegisterFarmPresenter>();
            services.AddScoped<IFarmRegisterOutputPort>(x => x.GetRequiredService<RegisterFarmPresenter>());

            services.AddScoped<FarmFindAllPaginatedPresenter>();
            services.AddScoped<IFarmFindAllPaginatedOutputPort>(x => x.GetRequiredService<FarmFindAllPaginatedPresenter>());

            return services;
        }
    }
}
