using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Printer
    {
        private static Printer currentPrinter;

        private Printer()
        {
            // private constructor to prevent instane creation 
            // elsewhere in code.
        }

        // make thread-safe 
        // wait here for one thread to finish it
        // so, there will not be several printer instances
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static Printer getInstance()
        {
            System.Console.WriteLine("looking for the printer");

            if (currentPrinter == null) {
                currentPrinter = new Printer();
                System.Console.WriteLine("printer has not been reached before, reaching now...");
            }
            else{
                System.Console.WriteLine("i already know the printer");
            }

            return currentPrinter;
        }
    }
}
