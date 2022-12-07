using System;

namespace GumballDotNet.States
{
    internal class SoldState : IState
    {
        public GumballMachine gumballMachine = null;

        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense(int count)
        {
            Console.WriteLine("A gumball comes rolling out the slot");
            int newCount = count - 1;
            if (newCount == 0)
            {
                Console.WriteLine("Oops, out of gumballs!");
                gumballMachine.activeState = new SoldOutState(gumballMachine);
            }
            else
            {
                gumballMachine.activeState = new NoQuaterState(gumballMachine);
            }
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void insertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
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
            result += "delivering a gumball";
            result += "\n";
            return result;
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }
    }
}
