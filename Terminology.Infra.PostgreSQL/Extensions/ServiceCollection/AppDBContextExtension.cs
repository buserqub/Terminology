using Terminology.App.Infra.Contracts.EF;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Data.Common;

namespace Terminology.Infra.PostgreSQL.Extensions.ServiceCollection
{
    internal static class AddAppDbContextExtension
    {
        public static IServiceCollection AddAppDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var dataSource = ConfigureDataSource(configuration);

            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(dataSource));

            return services;
        }

        private static NpgsqlDataSource ConfigureDataSource(IConfiguration configuration)
        {
            var connectionSection = configuration.GetRequiredSection("PostgreSqlOptions:ConnectionString");
            var connectionString = string.Join(";", new[]
            {
                $"Host={connectionSection["Host"]}",
                $"Port={connectionSection["Port"]}",
                $"Database={connectionSection["Database"]}",
                $"Username={connectionSection["Username"]}",
                $"Password={connectionSection["Password"]}"
            });

            var dataSourceBuilder = new NpgsqlDataSourceBuilder(connectionString);
            var dataSource = dataSourceBuilder.Build();

            return dataSource;
        }
    }
}
