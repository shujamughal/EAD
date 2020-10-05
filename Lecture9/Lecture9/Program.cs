using System;

namespace Lecture9
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personObj = new Person("ali", 12);
            Console.WriteLine(personObj.Name);
            Console.WriteLine(personObj.Age);
            Console.WriteLine(Person.Country);
            Console.WriteLine(Person.HomePlanet);
            Console.WriteLine(personObj.HomePlanet2);

            Person p2 = new Person { Name="mustafa", Age=20};




        }
    }
}
