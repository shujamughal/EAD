using System;
using System.Collections.Generic;

#nullable disable

namespace _68OData.Models
{
    public partial class Catagory
    {
        public Catagory()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
