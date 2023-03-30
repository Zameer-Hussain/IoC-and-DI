using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_and_DI.IoC
{ 
    //example of inversion of control
    internal class A
    {
        B b;
        internal A()
        {
            b = new B();
        }

        internal void Task1()
        {
            b.DoSomething("class A simple");
        }
    }

    internal class B
    {
        internal void DoSomething(string from)
        {
            Console.WriteLine($"I'm here to do something class B called from {from}");
        }
    }

    // here in above example we can see, class A need class B to complete task, 
    //means class A is dependent of B or in other words B has dependency of A.
    //as in Object oriented design approach class needs to interact with each other in order to 
    //achieve one or more functionalities of an application.

    // as in above example we saw that class A manages life time of an object of class B,
    //Class A creates and manages the life time of objects of the dependency class.

    //For first step of IoC, check IoCEampole2
}
