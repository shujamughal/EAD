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

            var query = names.Where(NameLongerThanFour);

            foreach (var n in query) {
                Console.WriteLine(n);
            }
        }
        static bool NameLongerThanFour(string name)
        {
            return name.Length > 4;
        }
    }
}
