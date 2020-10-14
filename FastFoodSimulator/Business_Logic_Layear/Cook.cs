using Business_Logic_Layear.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layear
{
    class Cook : IObserver
    {
        IObservable orderTaker;
        public Cook(IObservable obs)
        {
            orderTaker = obs;
            orderTaker.RegisterObserver(this);
        }
        public void Update(object ob)
        {
            OrderInfo otInfo = (OrderInfo)ob;
        }
    }
}
