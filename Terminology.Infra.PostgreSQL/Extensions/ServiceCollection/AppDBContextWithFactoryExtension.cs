using Terminology.App.Infra.Contracts.EF;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace Terminology.Infra.PostgreSQL.Extensions.ServiceCollection
{
    internal static class AddAppDbContextWithFactoryExtension
    {
        public static IServiceCollection AddAppDbContextWithFactory(this IServiceCollection services, IConfiguration configuration)
        {
            var dataSource = ConfigureDataSource(configuration);

            services.AddDbContextFactory<AppDbContext>(options =>
            {
                options.UseNpgsql(dataSource);
            });

            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(dataSource));

            return services;
        }

        private static NpgsqlDataSource ConfigureDataSource(IConfiguration configuration)
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(configuration.GetRequiredSection("PostgreSqlOptions:ConnectionString").Value);
            var dataSource = dataSourceBuilder.Build();

            return dataSource;
        }
    }
}
