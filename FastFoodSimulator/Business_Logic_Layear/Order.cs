using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layear
{
    public class Order
    {
        private string _name;
        private string _id;

        public string getName()
        {
            return _name + _id;
        }

        public Order(Customer customer)
        {
            Random random = new Random();
            this._name = customer.getName();
            _id = " #" + (random.Next() * 200 + 1);
        }
    }
}
