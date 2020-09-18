//switch statment.
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace EAD_Lecture_6
//{
//    class SwitchStatement
//    {
//        static void Main(string[] args)
//        {








//            generating a random number
//            var number = (new Random()).Next(1, 12);


//            Console.WriteLine($"My random number is {number}");
//            The case values must be literal values.
//            switch (number)
//            {
//                case 1:
//                    Console.WriteLine("One");
//                    break; // jumps to end of switch statement
//                case 2:
//                    Console.WriteLine("Two");
//                    goto case 1;
//                case 3:
//                case 4:
//                    Console.WriteLine("Three or four");
//                    goto case 1;
//                default:
//                    Console.WriteLine("Default");
//                    break;
//            } // end of switch statement
//        }
//    }
//}
