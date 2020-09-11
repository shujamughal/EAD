using System;

namespace EAD_Lec4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);

            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
            Console.WriteLine(args[2]);
            //int numberOfApples = 12;
            //decimal pricePerApple = 0.35M;

            //Console.WriteLine(numberOfApples + " apples costs "+ 
            //    (numberOfApples*pricePerApple));

            ////Formatting output using interpolated strings.

            //Console.WriteLine($"{numberOfApples} apples costs {numberOfApples*pricePerApple:C}");

            ////using numbered positional arguments
            //Console.WriteLine(
            //    format:"{0} apples costs {1:C}",
            //    arg0:numberOfApples,
            //    arg1:pricePerApple*numberOfApples
            //    );

            //string formattedString = string.Format(
            //    format: "{0} apples costs {1:C}",
            //    arg0: numberOfApples,
            //    arg1: pricePerApple * numberOfApples
            //    );

            //Console.WriteLine(formattedString);

            ////ReadKey
            //Console.Write("Press any key combination: ");
            //ConsoleKeyInfo key = Console.ReadKey();
            //Console.WriteLine();
            //Console.WriteLine(
            //    format:"key: {0}, Char: {1}, Modifier: {2}",
            //    arg0: key.Key,
            //    arg1:key.KeyChar,
            //    arg2:key.Modifiers
            //    );



        }
    }
}
