using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    internal class ClosedGateState:IGateState
    {
        private readonly Gate _gate;

        public ClosedGateState(Gate gate)
        {
            _gate = gate;
        }

        public void Enter()
        {
            //the gate will still be closed so u don't have to do anything here
            Console.Write("Entering");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }
            Console.WriteLine("Closed");
        }

        public void PayFailed()
        {
            //the gate will still be closed so u don't have to do anything here
            Console.WriteLine("Your Pay hasn't been done Successfully! Closed");
        }

        public void PayOk()
        {
            Console.WriteLine("Your Pay has been done Successfully! Open");
            //the gate will open now
            _gate.ChangeState(new OpenGateState(_gate));
        }
    }
}
