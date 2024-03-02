using System.Runtime.InteropServices;

namespace Command_Pattern
{
    internal class Program
    {
        /*
         in our scenario we didn't an Unexecute method cuz we don't need it in this example
         but another scenario I think it may have an unexecute method
         is photoshop, when u do anything (command), you can undo it by pressing ctrl+z
         */
        static void Main(string[] args)
        {
            //create the mouse
            Mouse mouse = new Mouse();
            //create the command
            ICommand macroCommand = new MacroCommand(mouse);
            //generate the queue
            Queue<string> keysPressed = new Queue<string>();
            keysPressed.Enqueue("ctrl");
            keysPressed.Enqueue("c");
            //instantiate mouse interface
            MouseInterface mouseInterface = new MouseInterface(macroCommand);
            //execute
            mouseInterface.ClickMacroButton(keysPressed);
        
        }
    }
}
