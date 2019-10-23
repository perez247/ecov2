using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class ProjectUrlConfiduration : IEntityTypeConfiguration<ProjectUrl>
    {
        public void Configure(EntityTypeBuilder<ProjectUrl> builder)
        {
            builder.Property(entity => entity.Titile)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(entity => entity.Url)
                .HasMaxLength(1000)
                .IsRequired();

            builder.Property(entity => entity.Type)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}