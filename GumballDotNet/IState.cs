using System;

namespace GumballDotNet
{
    public interface IState
    {
        void insertQuarter();
        void ejectQuarter();
        void turnCrank();
        void dispense(int count);
        String ToString();
    }
}
