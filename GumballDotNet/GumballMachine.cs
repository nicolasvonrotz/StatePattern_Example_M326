using GumballDotNet.States;

namespace GumballDotNet
{
    public class GumballMachine
    {
        public IState activeState;
        public int count = 0;

        public GumballMachine(int count)
        {
            this.count = count;
            if (count > 0)
                activeState = new NoQuaterState(this);
            else
                activeState = new SoldOutState(this);
        }

        public void insertQuarter()
        {
            activeState.insertQuarter();
        }

        public void ejectQuarter()
        {
            activeState.ejectQuarter();
        }

        public void turnCrank()
        {
            activeState.turnCrank();
        }

        public void dispense()
        {
            activeState.dispense(count);
        }

        public override string ToString()
        {
            return activeState.ToString();
        }

        public void refill(int numGumBalls)
        {
            this.count = numGumBalls;
            activeState = new NoQuaterState(this);
        }
    }
}
