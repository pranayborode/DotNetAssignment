using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession.Interface
{
    public interface ICustomer
    {
        string print();
    }


    public interface IOrder
    {
        string print();
    }

    public class Trasaction : ICustomer, IOrder
    {
        string ICustomer.print()
        {
            return "Customer Details";
        }

        string IOrder.print()
        {
            return "Order Details";
        }
    }
}
