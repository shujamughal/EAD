using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture19
{
    internal class Calculator
    {
        static internal int Add(int a, int b) {
            int result = a + b;
            Console.WriteLine($"Add Method result:{result}");
            return result;
        }
        static internal int Subtract(int a, int b) {
            int result = a - b;
            Console.WriteLine($"Subtract Method result: {result}");
            return result;
        }
        static internal int Multiply(int a, int b) {
            int result = a * b;
            Console.WriteLine($"Multiply Method result: {result}");
            return result;
            
        }
    }
}
