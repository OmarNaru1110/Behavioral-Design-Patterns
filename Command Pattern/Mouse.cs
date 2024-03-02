using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    internal class Mouse
    {
        public void DoMacro(Queue<string> KeysPressed)
        {
            //do it using operating system or something idk
            //but for the sake of the example i'll just print them
            while (KeysPressed.Count!=0)
            {
                var key = KeysPressed.Dequeue();
                Console.Write($"{key} ");
            }
        }
    }
}
