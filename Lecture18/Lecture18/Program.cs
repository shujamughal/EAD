using System;

namespace Lecture18
{
    delegate void Delegate1();
    delegate void Delegate2(string s);
    delegate string Delegate3(string s);
    delegate int MathOp(int x, int y);
    class Program
    {
        static int PerformOperation(MathOp op, int x, int y) {
            return op(x, y);

        }
        static string Display3(string s) {
            Console.WriteLine(s);
            return s;
        }
        static void Display() {
            Console.WriteLine("Hello World!...");
        }
        static void Display4()
        {
            Console.WriteLine("Hello World!...from display 4");
        }
        static void Display2(string s)
        {
            Console.WriteLine(s);

        }
          
        static void Main(string[] args)
        {

            Console.WriteLine(PerformOperation(Calculator.Add, 4, 6));
            Console.WriteLine(PerformOperation(Calculator.Subtract, 4, 6));
            string input = Console.ReadLine();
            int i = System.Convert.ToInt32(input);

            Delegate1 d1 = null;

            if (i == 0)
            {
                d1 = Display;
            }
            else {
                d1 = Display4;
            }
            d1.Invoke();
            d1();
            //Delegate2 d2 = new Delegate2(Display2);
            Delegate2 d2 = Display2;
            d2("AOA Pakistan...");

            Delegate3 d3 = Display3;
            string s = d3("Some text");
        }
    }
}
