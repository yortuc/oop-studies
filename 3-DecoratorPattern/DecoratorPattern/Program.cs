using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECORATOR PATTERN

            DarkRoast dr = new DarkRoast();

            // dark roast
            System.Console.WriteLine(dr.getDescription() + ", " + dr.cost().ToString());

            Milk milkedDr = new Milk(dr);

            // dark roast with milk
            System.Console.WriteLine(milkedDr.getDescription() + ", " + milkedDr.cost().ToString());

            Mocha mochaDr = new Mocha(milkedDr);
            mochaDr = new Mocha(mochaDr);

            // dark roast with milk and double mocha
            System.Console.WriteLine(mochaDr.getDescription() + ", " + mochaDr.cost().ToString());

            System.Console.ReadKey();
        }
    }
}
