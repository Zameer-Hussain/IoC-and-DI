using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_and_DI.IoC
{
    //As IoC principle suggests: invert the control, means handover control to another class

    //A1:- implementing 1st Step to achieve loosely coupled.
    //Step #01:- Implement IoC using Factory Pattern. 
    internal class A1
    {
        //now we will create object through an other class as below
        B b;
        internal A1()
        {
            b = Factory.createObjectofB();
        }

        internal void task1()
        {
            b.DoSomething("class A1 Factory pattern");
        }
    }

    
    internal class Factory
    {
        internal static B createObjectofB()
        {
            return new B();
        }
    }
}
