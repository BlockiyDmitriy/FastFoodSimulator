using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Business_Logic_Layear.Interface;

namespace Business_Logic_Layear
{
    public class OrderTaker : IObservable
    {
        private List<IObserver> _observers;
        private List<Order> _waitingOrders = new List<Order>();
        private List<Order> _readyOrders = new List<Order>();
        public OrderTaker()
        {
            _observers = new List<IObserver>();
        }
        public void NotifyObservers()
        {
            foreach (IObserver o in _observers)
            {
                o.Update(_waitingOrders, _readyOrders);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        public void TakeOrder(Customer customer)
        {
            _waitingOrders.Add(new Order(customer));
            NotifyObservers();
        }

        public void CookOrder(Cook cooker)
        {
            if (_waitingOrders.Count != 0)
            {
                cooker.CookOrder(_waitingOrders[0]);
                _waitingOrders.RemoveAt(0);
                _readyOrders = cooker.readyOrders;
                NotifyObservers();
            }
        }
    }
}
