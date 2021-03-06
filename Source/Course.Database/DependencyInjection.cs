using Course.Contracts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Store.Core.Database.Database;

namespace Store.Core.Database
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMongo(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IDbClient, DbClient>();
            services.Configure<DbConfig>(option => configuration.GetSection(nameof(DbConfig)).Bind(option));
            return services;
        }
    }
}