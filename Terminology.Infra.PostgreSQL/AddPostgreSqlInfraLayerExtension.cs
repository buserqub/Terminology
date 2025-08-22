using Terminology.Infra.PostgreSql.Extensions.ServiceCollection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Terminology.Infra.PostgreSql
{
    public static class AddPostgreSqlInfraLayerExtension
    {
        public static IServiceCollection AddPostgreSqlInfraLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAppDbContext(configuration);

            return services;
        }
    }
}
