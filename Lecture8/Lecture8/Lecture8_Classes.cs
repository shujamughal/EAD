using System;

namespace Lecture8
{
    public class A {

        //private 
        private int xPrivate = 123;
        public int xPublic = 12;
        //A protected member is accessible within its class 
        //and by derived class instances.
        protected int xProtected = 10;
        // Only accessible within the same assembly.
        internal int xInternal = 10;
        //A protected internal member of a base class is accessible 
        //from any type within its containing assembly. 
        //It is also accessible in a derived class located in 
        //another assembly only if the access occurs through a 
        //variable of the derived class type.
        protected internal int xPI = 10;
        //A private protected member is accessible inside the type, 
        // or any type that inherits from the type 
        // and is in the same assembly
        private protected int xPP = 10;

        public void Print() {
            Console.WriteLine(this.xPrivate);
            Console.WriteLine(this.xPublic);
            Console.WriteLine(this.xProtected);
            Console.WriteLine(this.xInternal);
            Console.WriteLine(this.xPI);
            Console.WriteLine(this.xPP);





        }

    }

    public class B : A {

        public void Print() {
            Console.WriteLine(this.xPrivate);
            Console.WriteLine(this.xPublic);
            Console.WriteLine(this.xProtected);
            Console.WriteLine(this.xInternal);
            Console.WriteLine(this.xPI);
            Console.WriteLine(this.xPP);


            var aObj = new A();
            var bObj = new B();

            aObj.xProtected = 12;
            bObj.xProtected = 23;

            aObj.xPI = 12;
            bObj.xPI = 23;


            aObj.xPP = 12;
            bObj.xPP = 23;


        }


    }


    class Driver {

        public void Test() {

            var aObj = new A();
            var bObj = new B();
           
            aObj.xPrivate = 10; //Error
            bObj.xPrivate = 21; //Error

            aObj.xPublic = 12;
            bObj.xPublic = 23;

            aObj.xProtected = 12;
            bObj.xProtected = 23;

            aObj.xInternal = 12;
            bObj.xInternal = 23;

            aObj.xPI = 12;
            bObj.xPI = 23;

            aObj.xPP = 12;
            bObj.xPP = 23;
        }

    }
}
