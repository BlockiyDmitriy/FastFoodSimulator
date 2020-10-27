using Business_Logic_Layear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FastFoodSimulatorConsole
{
    class MainThread 
    {
        int time1, time2;
        OrderTaker orderTaker;
        Cook cooker;
        public MainThread(int time1, OrderTaker orderTaker)
        {
            this.time1 = time1;
            this.orderTaker = orderTaker;
            Task.Run(() => runCustomer());
        }
        public MainThread(int time2, OrderTaker orderTaker, Cook cooker)
        {
            this.time2 = time2;
            this.orderTaker = orderTaker;
            this.cooker = cooker;
            Task.Run(() => runCook());
        }
        public void runCustomer()
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
        public void runCook()
        {
            while (true)
            {
                orderTaker.CookOrder(cooker);
                try
                {
                    Thread.Sleep(time2 * 1000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }

        }
    }
}
