using Business_Logic_Layear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FastFoodSimulatorConsole
{
    class ThreadCooker
    {
        int time1;
        OrderTaker orderTaker;
        Cook cooker;

        public ThreadCooker(int time1, OrderTaker orderTaker, Cook cooker)
        {
            this.time1 = time1;
            this.orderTaker = orderTaker;
            this.cooker = cooker;
        }

        public void run()
        {
            while (true)
            {
                orderTaker.CookOrder(cooker);
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
