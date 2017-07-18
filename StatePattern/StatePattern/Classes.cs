using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public interface State
    {
        void insertQuarter();
        void turnCrank();
    }

    public class GumballMachine2
    {
        private State state;

        public void setState(State state)
        {

        }
    }

    // states
    public class NoQuarterState : State
    {

    }
}
