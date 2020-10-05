using System;

namespace Lecture12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "shuja";
            p.Age = 12;
            p.Country = "Pakistan";
            Console.WriteLine(p.Name+ 
                " age is "+ p.Age + "country ="+p.Country
                + p.MyName);

            p[0] = "ali";
            Console.WriteLine(p[0]);
        }
    }
}
