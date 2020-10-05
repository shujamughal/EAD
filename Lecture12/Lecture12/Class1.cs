using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lecture12
{
    partial class Person
    {
        private string name;
        private string[] strData = new string[10];

        public string this[int index] {

            get => strData[index];
            set => strData[index] = value;
        }

        public string Country { get; set; }
        
        public string MyName => this.name;

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        private string favoritePrimaryColor;
        public string FavoritePrimaryColor
        {
            get
            {
                return favoritePrimaryColor;
            }
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException(
                        $"{value} is not a primary color. " +
                        "Choose from: red, green, blue.");
                }
            }
        }
        }
}
