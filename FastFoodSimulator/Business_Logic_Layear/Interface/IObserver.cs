using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layear.Interface
{
    public interface IObserver
    {
        void Update(List<Order> xWait, List<Order> yWait);
    }
}
