using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EntityFrameworkRelationship.Api.Core.Models
{
    public class Product
    {
        public Product()
        {
            CustomerProducts = new Collection<CustomerProduct>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public ICollection<CustomerProduct> CustomerProducts { get; set; }
    }
}