using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    internal class Request
    {
        public bool IsAuthenticated { get; set; }
        public bool IsAuthorized { get; set; }
    }
}
