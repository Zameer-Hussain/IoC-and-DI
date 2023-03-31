using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC_and_DI.IoC
{
    //   https://www.tutorialsteacher.com/ioc/inversion-of-control
    //for more detail check out above edxample...
    internal class Step1Example2
    {
    }

    internal class BussinessLogic
    {
        internal BussinessLogic() { }

        internal void PrintCustomerName(int id)
        {
            DataAccessor dataAccessor = DAFactory.CreateDAObject();
            Console.WriteLine(dataAccessor.GetNameById(id));
        }
    }//Bussiness logic

    internal class DataAccessor
    {
        internal DataAccessor(){}

        internal string GetNameById(int id)
        {
            return "Muhammad Nouman Khan";
        }
    }//DA



    internal class DAFactory
    {
        internal static DataAccessor CreateDAObject()
        {
            return new DataAccessor();
        }
    }//DA Factory
}//namespace
