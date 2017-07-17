using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseLights lights = new HouseLights();
            RemoteController rct = new RemoteController();

            rct.RunCommand(new TurnOnLights(lights));
            rct.UndoLastCommand();

            CeilingFan cf = new CeilingFan();
            rct.RunCommand(new CeilingFanSetSpeedHigh(cf));
            rct.UndoLastCommand();

            System.Console.WriteLine("////");

            ///////
            MacroCommand mcOnAll = new MacroCommand(new List<Command> { 
                new TurnOnLights(lights), 
                new CeilingFanSetSpeedHigh(cf) 
            });
            rct.RunCommand(mcOnAll);

            System.Console.ReadKey();
        }
    }
}
