using Terminology.Domain;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Terminology.App.Infra.Contracts.EF
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Dictionary> Dictionary { get; set; }
        public DbSet<Record> Record { get; set; }
        public DbSet<Column> Column { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
