using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var cpu = new Cpu(150m);
            var ram = new Cpu(30m);
            var cust1 = new Customer();
            var cust2 = new Customer();
            cpu.AddFollower(cust1);
            ram.AddFollower(cust2);

            cpu.Price = 100m;
            ram.Price = 15m;
            Console.Read();

        }
    }
}
