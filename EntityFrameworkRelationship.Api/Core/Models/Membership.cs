using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EntityFrameworkRelationship.Api.Core.Models
{
    public class Membership
    {
        public Membership()
        {
            Customers = new Collection<Customer>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Customer> Customers { get; set; }
    }
}