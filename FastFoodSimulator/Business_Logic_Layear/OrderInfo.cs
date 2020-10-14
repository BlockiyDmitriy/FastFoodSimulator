using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layear
{
    class OrderInfo
    {
        public List<OrderTaker> waitingOrders = new List<OrderTaker>();
        public List<OrderTaker> readyOrders = new List<OrderTaker>();
    }
}
