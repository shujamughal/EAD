using System;
using System.Linq;
using _67_EF_DbFirst.Models;


var db = new MYShopDBContext();
db.Products.ToList()
    .ForEach(p=> Console.WriteLine($" {p.Name}"));
