using Microsoft.EntityFrameworkCore;
using Terminology.Domain;

namespace Terminology.App.Infra.Contracts.EF
{
    internal class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Dictionary> Dictionary { get; set; }

        public DbSet<Record> Record { get; set; }

        public DbSet<Column> Column { get; set; }
    }
}
