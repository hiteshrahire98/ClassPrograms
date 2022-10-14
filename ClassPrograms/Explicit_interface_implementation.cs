using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPrograms
{
    public interface ICustomer
    {
        string Details();
    }

    public interface IOrder
    {
        string Details();
    }
    public class Transaction : ICustomer, IOrder
    {
        // implement interface explicitly
        string ICustomer.Details()
        {
            return $"Customer Details";
        }

        string IOrder.Details()
        {
            return $"Order Details";
        }

    }

    public class Explicit_interface_implementation
    {
        static void Main(string[] args)
        {
            ICustomer c = new Transaction();
            Console.WriteLine(c.Details());

            IOrder o = new Transaction();
            Console.WriteLine(o.Details());

        }


    }


}
