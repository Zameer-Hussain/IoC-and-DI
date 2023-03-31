using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_and_DI.IoC
{

    /*
     * In the previous chapter, related to DIP, we created and used abstraction to make the classes loosely coupled. 
     * Here, we are going to implement Dependency Injection and strategy pattern together to move the dependency object creation completely out of the class. 
     * This is our third step in making the classes completely loose coupled....
     * 
     * *******************************************************************
     * Dependency Injection (DI) is a design pattern used to implement IoC
     *  It allows the creation of dependent objects outside of a class and provides those objects to a class through different ways. 
     *  Using DI, we move the creation and binding of the dependent objects outside of the class that depends on them.
     *  Dependency Injection Pattern involves 3 types of class
     *  Client Class:- (Dependent class) that depend on Server class.
     *  Server Class:- (Dependency) is a class that provides service to the client class
     *  Injector Class:- this injects the service class object into the client class.
     *  
     *  The injector class creates an object of the service class, and injects that object to a client object
     *  This way DI pattern separates the responsibility of creating an object of the service class out of client class.
     *  ***********************************************************************************************
     *  
     *  
     *  Dependency Injection injects dependencies broadly in three ways
     *  01:- Constructor Injection: - Injector supplies services(dependencies) through the client class constructor.
     *  02:- Property Injection: - Injector supplies the dependency through public property of client class.
     *  03:- Method Injection: - in this type, client class implements an interface which declares the method(s) to supply the dependency and the injector uses this interface to supply the dependency to the client class...
     *  
     *  For examples visit
     *  https://www.tutorialsteacher.com/ioc/dependency-injection
     */
    internal class Step3DI
    {
    }
}
