using EntityFrameworkRelationship.Api.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkRelationship.Api.Data.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            // Other entity configurations

            builder
                .HasOne(a => a.Customer)
                .WithOne(c => c.Address)
                .HasForeignKey<Address>(a => a.CustomerId);
        }
    }
}