using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class IdeaConfiguration : IEntityTypeConfiguration<Idea>
    {
        public void Configure(EntityTypeBuilder<Idea> builder)
        {

            builder.Property(entity => entity.Description)
                .IsRequired()
                .HasMaxLength(1000);
            
            builder.Property(entity => entity.Type)
                .IsRequired()
                .HasMaxLength(50);

            builder.Ignore(entity => entity.EcoDetails);
            builder.Ignore(entity => entity.ProjectUrls);
            builder.Ignore(entity => entity.Photos);
            builder.Ignore(entity => entity.Votes);
            builder.Ignore(entity => entity.Comments);
        }
    }
}