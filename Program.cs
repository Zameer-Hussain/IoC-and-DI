// See https://aka.ms/new-console-template for more information
using IoC_and_DI.IoC;

Console.WriteLine("Hello, World!");

//calling simple tightly coupled class without any step.
A a = new A();
a.Task1();


//Step#01:- implement IoC using Facotry pattern
A1 a1 = new();
a1.task1();
a1.task2();
//thus now, class A1 don't have control to create object of class B, 
//we have inverted control to Factory class for creating object of B.  



//now, let's understand it with more practical way, 
//loosly coupled means:- changes in one class should not force other classes to change.
//so whole application become maintainable and extensible.
BussinessLogic blogic = new BussinessLogic();
blogic.PrintCustomerName(2);


//in above exmaple we implement factory pattern to achieve IoC.
// But, the BusinessLogic class uses the concrete DataAccessor class.
// Therefore, it is still tightly coupled, even though we have inverted the dependent object
// creation to the factory class.
//Let 's use DIP on the BusinessLogic and DataAccessor classes and make them more loosely coupled...
//STEP#02:- DIP, Hight level should not depend on Low level, both depend on Abstraction.
BussinessLogicDIP dip = new BussinessLogicDIP();
dip.PrintCustomerName(100);





