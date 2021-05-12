using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture66_EFCore_Part1
{
    class Product
    {
        public int ID { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Name { get; set; } = String.Empty;
        public decimal Price { get; set; } 

        [Column("Product_Description")]
        [MaxLength(500)]
        public string? Description { get; set; }

        public Catagory? Catagory { get; set; }

        public int CatagoryId { get; set; }
    }
}
