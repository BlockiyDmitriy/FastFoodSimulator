using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Business_Logic_Layear.Interface;

namespace Business_Logic_Layear
{
    class OrderTaker : IObservable
    {
        OrderTaker otInfo;
        List<IObserver> observers;

        public OrderTaker()
        {
            observers = new List<IObserver>();
        }
        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(otInfo);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
    }
}
