using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Terminology.Domain;

namespace Terminology.App.Infra.Contracts.EF.EntityConfiguration
{
    internal class ColumnConfiguration : IEntityTypeConfiguration<Column>
    {
        public void Configure(EntityTypeBuilder<Column> builder) 
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Name);
            builder.HasIndex(x => x.Value);

            builder.HasOne(x => x.Record).WithMany(x => x.Columns);
        }
    }
}
