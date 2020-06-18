using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EntityFrameworkRelationship.Api.Core.Models
{
    public class Customer
    {
        public Customer()
        {
            CustomerProducts = new Collection<CustomerProduct>();
        }
        
        public int Id { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }

        public int MembershipId { get; set; }

        public Membership Membership { get; set; }
        
        public ICollection<CustomerProduct> CustomerProducts { get; set; }
    }
}