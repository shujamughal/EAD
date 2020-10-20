using System;
using System.Reflection.Metadata.Ecma335;

namespace Lecture19
{
    delegate int MathOperation(int x, int y);
    delegate void MyDelegate();
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("---Delegate Example---");

            MathOperation op = delegate (int x, int y) {
                Console.WriteLine("Add");
                return x + y;
            };
            //lambda Statement
            op +=  ( x,  y) => {
                Console.WriteLine("Subtract");
                return x - y;
            };

            //Lambda Expression
            op += (x, y) => x * y;

            MyDelegate d1 = () => Console.WriteLine("AOA...");

            d1();
            /*MyDelegate d1 = delegate () {
                Console.WriteLine("I am in anonymous method");
            };
            d1();*/
            Console.WriteLine(op(2,3));
            /*MathOperation op = Calculator.Add;
            //int result = op(6, 3);
            //Console.WriteLine($"result : {result}");
            op += Calculator.Subtract;
            op += Calculator.Multiply;

            int result = op(5, 4);
            Console.WriteLine(result);

            op -= Calculator.Subtract;

             result = op(5, 4);
            Console.WriteLine(result);*/
            







        }
    }
}
