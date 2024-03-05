using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    internal interface MiddleWare
    {
        void SetNext(MiddleWare m);
        void Handle(Request request);
    }
}
