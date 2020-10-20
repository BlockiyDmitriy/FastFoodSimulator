using Business_Logic_Layear.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business_Logic_Layear
{
    public class Cook
    {
        public List<Order> readyOrders = new List<Order>();

        public void CookOrder(Order currentOrder)
        {
            readyOrders.Add(currentOrder);
        }
    }
}
