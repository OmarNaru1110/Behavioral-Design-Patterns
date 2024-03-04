using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    internal interface IGateState
    {
        void PayOk();
        void PayFailed();
        void Enter();
    }
}
