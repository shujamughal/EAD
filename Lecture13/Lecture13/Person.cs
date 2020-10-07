using System;
using System.Collections.Generic;
using System.Text;
namespace Lecture13
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} is {Age} year{GenerateAgeSuffix(Age)} old";

            // Define a local function:
            string GenerateAgeSuffix(int age)
            {
                return age > 1 ? "s" : "";
            }


        }

        public static void Display(string str)
        {

            int ctr = 5;

            DisplayText();

            void DisplayText()
            {

                for (int i = 0; i < ctr; i++)
                {
                    Console.WriteLine(str);
                }
            }

        }
    }
}
