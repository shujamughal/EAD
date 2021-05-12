using System;
using System.Linq;
namespace _63_LINQ_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] { "Mustafa", "Shuja", "Zia", "Ibrahim",
                    "Ali", "Sabir","Azaz" };
            bool myValue = false;
            var query = names.Where(x => x.Length > 4).Where(n=>n.StartsWith("S"));
            query = query.Select(n => n);
            if (myValue == true)
            {
                query = query.Select(n=>n.Substring(0,4));
                query = query.OrderByDescending(n => n).ThenBy(n => n.Length);
            }
            else {
                query = query.OrderBy(n => n).ThenBy(n => n.Length);
            }

            foreach (var n in query) {
                Console.WriteLine(n);
            } 
        }
       
    }
}
