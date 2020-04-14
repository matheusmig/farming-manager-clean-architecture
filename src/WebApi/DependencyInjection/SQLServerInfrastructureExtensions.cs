using Application.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.DependencyInjection
{
    public static class SQLServerInfrastructureExtensions
    {
        public static IServiceCollection AddSQLServerPersistence(
            this IServiceCollection services,
            IConfiguration configuration)
        {
           /* services.AddScoped<IUserFactory, EntityFactory>();
            services.AddScoped<IEmployeeFactory, EntityFactory>();

            services.AddDbContext<CleanArchContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IUserRepository, UserRepository>();*/

            return services;
        }
    }
}
