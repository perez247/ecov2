using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class EcoDetailsConfiguration : IEntityTypeConfiguration<EcoDetails>
    {
        public void Configure(EntityTypeBuilder<EcoDetails> builder)
        {
            builder.Property(entity => entity.Type)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(entity => entity.UnSDGGoalsOther)
                .IsRequired(false)
                .HasMaxLength(500);

            builder.Property(entity => entity.IcoOther)
                .IsRequired(false)
                .HasMaxLength(500);
        }
    }
}