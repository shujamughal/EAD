/*
 Type Casting (implicit and explicit )
 */
using System;

namespace Lecture_7
{
    class Program
    {
        static void Main(string[] args)
        {








            //implicit
            int a = 10;
            double b = a; // an int can be safely cast into a double
            Console.WriteLine(b);

            //explicit
            double c = 9.8;
            //int d = c; // compiler gives an error for this line
            int d = (int)c;  // d is 9 losing the .8 part
            Console.WriteLine(d);

            // Converting types using System.Convert method.
            double g = 9.8;
            int h = System.Convert.ToInt32(g);
            Console.WriteLine($"g is {g} and h is {h}");


            //Understanding rounding rule.
            double[] doubles = new[]
                       { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
            foreach (double n in doubles)
            {
                Console.WriteLine($"ToInt({n}) is " +
                    $"{System.Convert.ToInt32(n)}");
            }

            /* //Banker's Rounding,
            • It always rounds down if the decimal part is less than the midpoint .5.
            • It always rounds up if the decimal part is more than the midpoint .5.
            • It will round up if the decimal part is the midpoint .5 and the non-decimal
                part is odd, but it will round down if the non-decimal part is even.
             */


            //traditional way of rounding 
            foreach (double n in doubles)
            {
                Console.WriteLine(Math.Round(value: n, digits: 0, mode: MidpointRounding.AwayFromZero)
                                    );
            }

            //Converting into String.
            int number = 12;
            Console.WriteLine(number.ToString());
            bool boolean = true;
            Console.WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString());
            object me = new object();
            Console.WriteLine(me.ToString());








            //Converting from string to datatype.
            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1980");
            Console.WriteLine($"I was born {age} years ago.");
            Console.WriteLine($"My birthday is {birthday}.");
            Console.WriteLine($"My birthday is {birthday:D}.");

            //int count = int.Parse("abc");

            Console.Write("How many eggs are there? ");
            int count;
            string input = Console.ReadLine();
            if (int.TryParse(input, out count))
            {
                Console.WriteLine($"There are {count} eggs.");
            }
            else
            {
                Console.WriteLine("I could not parse the input.");
            }



            Console.WriteLine("Before parsing");
            Console.Write("What is your age? ");
            input = Console.ReadLine();
            try
            {
                age = int.Parse(input);
                Console.WriteLine($"You are {age} years old.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"your input format is incorrect. please enter age in numbers only.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"your input format is correct. please enter age from 1 to 99.");
            }
            catch (Exception ex)
           {
               Console.WriteLine($"{ex.GetType()} says {ex.Message}");
           }










            Console.WriteLine($"int range is from {int.MinValue} to {int.MaxValue}");

            int x = int.MaxValue - 1;
            checked
            {
                Console.WriteLine($"Initial value: {x}");
                x++;
                Console.WriteLine($"After incrementing: {x}");
                x++;
                Console.WriteLine($"After incrementing: {x}");
                x++;
                Console.WriteLine($"After incrementing: {x}");

            }


        }
    }
}