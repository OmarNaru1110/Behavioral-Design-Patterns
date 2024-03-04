using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    internal class OpenGateState : IGateState
    {
        private readonly Gate _gate;

        public OpenGateState(Gate gate)
        {
            _gate = gate;
        }
        public void Enter()
        {
            Console.Write("Entering");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            //after entering the gate will close
            _gate.ChangeState(new ClosedGateState(_gate));
        }

        public void PayFailed()
        {
            //that means you paid while the gate is already open, like you paid twice maybe
            //first time: the gate will open and waiting for you to enter
            //second time: you didn't enter instead, you paid again and that paid was failed 
            //so the gate will still open
            Console.WriteLine("Open");
        }

        public void PayOk()
        {
            //the same scenario as before, you paid twice the first payment has been done successfully
            //and the gate will open and waiting for you to enter
            //but u didn't enter instead you paid again, and the was ok , so it will still be open
            //ofcourse u should handle such things, like not letting users to pay twice etc...
            //but am not doing that cuz it's just an example
            Console.WriteLine("Open");
        }
    }
}
