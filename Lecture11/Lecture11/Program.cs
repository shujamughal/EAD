using System;

namespace Lecture11
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Name="Ali", Age=12, Country= "Pakistan"};
            //p.SayHello("shuja", 12);
            //p.MyMethod("ali",123,85.69);
            //p.TotalMarks(1);
            //p.TotalMarks(1,3);
            //p.TotalMarks(1,4,5,6);
            //p.TotalMarks(1,2,3,4,5,67,8,9);
            //p.TotalMarks(1, 2, 3, 4, 5, 67, 8, 9,23);
            int a = 10;
            int b = 20;
            
            Console.WriteLine($"before passing a ={a}, b = {b}");
            p.PassingParamters(a, ref b,  out int c);
            Console.WriteLine($"after passing a ={a}, b = {b} and c={c}");
        }
    }
}
