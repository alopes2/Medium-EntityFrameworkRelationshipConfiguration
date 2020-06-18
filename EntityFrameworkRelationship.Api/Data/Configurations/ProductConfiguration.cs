using EntityFrameworkRelationship.Api.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkRelationship.Api.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // Other entity configurations

            builder
                .HasMany(p => p.CustomerProducts)
                .WithOne(cp => cp.Product)
                .HasForeignKey(cp => cp.ProductId);
        }
    }
}