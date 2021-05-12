using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture66_EFCore_Part1
{
    class Catagory
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<Product> Products { get; set; } = new();
    }
}
