using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    internal class MouseInterface //it's not programming interface, it's represents the skeleton of the mouse that has the buttons
    {
        private readonly ICommand _macroCommand;

        public MouseInterface(ICommand macroCommand)
        {
            _macroCommand = macroCommand;
        }
        public void ClickMacroButton(Queue<string> keysPressed)
        {
            _macroCommand.Execute(keysPressed);
        }
        /*
         other mouse buttons
         ClickLeft
         ClickRight
         ClickScroll
         ......
         */
    }
}
