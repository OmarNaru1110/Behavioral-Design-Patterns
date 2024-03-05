using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    internal class Authentication : MiddleWare
    {
        private MiddleWare _next;
        public void SetNext(MiddleWare m)
        {
            _next = m;
        }

        public void Handle(Request request)
        {
            if(request.IsAuthenticated == true)
            {
                foreach (var item in "Authenticated!")
                {
                    Console.Write(item);
                    Thread.Sleep(80);
                }
                Console.WriteLine();
                if (_next != null)
                    _next.Handle(request);
            }
            else
                Console.WriteLine("you are not authenticated!");
        }
    }
}
