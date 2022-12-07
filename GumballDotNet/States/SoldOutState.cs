using System;

namespace GumballDotNet.States
{
    internal class SoldOutState : IState
    {
        public GumballMachine gumballMachine = null;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense(int count)
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void insertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
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
            result += "sold out";
            result += "\n";
            return result;
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }
    }
}
