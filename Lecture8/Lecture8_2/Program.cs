using Lecture8;
using System;

namespace Lecture8_2
{
    class Driver :A
    {

        public void Test()
        {

            var aObj = new A();
            var bObj = new B();
            var dObj = new Driver();


            aObj.xInternal = 12;
            bObj.xInternal = 23;

            aObj.xPI = 12;
            bObj.xPI = 23;
            dObj.xPI= 23;

            aObj.xPP = 12;
            bObj.xPP = 23;
            dObj.xPP = 12;


            aObj.xProtected = 12;
            bObj.xProtected = 23;
            dObj.xProtected = 12;
        }

    }

}
