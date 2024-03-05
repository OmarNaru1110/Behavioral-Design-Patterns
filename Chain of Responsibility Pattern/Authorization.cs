using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    internal class Authorization : MiddleWare
    {
        private MiddleWare _next;
        public void Handle(Request request)
        {
            if(request.IsAuthorized == true)
            {
                foreach (var item in "Authorized!")
                {
                    Console.Write(item);
                    Thread.Sleep(80);
                }
                Console.WriteLine();
                if (_next != null)
                    _next.Handle(request);
            }
            else
                Console.WriteLine("you are not authorized!");
        }

        public void SetNext(MiddleWare m)
        {
            _next = m;
        }
    }
}
