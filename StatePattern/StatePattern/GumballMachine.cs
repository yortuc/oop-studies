using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class GumballMachine
    {
        public int SOLD_OUT = 1;
        public int NO_QUARTER = 2;
        public int HAS_QUARTER = 3;
        public int SOLD = 4;

        public int state;
        public int count = 0;

        public GumballMachine(int count)
        {
            this.count = count;
            if (count > 0) {
                this.state = NO_QUARTER;
            }
            else {
                this.state = SOLD_OUT;
            }
        }

        // implement actions as methods
        public void insertQuarter()
        {
            if (state == SOLD_OUT) {
                Console.WriteLine("You cant insert quarter. Gumballs are sold out.");
            }
            else if (state == HAS_QUARTER) {
                Console.WriteLine("There is already a quarter in the machine. you cannot insert another one.");
            }
            else if (state == SOLD) {
                Console.WriteLine("We are preparing your gumball. please wait. dont try to insert another quarter before getting the one being prepared.");
            }
            else if (state == NO_QUARTER) {
                state = HAS_QUARTER;
                Console.WriteLine("You inserted a quarter.");
            }
        }

        public void turnCrank()
        {
            if (state == SOLD_OUT) {
                Console.WriteLine("You turned but there are no gumballs left in the machine...");
            }
            else if (state == HAS_QUARTER) {
                Console.WriteLine("You turned crank... gumball is on its way now...");
                state = SOLD;
                dispense();
            }
            else if (state == SOLD)  {
                Console.WriteLine("Turning crank twice doesnt get you another gumball");
            }
            else if (state == NO_QUARTER) {
                Console.WriteLine("You turned the crank but there is no quarter. Gumballs are not free!");
            }
        }

        private void dispense()
        {
            if (state == SOLD_OUT || state == NO_QUARTER || state == HAS_QUARTER){
                Console.WriteLine("No gumball dispensed");

            }
            else if (state == SOLD) {
                count -= 1;
                if (count == 0) {
                    Console.WriteLine("Out of gumballs");
                    state = SOLD_OUT;
                }
                else {
                    state = NO_QUARTER;
                    Console.WriteLine("Gumball dispensed. " + count.ToString() + " gumballs left");
                }
            }
        }
    }
}
