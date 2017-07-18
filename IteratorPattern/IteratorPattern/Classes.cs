using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class MenuItem {
        public string name;
        public double price;
    }

    public interface Iterator<T> {
        T next();
        bool hasNext();
    }

    public class DinnerMenu : Iterator<MenuItem>
    {
        private int index = 0;
        private List<MenuItem> menuItems;
        public DinnerMenu() { 
            menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem { name = "Roasted Chicken", price = 1.0 });
            menuItems.Add(new MenuItem { name = "Pizza", price = 2.0 });
        }


        public MenuItem next() {
            return menuItems[index++];
        }

        public bool hasNext() {
            return index < menuItems.Count();
        }
    }

    public class LunchMenu : Iterator<MenuItem>
    {
        int index = 0;
        MenuItem[] menuItems;
        public LunchMenu() { 
            menuItems = new MenuItem[2];
            menuItems[0] = new MenuItem { name = "Coffe", price = 0.5 };
            menuItems[1] = new MenuItem { name = "Tea", price = 0.3 };
        }

        public MenuItem next() {
            return menuItems[index++];
        }

        public bool hasNext(){
            return index < menuItems.Length;
        }
    }

    // different inner implementations for lunchmenu and dinnermenu collections
    // but elements can be reached via same iterator interface
    public class Waitress
    {
        DinnerMenu dm;
        LunchMenu lm;

        public Waitress(DinnerMenu dm, LunchMenu lm) {
            this.dm = dm;
            this.lm = lm;
        }

        public void printMenu() {
            Console.WriteLine("Lunch menu:::");
            printMenu(lm);
            Console.WriteLine("Dinner menu:::");
            printMenu(dm);
        }

        private void printMenu(Iterator<MenuItem> iterator) {
            while (iterator.hasNext())  {
                Console.WriteLine(iterator.next().name);
            }
        }
    }
}
