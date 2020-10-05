using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Lecture11
{
    class Person
    {
        public string Name;
        public int Age;
        public string Country;

        public void SayHello() {
            Console.WriteLine($"My name is {this.Name}");
        }

        public void SayHello(string inputName)
        {
            Console.WriteLine($"My name is {this.Name} and input name is {inputName}");
        }

        public void SayHello(string inputName, int myValue)
        {
            Console.WriteLine($"My name is {this.Name} and input name is {inputName}");
        }

        public void MyMethod(string name="shuja", int someValue=5, double someOtherValue=2.5) {
            Console.WriteLine($"name is {name} and int value is {someValue} " +
                $" and double is {someOtherValue}");
        }

        public int TotalMarks(params int[] data) {
            int result = 0;
            //logic to add these numbers
            return result;
        }

        public void PassingParamters(int x, ref int y, out int z) {
            z = 99;
            x++;
            y++;
            z++;

        }
    }
}
