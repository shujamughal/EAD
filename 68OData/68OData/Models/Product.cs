using System;
using System.Collections.Generic;

#nullable disable

namespace _68OData.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal? Price { get; set; }
        public string Style { get; set; }
        public string Size { get; set; }
        public string Description { get; set; }
        public int? CatagoryId { get; set; }

        public virtual Catagory Catagory { get; set; }
    }
}
