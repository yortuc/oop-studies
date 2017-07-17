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
            WeatherDataObject wdo = new WeatherDataObject();

            CurrentConditionsDisplay ccd = new CurrentConditionsDisplay(wdo);

            wdo.setMeasurements(4, 5, 6);
            wdo.setMeasurements(7, 8, 9);
            wdo.setMeasurements(14, 15, 16);

            System.Console.ReadKey();
        }
    }
}
