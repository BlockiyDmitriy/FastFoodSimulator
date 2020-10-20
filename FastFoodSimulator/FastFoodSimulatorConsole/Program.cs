using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Business_Logic_Layear;
using Business_Logic_Layear.Interface;

namespace FastFoodSimulatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderTaker orderTaker = new OrderTaker();
            IObserver ordersDisplay = new Display();
            Cook cooker = new Cook();
            orderTaker.RegisterObserver(ordersDisplay);

            Console.WriteLine("Введите интервал поступления заказов ");
            int intervalOrder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите время готовки заказов");
            int timeCook = Convert.ToInt32(Console.ReadLine());

            ThreadCustomer t1 = new ThreadCustomer(intervalOrder, orderTaker);
            ThreadCooker t2 = new ThreadCooker(timeCook, orderTaker, cooker);

            t1.run();
            t2.run();
        }
    }
}
