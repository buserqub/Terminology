using Terminology.App.Infra.Contracts.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Terminology.Infra.PostgreSQL.Extensions
{
    public static class ApplyMigrationsExtension
    {
        public static IServiceProvider ApplyMigrations(this IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                context.Database.Migrate();
            }

            return serviceProvider;
        }
    }
}
