using CsvHelper;
using Lec65_LINQ;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

var reader = new StreamReader("sample_data.csv");
var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
var records = csv.GetRecords<Product>();

//display all products which start with P and we need only name, city and country.

/*records.Where(product => product.Name.StartsWith("P"))
                    .Select(product => new { product.Name, product.City, product.Country })
                    .ToList()
                    .ForEach(p=> Console.WriteLine($"{p.Name} : {p.City} : {p.Country}"));
*/

//display top 10 product w.r.t price

/*records.OrderByDescending(p=> p.Price)
       //.Take(10)
        .Skip(10)
       .ToList()
       .ForEach(p => Console.WriteLine($"{p.Name}  : {p.Price}"));
*/
//display count of products w.r.t country where year > 1996

/*records.GroupBy(p=>p.Country)
       .Select(p=> new { p.Key, NumberOfProducts= p.Count(p => p.Year > 2011) })
       .OrderBy(p=>p.Key)
       .ToList()
       .ForEach(p => Console.WriteLine($"{p.Key} : {p.NumberOfProducts} "));*/

//display the list of products that have atleast in two countries where price is greater than 40

/*records.Where(p=>p.Price >41)
       .Select(p => new { Name = p.Name.Substring(0, 4), p.Country })
       .GroupBy(p => p.Name)
       .Select(p => new { p.Key, NumberOfProducts = p.Distinct().Count() })
       .Where(p => p.NumberOfProducts >= 2)
       .ToList()
       .ForEach(p => Console.WriteLine($"{p.Key} : {p.NumberOfProducts} ")); ;*/

//display the average price w.r.t country

/*records.GroupBy(p=> p.Country)
       .Select(p=> new { p.Key,AVG= p.Average(p=>p.Price)})
        .ToList()
       .ForEach(p => Console.WriteLine($"{p.Key} : {p.AVG} ")); ; //*/


records.GroupBy(p=>p.Price switch { 
           <=30 => "0 to 30",
           <=61 => "31 to 60",
           _ => "61 and above"
}).Select(p=> new { p.Key, NumberOfProducts = p.Select(p=>p.Name).Distinct().Count() })
    .ToList()
       .ForEach(p => Console.WriteLine($"{p.Key} : {p.NumberOfProducts} ")); ; //*/



