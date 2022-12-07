using System;

namespace GumballDotNet.States
{
    internal class NoQuaterState : IState
    {
        public GumballMachine gumballMachine = null;

        public NoQuaterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense(int count)
        {
            Console.WriteLine("You need to pay first");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void insertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumballMachine.activeState = new HasQuarterState(gumballMachine);
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
            result += "waiting for quarter";
            result += "\n";
            return result;
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned but there's no quarter");
        }
    }
}
