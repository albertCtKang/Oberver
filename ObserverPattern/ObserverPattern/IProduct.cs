using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    //Subject
    public interface IProduct
    {
       string Name { get; }
       decimal Price { get; }
       void Notify(decimal price);
    }
}
