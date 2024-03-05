using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    internal class WebApp : MiddleWare
    {
        private MiddleWare _next;
        public void Handle(Request request)
        {
            Console.Write("Web App Running");
            for (int i =0; i < 30; i++)
            {
                Console.Write(".");
                Thread.Sleep(80);
            }
            if(_next!= null)
                _next.Handle(request);
        }

        public void SetNext(MiddleWare m)
        {
            _next = m;
        }
    }
}
