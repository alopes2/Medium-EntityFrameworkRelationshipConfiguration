using EntityFrameworkRelationship.Api.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkRelationship.Api.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            // Other entity configurations

            builder
                .HasOne(c => c.Address)
                .WithOne(a => a.Customer)
                .HasForeignKey<Address>(a => a.CustomerId);
                
            builder
                .HasOne(c => c.Membership)
                .WithMany(m => m.Customers)
                .HasForeignKey(c => c.MembershipId);

            builder
                .HasMany(c => c.CustomerProducts)
                .WithOne(cp => cp.Customer)
                .HasForeignKey(cp => cp.CustomerId);
        }
    }
}