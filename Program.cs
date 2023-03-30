// See https://aka.ms/new-console-template for more information
using IoC_and_DI.IoC;

Console.WriteLine("Hello, World!");


//Step#01:- implement IoC using Facotry pattern
A1 a1 = new();
a1.task1();


//calling simple tightly coupled class without any step.
A a = new A();
a.Task1();
