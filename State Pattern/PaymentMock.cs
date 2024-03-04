using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern
{
    internal class PaymentMock
    {
        public bool Pay(int x)
        {
            //if x is even, the payment is ok
            //else the payment has failed
            return x % 2 == 0;
        }
    }
}
