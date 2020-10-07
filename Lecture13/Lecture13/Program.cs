//operator overloading
using System;

namespace Lecture13
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Box Box1 = new Box();   // Declare Box1 of type Box
                Box Box2 = new Box();   // Declare Box2 of type Box
                Box Box3;   // Declare Box3 of type Box
                

                // box 1 specification
                Box1.Length = 6.0;
                Box1.Width = 7.0;
                Box1.Height = 5.0;

                // box 2 specification
                Box2.Length = 12.0;
                Box2.Width = 13.0;
                Box2.Height = 10.0;

                
                

            // Add two object as follows:
            
            Box3 =  Box1+Box2;

            Box1.PrintBoxDetails();
            Box2.PrintBoxDetails();
            Box3.PrintBoxDetails();









            if (Box1 != Box2)
            { Console.WriteLine("Box1 is not equal to Box2"); }



            if (Box1 == Box2)
            { Console.WriteLine("Box1 is equal to Box2"); }
            else
            { Console.WriteLine("Box1 is not equal to Box2"); }
            //*/

            

            
            
            


            Person p = new Person { Name="Ali", Age=2};
            Console.WriteLine(p.ToString());
            Person.Display("Shuja");//*/

        }
    }
}
