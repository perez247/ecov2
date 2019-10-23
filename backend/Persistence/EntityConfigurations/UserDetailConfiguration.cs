using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    public class UserDetailConfiguration : IEntityTypeConfiguration<UserDetail>
    {
        public void Configure(EntityTypeBuilder<UserDetail> builder)
        {
            builder.Property(entity => entity.FirstName)
                .IsRequired(false)
                .HasMaxLength(50);
            
            builder.Property(entity => entity.LastName)
                .IsRequired(false)
                .HasMaxLength(50);

            builder.Ignore(entity => entity.Address);
            builder.Ignore(entity => entity.Contact);
        }
    }
}