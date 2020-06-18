using EntityFrameworkRelationship.Api.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkRelationship.Api.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Address> Addresses { get; set; }
        
        public DbSet<Membership> Memberships { get; set; }
        
        public DbSet<Product> Products { get; set; }
        
        public DbSet<CustomerProduct> CustomerProducts { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(MyDbContext).Assembly);
        }
    }
}