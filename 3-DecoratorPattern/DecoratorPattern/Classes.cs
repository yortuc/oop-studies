using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public abstract string getDescription();
        public abstract double cost();
    }

    public class DarkRoast : Beverage
    {
        public override string getDescription() { return "Dark Roast Coffee"; }
        public override double cost() { return 4.9; }
    }

    // inherit the decorator from beverage to make them interchangable
    // so that a decorated object has no diff from a non-decorated object
    public abstract class BeverageDecorator : Beverage
    {
        public Beverage beverage;
        public override abstract string getDescription();
        public BeverageDecorator(Beverage beverage) {
            this.beverage = beverage;
        } 
    }

    public class Milk : BeverageDecorator
    {
        public Milk(Beverage beverage) : base(beverage) { }
        public override string getDescription() {
            return this.beverage.getDescription() + ",milk";
        }
        public override double cost() {
            return this.beverage.cost() + 1.5;
        }
    }

    public class Mocha : BeverageDecorator
    {
        public Mocha(Beverage beverage) : base(beverage) {}
        public override string getDescription() {
            return this.beverage.getDescription() + ",mocha";
        }
        public override double cost()  {
            return this.beverage.cost() + 2.25;
        }
    }
}