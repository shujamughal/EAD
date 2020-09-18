// Switch Expressions (C# 8.0)
using System;
using System.Collections.Generic;
using System.Text;

namespace EAD_Lecture_6
{
    class SwitchExpression
    {
        static void Main(string[] args)
        {


            var operation = 5;

            var result = operation switch
            {
                1 => "Case 1",
                2 => "Case 2",
                3 => "Case 3",
                4 => "Case 4",
                _ => "No case availabe"
            };
            Console.WriteLine(result);

            /***********************/
            int a = 10, b = 5;
            var option = "/";

            var output = option switch
            {
                "+" => a + b,
                "-" => a - b,
                _ => a * b
            };
            Console.WriteLine("Example 1 : " + output);

            /***********************/
            var value = 5;

            int example2 = value switch
            {
                _ when value < 10 => 0,
                _ when value > 10 && value < 50 => 1,
                _ => 100
            };
            Console.WriteLine("Example 2 : " + example2);
            /******************************************************/

            object[] myObjects = { 1, 2, "hello", 2.35, true, null, 3.4f };
            var j = 10;
            foreach (var q in myObjects)
            {
                var thisObject = q switch
                {
                    //float f => j + 3+ f,
                    string s => $"it is a string {s}",
                    //double d => $"it is a double {d}",
                    double d when d ==2.35 => $"it is a double {d}",
                    bool bb => $"it is a boolean {bb}",
                    int k => $"it is an integer {k}",
                    null => $"this is null value in switch expression",
                    _ => "defaul value",


                };
                Console.WriteLine(thisObject);
            }//foreach
        }
    }
}
