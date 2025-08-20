using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Terminology.Domain;

namespace Terminology.App.Infra.Contracts.EF.EntityConfiguration
{
    internal class RecordConfiguration : IEntityTypeConfiguration<Record>
    {
        public void Configure(EntityTypeBuilder<Record> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Dictionary).WithMany(x => x.Records);
        }
    }
}
