using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Logic_Layear;
using Business_Logic_Layear.Interface;

namespace FastFoodSimulatorConsole
{
    class Display : IObserver
    {
        List<Order> waitingOrders;
        List<Order> readyOrders;

        public void Update(List<Order> a, List<Order> b)
        {
            waitingOrders = a;
            readyOrders = b;
            DisplayMethod();
        }

        public void DisplayMethod()
        {
            Console.WriteLine("Ожидающие заказы:");
            foreach (Order o in waitingOrders)
            {
                Console.WriteLine(o.getName() + " ");
            }
            Console.WriteLine("Готовые заказы:");
            foreach (Order o in readyOrders)
            {
                Console.WriteLine(o.getName() + " ");
            }
        }
    }
}
