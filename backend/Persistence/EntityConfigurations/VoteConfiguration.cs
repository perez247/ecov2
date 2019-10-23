using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class VoteConfiguration : IEntityTypeConfiguration<Vote>
    {
        public void Configure(EntityTypeBuilder<Vote> builder)
        {
            builder.Property(entity => entity.Type)
                .HasMaxLength(50);
            
            builder.Property(entity => entity.VoterType)
                .HasMaxLength(50);
        }
    }
}