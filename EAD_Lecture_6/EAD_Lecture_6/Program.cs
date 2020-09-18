///*
// 1- Pattern matching with the if statement
// */
//using System;

//namespace EAD_Lecture_6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Are you checking type and doing type casting in your if statements?
//            //e.g consider the following code.






//            object o = 78;
//            int k;
//            if (o.GetType() == typeof( int) )
//            {
//                k = (int)o;
//                Console.WriteLine($"int {k}");
//            }
//            else if (o.GetType() == typeof(float))
//            {
//                float f = (float)o;
//                Console.WriteLine($"float {f}");
//            }
//            //else if() 
//            //{
//            //repeating the same procedure (check type and converting) again and again
//            //}


//            /***********************************************************/
//            if (o is int)
//            {
//                k = (int)o;
//                Console.WriteLine($"int {k}");
//            }
//            else if (o is float)
//            {
//                float f = (float)o;
//                Console.WriteLine($"float {f}");
//            }

//            /***********************************************************/



//            if (o is int x)
//            {
                
//                Console.WriteLine($"int {x}");
//            }
//            else if (o is float f)
//            {
//                Console.WriteLine($"float {f}");
//            }
//            /***********************************************************/


//            if (o is int i)
//            {
//                Console.WriteLine($"int {i}");
//            }
//            else if (o is float f)
//            {
//                Console.WriteLine($"float {f}");
//            }


//            /*-------------------------------------------------------------*/

//        }
//    }  
//}
