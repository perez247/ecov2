using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.Property(entity => entity.Type)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(entity => entity.TargetType)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(entity => entity.Message)
                .IsRequired()
                .HasMaxLength(1000);
        }
    }
}