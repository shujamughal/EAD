using System;

namespace Lecture10
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person {Age= 12, Name= "Ali", Country= "Pakistan" };
            //p.PrintPersonDetails();
            //Console.WriteLine(p.GetPersonName());
            //Console.WriteLine("name is "+ p.GetPersonNameAndAge().Text + "and age is "+
            //                  p.GetPersonNameAndAge().Number  );
            (string name, int age, string country)  = p.GetPersonDetails();
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(country);

        }
    }
}
