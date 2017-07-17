using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChicagoPizzaStore cps = new ChicagoPizzaStore();
            NYPizzaStore nps = new NYPizzaStore();

            cps.orderPizza("cheese");
            nps.orderPizza("cheese");

            System.Console.ReadKey();
        }
    }
}
