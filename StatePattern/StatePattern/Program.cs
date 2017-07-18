using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Naive implementation
            naive();

            // 
            Console.WriteLine("---");

        }

        private static void naive()
        {
            GumballMachine gbm = new GumballMachine(count: 20);
            gbm.insertQuarter();
            gbm.insertQuarter();
            gbm.turnCrank();
            gbm.turnCrank();
            Console.ReadKey();
        }
    }
}
