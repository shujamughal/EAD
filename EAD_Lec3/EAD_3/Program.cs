using System;

namespace EAD_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //object type
            //This is a special type which can store any type of data.
            object mydata = 12;
            object myseconddata = "this is my string";
            object anotherdata = 23.45;
            string mystring = "this is another string";

            int lengthofstring = mystring.Length;
            int lengthofmyanotherstring = ((string)myseconddata).Length;

            //dynamic
            dynamic myAnotherString = "this is some other string";
            int lengthofMyThirdString = myAnotherString.Length;
            Console.WriteLine(lengthofMyThirdString);

            //var
            var x = "this is something.";
            var y = 234;
            //var z = RunMyFunction();

            int population = 66_000_000; //66 Million

            Console.WriteLine(default(int));
            Console.WriteLine(default(bool));
            Console.WriteLine(default(string));
            Console.WriteLine(default(decimal));

            //arrays
            string[] names;
            names = new string[4];

            names[0] = "shuja";
            names[1] = "baig";
            names[2] = "alishba";
            names[3] = "ibrahim";

            Console.WriteLine(names[3]);


            Console.WriteLine("Enter Age:");
            string age = Console.ReadLine();

            Console.WriteLine("you entered:  "+ age);



        }
    }
}
