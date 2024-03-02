using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    internal class MacroCommand : ICommand
    {
        private readonly Mouse _mouse;

        public MacroCommand(Mouse mouse)
        {
            _mouse = mouse;
        }
        public void Execute(Queue<string> keysPressed=null)
        {
            _mouse.DoMacro(keysPressed);
            //ofcourse in real scenario it won't be done like this, it will first 
            //record the keys pressed then append them to the queue
        }
    }
}
