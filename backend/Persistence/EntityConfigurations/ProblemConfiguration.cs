using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class ProblemConfiguration : IEntityTypeConfiguration<Problem>
    {
        public void Configure(EntityTypeBuilder<Problem> builder)
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
            // builder.HasOne(entity => entity.Country);

            // builder.HasOne(entity => entity.State);
            // builder.Property(x => x.Description)
            //     .HasMaxLength(2000)
            //     .IsRequired();

            // // Relationship

            // // Problem 1 <-> * Projects
            // builder.HasMany(entity => entity.Projects)
            //     .WithOne(entity => entity.Problem)
            //     .OnDelete(DeleteBehavior.ClientSetNull);

            // // Problem 1 <-> * Photos
            // builder.HasMany(entity => entity.Photos)
            //     .WithOne(entity => entity.Problem)
            //     .OnDelete(DeleteBehavior.Cascade);

            // // Problem 1 <-> * Votes
            // builder.HasMany(entity => entity.Votes)
            //     .WithOne(entity => entity.Problem)
            //     .OnDelete(DeleteBehavior.Cascade);
            
            // // Problem 1 <-> * Ideas
            // builder.HasMany(entity => entity.Ideas)
            //     .WithOne(entity => entity.Problem)
            //     .OnDelete(DeleteBehavior.Cascade);
        }
    }
}