/*
 The two selection statements in C# are if and switch.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace EAD_Lec5
{
    class Selectors
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("There are no arguments.");
            }
            else if (args.Length >= 2)
            {
                Console.WriteLine("There is at least two argument.");
            }
            //else {
            //    Console.WriteLine("There is at least one argument.");
           // }
        }
    }
}
