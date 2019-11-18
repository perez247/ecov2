using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.EntityConfigurations
{
    public class OrganizationDetailsConfiguration : IEntityTypeConfiguration<OrganizationDetail>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<OrganizationDetail> builder)
        {
            // Ignore property
            builder.Ignore(entity => entity.Collection);
            builder.Ignore(entity => entity.Address);
            builder.Ignore(entity => entity.Contact);

            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(500);
        }
    }
}