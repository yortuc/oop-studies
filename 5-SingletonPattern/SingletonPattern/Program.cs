using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = Printer.getInstance();

            System.Console.WriteLine("---");

            var pra = Printer.getInstance();

            System.Console.ReadKey();

            // fails
            // var zaa = new Printer();
        }
    }
}
