using System;
using System.Collections.Generic;
using System.Text;
/*
Func is a generic delegate that encapsulates a method that can accept parameters 
and return some value.

There are 17 Func delegates defined in the class library. 
The first delegate cannot accept parameters and  can only return value
Other Func delegate can take upto 16 parameters and one return value. 
The last parameter is always the return type.

 */
namespace Lecture20
{
    class DelegateExample
    {
        public static string Sum(int a, int b)
        {
            string str = string.Format("Sum: {0}", (a + b));
            return str;
        }
        static void Main(string[] args)
        {
            Func<int, int, string> func = Sum;

            string result = func(2, 4);
            Console.WriteLine(result); //Print Sum: 6
        }
    }
}
