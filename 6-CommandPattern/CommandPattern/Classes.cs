using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public interface Command {
        void run();
        void undo();
    }

    /* Commands */
    public class TurnOnLights : Command {
        private HouseLights lights; //encapsulate the device to be controlled
        public TurnOnLights(HouseLights lights) { this.lights = lights; }
        public void run() { 
            // control the device on execution
            this.lights.On(); 
        }
        public void undo() { this.lights.Off(); }
    }

    // can hold multiple commands and run them at once
    public class MacroCommand : Command {
        private List<Command> commands;
        public MacroCommand(List<Command> commands) { this.commands = commands; }
        public void run() {
            this.commands.ForEach(c => c.run());
        }
        public void undo() {
            this.commands.ForEach(c => c.undo());
        }
    }

    public class TurnOffLights : Command {
        private HouseLights lights;
        public TurnOffLights(HouseLights lights) { this.lights = lights; }
        public void run() {
            this.lights.Off();
        }
        public void undo() { this.lights.On(); }
    }

    public class CeilingFanSetSpeedHigh : Command
    {
        private CeilingFan cf;
        private CeilingFan.FanSpeed lastFanSpeed;

        public CeilingFanSetSpeedHigh(CeilingFan cf) { this.cf = cf; }
        public void run() {
            lastFanSpeed = cf.getSpeed();
            this.cf.setSpeed(CeilingFan.FanSpeed.HIGH); 
        }
        public void undo() {
            this.cf.setSpeed(lastFanSpeed);
        }
    }

    /* Remote contoller to control smart house */
    public class RemoteController {
        Command lastCommand;
        public void RunCommand(Command cmd) {
            cmd.run();
            lastCommand = cmd;
        }
        public void UndoLastCommand() {
            System.Console.WriteLine("Undoing the last command...");
            lastCommand.undo();
        }
    }

    /* Controllable, smart things in da house */

    public class HouseLights
    {
        public void On() { System.Console.WriteLine("Lights are on"); }
        public void Off() { System.Console.WriteLine("Lights are off"); }
    }

    public class CeilingFan
    {
        public enum FanSpeed { HIGH, MID, LOW, OFF };
        private FanSpeed speed = FanSpeed.OFF;  // off at start
        public void setSpeed(FanSpeed fs) {
            this.speed = fs;
            System.Console.WriteLine("Fan speed set to " + speed);
        }
        public FanSpeed getSpeed() { return this.speed; }
    }
}
