using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Terminology.Domain;

namespace Terminology.App.Infra.Contracts.EF.EntityConfiguration
{
    internal class DictionaryConfiguration : IEntityTypeConfiguration<Dictionary>
    {
        public void Configure(EntityTypeBuilder<Dictionary> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Has
        }
    }
}
