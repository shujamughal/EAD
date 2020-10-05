using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture10
{
    /*class TextAndNumber {
        public string Text;
        public int Number;
    }*/

    class Person
    {
        public string Name;
        public int Age;
        public string Country;

        public void PrintPersonDetails() {
            Console.WriteLine($"Person Name is : {this.Name}" +
                $"  and age is {this.Age}    ");
        }

        public string GetPersonName() {
            return $"My Name is {this.Name}";
        }

        public (string MyName, int MyAge, string MyCountry) GetPersonDetails() {
            return (this.Name, this.Age, this.Country);
        }

       /* public TextAndNumber GetPersonNameAndAge() {
            return new TextAndNumber { Text = this.Name, Number = this.Age };
        }*/

    }
}
