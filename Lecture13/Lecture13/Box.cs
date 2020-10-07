using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture13
{
    class Box
    {

        private double length;   
        private double width;  
        private double height;

        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public  void PrintBoxDetails()
        {
            Console.WriteLine($" length:{length}, width:{width}  height:{height}" );
        }

        /*public static Box AddBoxes(Box b, Box c) {
            Box box = new Box();
            box.length = b.length + c.length;
            box.width = b.width + c.width;
            box.height = b.height + c.height;
            return box;
        }//*/

        // Overload + operator to add two Box objects.
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.width = b.width + c.width;
            box.height = b.height + c.height;
            return box;
        }

        public static bool operator ==(Box lhs, Box rhs)
        {
            bool status = false;
            if (lhs.length == rhs.length && lhs.height == rhs.height
               && lhs.width == rhs.width)
            {

                status = true;
            }
            return status;
        }

        public static bool operator !=(Box lhs, Box rhs)
        {
            bool status = false;

            if (lhs.length != rhs.length || lhs.height != rhs.height ||
               lhs.width != rhs.width)
            {

                status = true;
            }
            return status;
        }

      
    }
}
