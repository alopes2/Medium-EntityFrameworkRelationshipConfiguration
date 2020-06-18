using EntityFrameworkRelationship.Api.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkRelationship.Api.Data.Configurations
{
    public class MembershipConfiguration : IEntityTypeConfiguration<Membership>
    {
        public void Configure(EntityTypeBuilder<Membership> builder)
        {
            // other configurations

            builder
                .HasMany(m => m.Customers)
                .WithOne(c => c.Membership)
                .HasForeignKey(c => c.MembershipId);
        }
    }
}