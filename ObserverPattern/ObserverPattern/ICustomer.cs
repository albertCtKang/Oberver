using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //observer
    public interface ICustomer
    {
        void Update(IProduct product);
    }
}
