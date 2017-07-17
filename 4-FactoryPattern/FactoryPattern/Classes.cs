using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class PizzaStore
    {
        // this method is going to be implemented by sublasses of PizzaStore like regional pizza stores
        public abstract Pizza createPizza(string type); 

        public void orderPizza(string type)
        {
            Pizza pizza = createPizza(type);

            // orderPizza method has no info about pizza (decoupled)
            System.Console.WriteLine("pizza ordered :" + pizza.name);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
        }
    }

    public class NYPizzaStore : PizzaStore {
        public override Pizza createPizza(string type) {
            // object creation is delegated to this method
            if (type == "cheese") return new NYCheesePizza();
            else return new NYPepperoniPizza();
        }
    }

    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type) {
            if (type == "cheese") return new ChicagoCheesePizza();
            else return new ChicagePepperoniPizza();
        }
    }

    public class Pizza { 
        public string name;
        public void prepare() { System.Console.WriteLine("pizza is being prepared"); }
        public void bake() { System.Console.WriteLine("pizza is being baked"); }
        public void cut() { System.Console.WriteLine("pizza is being cut"); }
        public void box() { System.Console.WriteLine("pizza is being boxed"); }
    }

    public class NYCheesePizza : Pizza { }
    public class ChicagoCheesePizza : Pizza { }

    public class NYPepperoniPizza : Pizza { }
    public class ChicagePepperoniPizza : Pizza { }

}
