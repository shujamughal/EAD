using System;

namespace Lecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Defining variables
            /*
             Naming Convention: Camel Case e.g cost, costOfProduct
             */
            var myFirstVariable = "Hello World!" + " variable example";
            /*statment ends with semicolon. A statment can consist of 
             * multiple variables and expressions.
             */
            

            Console.WriteLine(myFirstVariable);

            //data types

            char letter = 'A';
            string text = "Pakistan";  //Literal string: 

            // unsigned integer means positive whole number
            // including 0
            uint naturalNumber = 23;

            // integer means negative or positive whole number
            // including 0
            int integerNumber = -23;

            // float means single-precision floating point
            // F suffix makes it a float literal
            float realNumber = 2.3F;

            // double means double-precision floating point
            double anotherRealNumber = 2.3; // double literal

            //Interpolated string:
            Console.WriteLine($"int uses {sizeof(int)} bytes");
            Console.WriteLine($"int minimum {int.MinValue} bytes");
            Console.WriteLine($"int minimum {int.MaxValue} bytes");

            Console.WriteLine($"uint uses {sizeof(uint)} bytes");
            Console.WriteLine($"uint minimum {uint.MinValue} bytes");
            Console.WriteLine($"uint minimum {uint.MaxValue} bytes");

            Console.WriteLine($"float uses {sizeof(float)} bytes");
            Console.WriteLine($"float minimum {float.MinValue} bytes");
            Console.WriteLine($"float minimum {float.MaxValue} bytes");

            Console.WriteLine($"double uses {sizeof(double)} bytes");
            Console.WriteLine($"double minimum {double.MinValue} bytes");
            Console.WriteLine($"double minimum {double.MaxValue} bytes");

            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes");
            Console.WriteLine($"decimal minimum {decimal.MinValue} bytes");
            Console.WriteLine($"decimal minimum {decimal.MaxValue} bytes");

            //A decimal variable uses 16 bytes of memory and can
            //store big numbers, but not as big as a double type.


            Console.WriteLine("Using doubles:");
            double a = 0.1;
            double b = 0.2;
            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equal 0.3");
            }
            /*-----------------------------------------------*/


            Console.WriteLine("Using decimals:");
            decimal c = 0.1M; // M suffix means a decimal literal value
            decimal d = 0.2M;
            if (c + d == 0.3M)
            {
                Console.WriteLine($"{c} + {d} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{c} + {d} does NOT equal 0.3");
            }

            //Use int for whole numbers and double for real
            //numbers that will not be compared to other values.Use decimal
            //for money, CAD drawings, general engineering, and wherever
            //accuracy of a real number is important.


            bool happy = true;
            bool sad = false;

            int thisCannotBeNull = 4;
            //thisCannotBeNull = null; // compile error!
            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
        }
    }
}
