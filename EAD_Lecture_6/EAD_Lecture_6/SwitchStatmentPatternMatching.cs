////Pattern matching with the switch statement (C# 7.0)
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace EAD_Lecture_6
//{
//    class SwitchStatmentPatternMatching
//    {
//        static void Main(string[] args)
//        {
            

//            object[] myObjects = { 1,2, "hello", 2.35, true, null };

//            foreach (var v in myObjects)
//            {

//                switch (v)
//                {
//                    case 1:
//                        Console.WriteLine($"it is an integer {v}");
//                        break;
//                    case "hello":
//                        Console.WriteLine($"it is a string {v}");
//                        break;
//                    case 2.36:
//                        Console.WriteLine($"it is a double {v}");
//                        break;
//                    case true:
//                        Console.WriteLine($"it is a boolean {v}");
//                        break;
//                    case null:
//                        Console.WriteLine($"it is a null value");
//                        break;
//                    default:
//                        Console.WriteLine("in default");
//                        break;
//                }
//            }
//            /*------------------------------------------------------------*/
//            //The case values no longer need to be literal values. They can be pattern
//            foreach (var x in myObjects)
//            {

//                switch (x)
//                {
//                    case int y:
//                        Console.WriteLine($"it is an integer {y}");
//                        break;
//                    case string s:
//                        Console.WriteLine($"it is a string {s}");
//                        break;
//                    //case double d:
//                      case double d when d == 2.36:
//                        Console.WriteLine($"it is a double {d}");
//                        break;
//                    case bool b:
//                        Console.WriteLine($"it is a boolean {b}");
//                        break;
//                    case null:
//                        Console.WriteLine($"it is a null value");
//                        break;
//                    default:
//                        Console.WriteLine("in default");
//                        break;
//                }
//            }//foreach loop


//        }
//    }
//}
