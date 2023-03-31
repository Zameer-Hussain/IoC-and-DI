using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_and_DI.IoC
{
    //Step#02:- DIP (dependeny inversion principle).
    //High level moudules should not depent on low level modules.
    //both should depend on Abstraction.


    /*
     * As per the DIP definition, a high-level module should not depend on low-level modules. 
     * Both should depend on abstraction (abstract class or interfaces). 
     * So, first, decide which is the high-level module (class) and the low-level module. 
     * A high-level module is a module which depends on other modules. 
     * In our example, BusinessLogic depends on the DataAccessDIP class (Step1Example2), 
     * so BusinessLogic is a high-level module and DataAccessDIP is a low-level module. So, 
     * as per the first rule of DIP, 
     * BusinessLogic should not depend on the concrete DataAccess class, instead both classes should depend on abstraction(abstract class or interfaces).
     * Concrete means class whose we can create object.
     * */

    /*
     * so now for DIP rule abstraction, both classes Bussiness & dataaccess should depend on abstract/interface, so we create a IDataAccess interface & It's implementation class as DataAccessRepo.
     * Note:- as per DIP rule we can't create interface/abstract's object, 
     */
    internal class BussinessLogicDIP
    {
        internal BussinessLogicDIP() { }

        internal void PrintCustomerName(int id)
        {
            IDataAccessor dataAccessor = DAFactoryDIP.CreateDAObject();
            Console.WriteLine("\n\n************** Dependency Inversion Principle ***************");
            Console.WriteLine(dataAccessor.GetNameById(id));
            Console.WriteLine("*****************************************************************");
        }
    }//Bussiness logic

    //abstraction by interfaces
    internal interface IDataAccessor
    {
        internal string GetNameById(int id);
    }

    internal class DataAccessorRepo : IDataAccessor
    {
        string IDataAccessor.GetNameById(int id)
        {
            return $"Zameer Hussain with id {id}";
        }
    }


    //NOW NOT NEEDED THIS CLASS, 
    //internal class DataAccessorDIP
    //{ 
    //    internal string GetNameById(int id)
    //    {
    //        return "Muhammad Nouman Khan";
    //    }
    //}//DA



    internal class DAFactoryDIP
    {
        internal static IDataAccessor CreateDAObject()
        {
            return new DataAccessorRepo();
        }
    }//DA Factory
}//namespace
