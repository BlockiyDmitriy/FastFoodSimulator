using Business_Logic_Layear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FastFoodSimulatorConsole
{
    class ThreadCustomer
    {
        int time1;
        OrderTaker orderTaker;
        public ThreadCustomer(int time1, OrderTaker orderTaker)
        {
            this.time1 = time1;
            this.orderTaker = orderTaker;
        }

        public void run()
        {
            while (true)
            {
                Customer customer = new Customer("");
                orderTaker.TakeOrder(customer);
                try
                {
                    Thread.Sleep(time1 * 1000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}
