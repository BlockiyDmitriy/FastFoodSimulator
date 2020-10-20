using Business_Logic_Layear.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layear
{
    public class Customer
    {
        private string _name;
        public Customer(String name)
        {
            this._name = name;
        }
        public string getName()
        {
            return this._name;
        }
    }
}
