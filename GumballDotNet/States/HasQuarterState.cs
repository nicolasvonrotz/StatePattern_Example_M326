using System;

namespace GumballDotNet.States
{
    internal class HasQuarterState : IState
    {
        public GumballMachine gumballMachine = null;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense(int count)
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumballMachine.activeState = new NoQuaterState(gumballMachine);
        }

        public void insertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public override String ToString()
        {
            String result = "";
            result += "\nMighty Gumball, Inc.";
            result += "\nJava-enabled Standing Gumball Model #2004\n";
            result += "Inventory: " + gumballMachine.count + " gumball";
            if (gumballMachine.count != 1)
            {
                result += "s";
            }
            result += "\nMachine is ";
            result += "waiting for turn of crank";
            result += "\n";
            return result;
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned...");
            gumballMachine.activeState = new SoldState(gumballMachine);
            gumballMachine.dispense();
        }
    }
}
