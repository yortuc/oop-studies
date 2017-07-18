using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class Beverage
    {
        public void prepare() {
            start();
            boilWater();
            waterBoiled();
            addCondiments();
            condimentsAdded();
            serve();
            served();
        }

        public virtual void start() { }   // hook
         
        public void boilWater() { // concrete implementation
            System.Console.WriteLine("started heating the water...");
        }

        public virtual void waterBoiled() { }

        public abstract void addCondiments();   // subclass must implement this method

        public virtual void condimentsAdded() { }  // hook. sublclass may or not implement this method

        public abstract void serve();

        public virtual void served() { }
    }

    // create a subclass and implement abstract methods (mandatory)
    // there are hook methods that can be overriden     (optional)
    public class Tea : Beverage {
        public override void start() {
            System.Console.WriteLine("preperation started. i know that from hook.");
        }

        public override void waterBoiled() {
            System.Console.WriteLine("water boiled.");
        }

        public override void addCondiments() {
            System.Console.WriteLine("tea added to cup.");
        }

        public override void condimentsAdded() {
            System.Console.WriteLine("condiments added");
        }

        public override void serve() {
            System.Console.WriteLine("tea is served");
        }
    }
}
